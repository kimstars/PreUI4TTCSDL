using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.BUS;
using LibraryManager.Template;
using LibraryManager.DTO;
namespace LibraryManager.GUI
{
    public partial class FrmBienbanVP : Form
    {
        BienbanVP_BUS bbvp_bus = new BienbanVP_BUS();
        Xu_ly_tra xlt = new Xu_ly_tra();
        string madocgia = "";
        string ngaytra = "";
        string maVP = "";
        // bool quahan = false;
        List<string> book1 = new List<string>();
        public FrmBienbanVP()
        {
            InitializeComponent();
        }

        string MaNhanVien = "";
        public FrmBienbanVP(string MaNV)
        {
            InitializeComponent();
            MaNhanVien = MaNV;
        }

        public FrmBienbanVP(string madg, string date, List<string> book)
        {
            madocgia = madg;
            ngaytra = date;
            book1 = book;
            // quahan = qua;
            InitializeComponent();
        }
        /*private void txtMadg_TextChanged(object sender, EventArgs e)
        {
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);
        }*/



        private void FrmBienbanVP_Load(object sender, EventArgs e)
        {
            txtMadg.Text = madocgia;
            txtNgaytra.Text = ngaytra;
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);

            txtTennv.Text = bbvp_bus.Get_tennv(txtManv.Text);
            AutoTaoMaVP();

            foreach (string i in book1)
            {
                dgvVipham.Rows.Add(i, bbvp_bus.get_tensach(i),"","");

            }
            dgvVipham.Show();
            /* if(quahan == true)
             {
                 cboxTrehan.Checked = true;
                 cboxTrehan.Enabled = false;
             }*/

        }

        private void AutoTaoMaVP()
        {
            string index = (bbvp_bus.Get_slVP() + 1).ToString();
            maVP = "VP000000";
            maVP = maVP.Substring(0, 8 - index.Length) + index;
            txtMaVP.Text = maVP;

        }



        private void btnHoanthien_Click(object sender, EventArgs e)
        {
            BienBanViPham bbvp = new BienBanViPham();
            bbvp.MaDocGia = txtMadg.Text.Trim();
            bbvp.MaNhanVien = txtManv.Text.Trim();
            bbvp.MaViPham = txtMaVP.Text;
            long tienphat = 0;
            string lydo = "";
            for (int i = 0; i < dgvVipham.RowCount; i++)
            {
                tienphat += int.Parse(dgvVipham.Rows[i].Cells[3].Value.ToString());
                lydo += dgvVipham.Rows[i].Cells[2].Value.ToString();
            }
            bbvp.TienPhat = tienphat;

            bbvp.LyDo = lydo;
            bbvp.TinhTrangSach = txt_tinhtrang.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn hoàn tất biên bản", "Hỏi đáp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bbvp_bus.insertBB(bbvp);

                for (int k = 0; k < dgvVipham.RowCount; k++)
                {
                    ViPham vp = new ViPham();
                    vp.MaSach = dgvVipham.Rows[k].Cells[0].Value.ToString();
                    vp.MaViPham = txtMaVP.Text;
                    bbvp_bus.Them_vp(vp);
                    if (dgvVipham.Rows[k].Cells[0].Value.ToString() == "làm mất sách")
                    {
                        //update ngày trả và set trạng thái cuốn sách đó bằng 0
                        bbvp_bus.update0(vp.MaSach);
                    }
                    else
                    {
                        //update ngày trả và set trạng thái cuốn sách đó bằng 1
                        bbvp_bus.update1(vp.MaSach);
                    }

                }
                /*if(cboxTrehan.Checked == true)
                {
                    bbvp_bus.update_loaiTK(txtMadg.Text.Trim());
                }*/
            }
            // bbvp.LyDo = lstBoxLydo.Items.cố

        }

        /*private void guna2Button1_Click(object sender, EventArgs e)
        {
            BienBanViPham bbvp = new BienBanViPham();
            bbvp.MaViPham = txtMaVP.Text;
            long tienphat = 0;
            string lydo = "";
            for (int i = 0; i < dgvVipham.RowCount; i++)
            {
                tienphat += int.Parse(dgvVipham.Rows[i].Cells[3].Value.ToString());
                lydo += dgvVipham.Rows[i].Cells[2].Value.ToString();
            }
            bbvp.TienPhat = tienphat;

            bbvp.LyDo = lydo;
            bbvp.TinhTrangSach = txt_tinhtrang.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa biên bản", "Hỏi đáp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bbvp_bus.suabb(bbvp);

            }
        }*/



        private void dgvVipham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            txtTennv.Text = bbvp_bus.Get_tennv(txtManv.Text);
        }



        private void dgvVipham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            for (int i = 0; i < dgvVipham.RowCount; i++)
            {
                string lydo = dgvVipham.Rows[i].Cells["Lydo"].Value.ToString();
                string Masach = dgvVipham.Rows[i].Cells[0].Value.ToString();
                if (lydo != "")
                {
                    if (lydo.Contains("trả sách trễ hạn"))
                    {

                        if (bbvp_bus.Songaytre(Masach) < 0)
                        {
                            MessageBox.Show("Cuốn sách này chưa đến hạn trả. Vui lòng chọn lý do khác!");
                        }
                        else
                        {
                            long tienphat = bbvp_bus.Songaytre(Masach) * 2000;// phạt trễ hạn 2000/ngày
                            dgvVipham.Rows[i].Cells[3].Value = tienphat.ToString();
                            
                        }
                    }
                    else if (lydo.Contains("làm hỏng sách"))
                    {

                        dgvVipham.Rows[i].Cells[3].Value = (bbvp_bus.TienPhat(Masach) * 0.2).ToString();
                        

                    }
                    else if (lydo.Contains("làm mất sách"))
                    {
                        dgvVipham.Rows[i].Cells[3].Value = (bbvp_bus.TienPhat(Masach) * 1.5).ToString();

                    }
                }



            }
        }
    }
}


