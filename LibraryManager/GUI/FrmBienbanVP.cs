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
            MaNhanVien = manv;

        }
        /*private void txtMadg_TextChanged(object sender, EventArgs e)
        {
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);
        }*/



        private void FrmBienbanVP_Load(object sender, EventArgs e)
        {
            txtMadg.Text = madocgia;
            txtNgaytra.Text = ngaytra;
            txtManv.Text = MaNhanVien;
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
            bbvp.TongTP = 0;
            DialogResult result = MessageBox.Show("Bạn có muốn hoàn tất biên bản", "Hỏi đáp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bbvp_bus.insertBB(bbvp);

                for (int k = 0; k < dgvVipham.RowCount; k++)
                {
                    ViPham vp = new ViPham();
                    vp.MaSach = dgvVipham.Rows[k].Cells[0].Value.ToString();
                    vp.MaViPham = txtMaVP.Text;
                    vp.Lydo = dgvVipham.Rows[k].Cells[2].Value.ToString();
                    vp.TienPhat = int.Parse(dgvVipham.Rows[k].Cells[3].Value.ToString());

                    bbvp_bus.Them_vp(vp);
                    if (dgvVipham.Rows[k].Cells[2].Value.ToString().Contains("mất"))
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
          
            int y = e.ColumnIndex;
            double tientre = 0;
            double tienhong = 0;
            double tienmat = 0;

            double tienphat;
            for (int i = 0; i < dgvVipham.RowCount; i++)
            {
                if (i >= 0 && y == 2)
                {
                    string lydo = dgvVipham.Rows[i].Cells["Lydo"].Value.ToString();
                    if (lydo != "")
                    {

                        string Masach = dgvVipham.Rows[i].Cells[0].Value.ToString();
                        tientre = bbvp_bus.Songaytre(Masach) * 1000;
                        tienhong = bbvp_bus.TienPhat(Masach) * 0.2;
                        tienmat = bbvp_bus.TienPhat(Masach) * 1.5;
                        tienphat = 0;

                        if (lydo.Contains("trễ") || lydo.Contains("muộn"))
                        {
                            if (bbvp_bus.Songaytre(Masach) < 0)
                            {
                                MessageBox.Show("Cuốn sách này chưa đến hạn trả. Vui lòng chọn lý do khác!");
                            }
                            else
                            {

                                if (lydo.Contains("hỏng"))
                                {
                                    tienphat = Math.Max(tientre, tienhong);
                                }
                                else if (lydo.Contains("mất"))
                                {
                                    tienphat = Math.Max(tientre, tienmat);
                                }
                                else
                                {
                                    tienphat = tientre;
                                }

                            }
                        }
                        else
                        {
                            if (lydo.Contains("hỏng"))
                            {
                                tienphat = tienhong;
                            }
                            else if (lydo.Contains("mất"))
                            {
                                tienphat = tienmat;
                            }

                        }
                        dgvVipham.Rows[i].Cells[3].Value = tienphat.ToString();
                        tongtien += tienphat;
                    }

                }
            }
            lbTienPhat.Text = tongtien.ToString();

        }
    }
}


