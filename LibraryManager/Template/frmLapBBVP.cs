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
using LibraryManager.DTO;
namespace LibraryManager.Template
{
    public partial class frmLapBBVP : UserControl
    {
        BienbanVP_BUS bb = new BienbanVP_BUS();
        string MaNV="NV000001";
        string maVP = "";
        public frmLapBBVP(string manv)
        {
            InitializeComponent();
            MaNV = manv;
        }
        private void AutoTaoMaVP()
        {
            string index = (bb.Get_slVP() + 1).ToString();
            maVP = "VP000000";
            maVP = maVP.Substring(0, 8 - index.Length) + index;
            txtMaVP.Text = maVP;

        }
        private void frmLapBBVP_Load(object sender, EventArgs e)
        {
            txtMaNv.Text = MaNV;

            cmbMaDg.DataSource = bb.getMadg();
            cmbMaDg.DisplayMember = "madocgia";
            cmbMaDg.ValueMember = "madocgia";

            AutoTaoMaVP();

        }

        private void btnVP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSVP.Rows.Count; i++)
            {
                if (cmbMasach.Text.Trim() == dgvSVP.Rows[i].Cells[0].Value.ToString().Trim())
                {
                    MessageBox.Show("Mã sách đã tồn tại vi phạm");
                    return;
                }
            }
            dgvSVP.Rows.Add(cmbMasach.Text, bb.get_tensach(cmbMasach.Text), cmbLydo.Text, txtTienphat.Text, "Bỏ");
        }
        private void dgvSVP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dgvSVP.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
        private void cmbMaDg_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDg.Text = bb.Get_tendg(cmbMaDg.Text);
            cmbMasach.DataSource = bb.getMasach(cmbMaDg.Text);
            cmbMasach.ValueMember = "Masach";
            cmbMasach.DisplayMember = "Masach";

        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = bb.Get_tennv(txtMaNv.Text);
        }

        private void btnLapBB_Click(object sender, EventArgs e)
        {
            
            string lydo = "";
            BienBanViPham bbvp = new BienBanViPham();
            bbvp.MaDocGia = cmbMaDg.Text;
            bbvp.MaNhanVien = txtMaNv.Text;
            bbvp.MaViPham = txtMaVP.Text;
            bbvp.TongTP = 0;

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn lập biên bản này không?", "Hỏi đáp?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                bb.insertBB(bbvp);

                for (int i = 0; i < dgvSVP.Rows.Count; i++)
                {
                    ViPham vp = new ViPham();
                    vp.MaSach = dgvSVP.Rows[i].Cells[0].Value.ToString();
                    vp.MaViPham = txtMaVP.Text;
                    vp.Lydo = dgvSVP.Rows[i].Cells[2].Value.ToString();
                    vp.TienPhat = int.Parse(dgvSVP.Rows[i].Cells[3].Value.ToString());
                    bb.Them_vp(vp);
                    if (dgvSVP.Rows[i].Cells[2].Value.ToString().Contains("mất"))
                    {
                        //update ngày trả và set trạng thái cuốn sách đó bằng 0
                        bb.update0(vp.MaSach);
                    }
                    else
                    {
                        //update ngày trả và set trạng thái cuốn sách đó bằng 1
                        bb.update1(vp.MaSach);
                    }
                }
            }
        }

        private void cmbMasach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTenSach.Text = bb.get_tensach(cmbMasach.Text.Trim());
            cmbLydo_SelectedIndexChanged_1(sender, e);
        }

        private void cmbLydo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbLydo.Text == "trả sách trễ hạn")
            {
                if (bb.Songaytre(cmbMasach.Text) < 0)
                {
                    MessageBox.Show("Cuốn sách này chưa đến hạn trả. Vui lòng chọn lý do khác!");
                }
                else
                {
                    long tienphat = bb.Songaytre(cmbMasach.Text) * 1000;// phạt trễ hạn 2000/ngày
                    txtTienphat.Text = tienphat.ToString();
                }
            }
            if (cmbLydo.Text == "làm hỏng sách")
            {

                txtTienphat.Text = (bb.TienPhat(cmbMasach.Text) * 0.2).ToString();
            }
            if (cmbLydo.Text == "làm mất sách")
                //{
                txtTienphat.Text = (bb.TienPhat(cmbMasach.Text) * 1.5).ToString();
            if(cmbLydo.Text == "trả sách trễ hạn và làm mất")
            {
                if (bb.Songaytre(cmbMasach.Text) < 0)
                {
                    MessageBox.Show("Cuốn sách này chưa đến hạn trả. Vui lòng chọn lý do khác!");
                }
                else
                {
                    long tienphat = bb.Songaytre(cmbMasach.Text) * 1000;// phạt trễ hạn 2000/ngày
                    double tienmat = bb.TienPhat(cmbMasach.Text) * 1.5;
                    txtTienphat.Text = Math.Max(tienphat,tienmat).ToString();
                }
            }
            else if( cmbLydo.Text=="trả sách trễ hạn và làm hỏng")
            {
                if (bb.Songaytre(cmbMasach.Text) < 0)
                {
                    MessageBox.Show("Cuốn sách này chưa đến hạn trả. Vui lòng chọn lý do khác!");
                }
                else
                {
                    long tienphat = bb.Songaytre(cmbMasach.Text) * 1000;// phạt trễ hạn 2000/ngày
                    double tienhong = bb.TienPhat(cmbMasach.Text) * 0.2;
                    txtTienphat.Text = Math.Max(tienphat, tienhong).ToString();
                }
            }
        }

        private void dgvSVP_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dgvSVP.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void dgvSVP_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            long tienphat = 0;
            for( int i =0; i <dgvSVP.RowCount; i++)
            {
                tienphat +=int.Parse(dgvSVP.Rows[i].Cells[3].Value.ToString());
            }
            txtTongtienphat.Text = tienphat.ToString();
        }
    }

}
