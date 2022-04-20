using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;


namespace LibraryManager.Template
{
    public partial class QLInfoDocgia : UserControl
    {
        string strCon = @"Data Source=CHU-TUAN-KIET\SQLEXPRESS;Initial Catalog=learnQLSV;Integrated Security=True";
        SqlConnection sqlCon = null;
        public QLInfoDocgia()
        {
            InitializeComponent();
        }

        public string ID2
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }

        }



        public string GenerateMa(string type)
        {
            string temp = type + "000000";
            return temp;
        }
        private bool validateAll(ref string MaDocGia, string HoTen, string gender, string DiaChi, string sdt, string soCMND, string username)
        {
            if (string.IsNullOrEmpty(HoTen))
            {
                MessageBox.Show(
                "Vui lòng nhập họ và tên",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (int.Parse(DateTime.UtcNow.ToString("yyyy")) - birthdayPicker.Value.Year < 15)
            {
                MessageBox.Show(
                "Vui lòng chọn ngày sinh chính xác!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(DiaChi))
            {
                MessageBox.Show(
                "Vui lòng nhập địa chỉ của bạn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(sdt) || sdt.Length > 10)
            {
                MessageBox.Show(
                "Vui lòng nhập chính xác số điện thoại của bạn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(soCMND))
            {
                MessageBox.Show(
                "Vui lòng nhập số cmnd của bạn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show(
                "Vui lòng nhập tên đăng nhập !",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else
            {
                return true;
            }
        }

        

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            string MaDocGia = GenerateMa("DG");
            string HoTen = txtHoten.Text;
            string NgaySinh = birthdayPicker.Text;
            string gender = selectGender.Text;
            string DiaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string soCMND = txtCMND.Text;
            string ngayDK = ngayDKPicker.Text;
            string username = txtUsername.Text;
 
            if (validateAll(ref MaDocGia, HoTen, gender, DiaChi, sdt, soCMND, username))
            {
                ListViewItem lvi = new ListViewItem(MaDocGia);
                lvi.SubItems.Add(HoTen);
                lvi.SubItems.Add(NgaySinh);
                lvi.SubItems.Add(gender);
                lvi.SubItems.Add(DiaChi);
                lvi.SubItems.Add(sdt);
                lvi.SubItems.Add(soCMND);
                lvi.SubItems.Add(ngayDK);
                lvi.SubItems.Add(username);
          

                listViewInfo.Items.Add(lvi);
                txtMaDG.Text = "";
                txtHoten.Text = "";
                birthdayPicker.Text = "";
                selectGender.Text = "";
                txtDiachi.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                ngayDKPicker.Text = "";
                txtUsername.Text = "";
                

                //string query = "INSERT INTO DOCGIA (ID,  Sname, age, Address, classname) VALUES (@ID,  @Sname, @age, @Address, @classname)";
                //SqlCommand sqlCmd = new SqlCommand();
                //sqlCmd.Connection = sqlCon;
                //sqlCmd.CommandType = CommandType.Text;
                //sqlCmd.CommandText = query;
                //sqlCmd.Parameters.AddWithValue("@ID", id);
                //sqlCmd.Parameters.AddWithValue("@Sname", name);
                //sqlCmd.Parameters.AddWithValue("@age", age);
                //sqlCmd.Parameters.AddWithValue("@Address", address);
                //sqlCmd.Parameters.AddWithValue("@classname", classname);
                //try
                //{
                //    int recordsAffected = sqlCmd.ExecuteNonQuery();
                //    MessageBox.Show("Insert 1 row done!!");
                //}
                //catch (SqlException)
                //{
                //    MessageBox.Show("error sql", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    // error here
                //}
                //finally
                //{
                //    sqlCon.Close();
                //}

                MessageBox.Show(
                "Nhập thông tin thành công !!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            }

            btnDeleteInfo.Visible = false;
            btnEditInfo.Visible = false;

        }

        private ListViewItem item;

        private void listViewInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInfo.SelectedItems.Count > 0)
            {
                item = listViewInfo.SelectedItems[0];

                txtMaDG.Text = item.SubItems[0].Text;
                txtHoten.Text = item.SubItems[1].Text;
                birthdayPicker.Text = item.SubItems[2].Text;
                selectGender.Text = item.SubItems[3].Text;
                txtDiachi.Text = item.SubItems[4].Text;
                txtSDT.Text = item.SubItems[5].Text;
                txtCMND.Text = item.SubItems[6].Text;
                dateReg.Text = item.SubItems[7].Text;
                txtUsername.Text = item.SubItems[8].Text;
                
            }
            btnEditInfo.Visible = true;
            btnDeleteInfo.Visible = true;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            string MaDocGia = txtMaDG.Text;
            string HoTen = txtHoten.Text;
            string NgaySinh = birthdayPicker.Text;
            string gender = selectGender.Text;
            string DiaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string soCMND = txtCMND.Text;
            string ngayDK = ngayDKPicker.Text;
            string username = txtUsername.Text;

            if (validateAll(ref MaDocGia, HoTen, gender, DiaChi, sdt, soCMND, username))
            {
                item.SubItems[0].Text = MaDocGia;
                item.SubItems[1].Text = HoTen;
                item.SubItems[2].Text = NgaySinh;
                item.SubItems[3].Text = gender;
                item.SubItems[4].Text = DiaChi;
                item.SubItems[5].Text = sdt;
                item.SubItems[6].Text = soCMND;
                item.SubItems[7].Text = ngayDK;
                item.SubItems[8].Text = username;
                


                txtMaDG.Text = "";
                txtHoten.Text = "";
                birthdayPicker.Text = "";
                selectGender.Text = "";
                txtDiachi.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                ngayDKPicker.Text = "";
                txtUsername.Text = "";

                MessageBox.Show(
                "Nhập thông tin thành công !!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông báo", "Bạn có chắc chắn xóa dòng dữ liệu này không ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                item.Remove();
        }


    }
}
