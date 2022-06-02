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

        public FrmBienbanVP(string madg, string date, List<string> book, string manv)
        {
            madocgia = madg;
            ngaytra = date;
            book1 = book;
            // quahan = qua;
            InitializeComponent();
            manv = MaNhanVien;
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
                dgvVipham.Rows.Add(i, bbvp_bus.get_tensach(i), "", "");

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

                lydo += dgvVipham.Rows[i].Cells[2].Value.ToString();
                if (i != dgvVipham.RowCount - 1)
                {
                    lydo += ", ";
                }
            }
            bbvp.TienPhat = int.Parse(txtTongtien.Text);

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
                    if (dgvVipham.Rows[k].Cells[0].Value.ToString().Contains("mất"))
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

            }


        }


        private void dgvVipham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            txtTennv.Text = bbvp_bus.Get_tennv(txtManv.Text);
        }



        private void dgvVipham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double tongtien = 0;
            //int i = e.RowIndex;
            double tientre = 0;
            double tienhong = 0;
            double tienmat = 0;
            double tienphat;
            for (int i = 0; i < dgvVipham.RowCount; i++)
            {
                string lydo = dgvVipham.Rows[i].Cells["Lydo"].Value.ToString();
                string Masach = dgvVipham.Rows[i].Cells[0].Value.ToString();
                tientre = bbvp_bus.Songaytre(Masach) * 1000;
                tienhong = bbvp_bus.TienPhat(Masach) * 0.2;
                tienmat = bbvp_bus.TienPhat(Masach) * 1.5;
                tienphat = 0;
                if (lydo != "")
                { 
                    if (lydo.Contains("trễ") || lydo.Contains("muộn"))
                    {
                        if (bbvp_bus.Songaytre(Masach) < 0)
                        {
                            MessageBox.Show("Cuốn sách này chưa đến hạn trả. Vui lòng chọn lý do khác!");
                        }
                        else
                        {
                            tienphat = tientre;
                            if (lydo.Contains("hỏng") && lydo.Contains("mất"))
                            {
                                tienphat = Math.Max(tientre, tienhong);
                                tienphat = Math.Max(tienphat, tienmat);
                            }

                            ///== ko else nữa    if thui
                            
                            if (lydo.Contains("mất") && !lydo.Contains("hỏng"))
                            {
                                tienphat = Math.Max(tienphat, tienmat);
                            }
                            
                            if (lydo.Contains("hỏng") && !lydo.Contains("mất"))
                            {
                                tienphat = Math.Max(tienphat, tienmat);
                            }


                        }
                    }
                    else
                    {
                        if ((lydo.Contains("hỏng") && lydo.Contains("mất")) || (lydo.Contains("mất") && !lydo.Contains("hỏng")))
                        {
                            tienphat = tienmat;
                        }
                        else if (lydo.Contains("hỏng") && !lydo.Contains("mất"){
                            tienphat = tienhong;
                        }

                    }
                    dgvVipham.Rows[i].Cells[3].Value = tienphat.ToString();
                    tongtien += tienphat;
                }
                else
                {
                    MessageBox.Show("Nhập vào lý do");
                }
            }

            txtTongtien.Text = tongtien.ToString();
        }
    }
}


