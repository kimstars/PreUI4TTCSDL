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
    public partial class Captaikhoan : Form
    {
        public Captaikhoan()
        {
            InitializeComponent();
        }

   

        private bool CheckPassword(string passwd)
        {

            if (passwd.Length < 6)
            {
                lbMsg.Text = "Mật khẩu tối thiếu là 6 kí tự.";
                return false;
            }
            if (passwd.Contains(" "))
            {
                lbMsg.Text = "Mật khẩu không chứa khoảng trắng.";
                return false;
            }


            return true;
        }


        private string HashPass(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
        private string sqlStr = @"Data Source=CHU-TUAN-KIET\SQLEXPRESS;Initial Catalog=learnQLSV;Integrated Security=True";
        private SqlConnection sqlCon = null;
        private void connectDB(string sqlstr)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            bool check1, check2;

            check1 = check2 = true;
            if (user.Trim() == string.Empty)
            {

                errorProvider1.SetError(lbMsg, "ko được để trống!!");
                lbMsg.Text = "Bạn phải nhập Tên đăng nhập!!";
                check1 = false;
            }
            else
            {
                lbMsg.Text = "";
                check1 = true;
            }

            if (pass.Trim() == string.Empty)
            {
                errorProvider1.SetError(lbMsg, "ko được để trống!!");
                lbMsg.Text = "Bạn phải nhập mật khẩu!!";
                check2 = false;
            }
            else if (!CheckPassword(pass))
            {
                errorProvider1.SetError(lbMsg, "ko được để trống!!");
                check2 = false;
            }
            else
            {
                lbMsg.Text = "";
                check2 = true;
            }

            if (check1 && check2)
            {

                //if (sqlCon == null)
                //{
                //    sqlCon = new SqlConnection(sqlStr);
                //}
                //if (sqlCon.State == ConnectionState.Closed)
                //{
                //    sqlCon.Open();
                //}


                //string query = "INSERT INTO Taikhoan (tendangnhap, matkhau, loaitaikhoa) VALUES ( @user, @pass, @type)";
                //SqlCommand sqlCmd = new SqlCommand();
                //sqlCmd.Connection = sqlCon;
                //sqlCmd.CommandType = CommandType.Text;
                //sqlCmd.CommandText = query;

                //sqlCmd.Parameters.AddWithValue("@user", user);
                //sqlCmd.Parameters.AddWithValue("@pass", pass);
                //sqlCmd.Parameters.AddWithValue("@type", "docgia");

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

               Form1.
                

            }



        }
    }
}
