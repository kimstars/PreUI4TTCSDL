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
using LibraryManager.GUI;
namespace LibraryManager.Template
{
    public partial class Xu_ly_tra : UserControl
    {
        Trasach_Bus ts_bus = new Trasach_Bus();
        
        public Xu_ly_tra()
        {
            InitializeComponent();
        }
        public string chuanhoa(string a)
        {
            return a.ToUpper();
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (cmbTKiem.SelectedItem == "Mã độc giả")
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        dgv_trasach.DataSource = ts_bus.loadtk_dgia(chuanhoa(txtTK.Text));
                    }

                }
                else if (cmbTKiem.SelectedItem == "Mã sách")
                {
                    dgv_trasach.DataSource = ts_bus.loadtk_masach(chuanhoa(txtTK.Text));
                }
                else if (cmbTKiem.SelectedItem =="Tất cả")
                {
                    dgv_trasach.DataSource = ts_bus.Loadls();
                }
            }
        }

        private void Xu_ly_tra_Load(object sender, EventArgs e)
        {
            dgv_trasach.DataSource = ts_bus.Loadls();
            cmbTKiem.SelectedIndex = 0;
        }

        private void dgv_trasach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_trasach.CurrentRow.Index;
            txtMasach.Text = dgv_trasach.Rows[i].Cells[3].Value.ToString();
            txtMadg.Text = dgv_trasach.Rows[i].Cells[0].Value.ToString();

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if(txtMadg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }else if (txtMasach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách trả");
            }

            if (cboxVi_pham.Checked == true)
            {
                dgvDs.Rows.Add(chuanhoa(txtMasach.Text),chuanhoa( txtMadg.Text), DateTime.Now, "Có", "Bỏ");
            }
            else
            {
                dgvDs.Rows.Add(chuanhoa(txtMasach.Text), chuanhoa(txtMadg.Text), DateTime.Now, "Không", "Bỏ");
            }

        }
       /* public bool check(string sach)
        {
            
            for( int i =0; i <dgv_trasach.Rows.Count; i++)
            {
                if (DateTime.Parse(dgv_trasach.Rows[i].Cells[5].Value.ToString()) < DateTime.Today.Date && Equals(dgv_trasach.Rows[i].Cells[7].Value.ToString(), sach))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }*/
        private void btnBbvp_Click(object sender, EventArgs e)
        {
            List<string> book= new List<string>();
            string madg;
            string ngaytra1;
            int count = 0;

            //  bool tre = false;
            for (int i = 0; i < dgvDs.Rows.Count; i++)
            {
                if (Equals(dgvDs.Rows[i].Cells[3].Value, "Có"))
                {
                    book.Add(dgvDs.Rows[i].Cells[0].Value.ToString());
                    count++;
                }

                if (count != 0)
                {
                    madg = dgvDs.Rows[0].Cells[1].Value.ToString();
                    ngaytra1 = dgvDs.Rows[0].Cells[2].Value.ToString();
                    FrmBienbanVP bbvp = new FrmBienbanVP(madg, ngaytra1, book/*,tre*/);
                    bbvp.Show();
                }
            }
        }
       
    

        private void dgvDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int i;
            i = dgvDs.CurrentRow.Index;
            txtMasach.Text = dgvDs.Rows[i].Cells[0].Value.ToString();
            txtMadg.Text = dgvDs.Rows[i].Cells[1].Value.ToString();
            if (dgvDs.Rows[i].Cells[0].Value.ToString() == "Có")
            {
                cboxVi_pham.Checked =true;
            }*/
            if(e.ColumnIndex== 4)
            {
                
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dgvDs.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            for( int  i = 0; i <dgvDs.Rows.Count-1; i++)
            {
                ts_bus.update(dgvDs.Rows[i].Cells[0].Value.ToString());
            }
            MessageBox.Show("Trả sách thành công!!");
        }

        private void txtTK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTK.Text) == true)
            {
                //e.Cancel = true;
                txtTK.Focus();
                error1.SetError(txtTK, "Vui lòng nhập nội dung cần tìm kiếm!!");
            }else
            {
                //e.Cancel = true;
                error1.SetError(txtTK, null);
            }
        }
    }
}