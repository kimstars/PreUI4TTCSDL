using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibraryManager.DAO;
using LibraryManager.BUS;

namespace LibraryManager.CreateDB
{
    public partial class addImageDauSach : Form
    {
        public addImageDauSach()
        {
            InitializeComponent();
        }
        void loaddatatable()
        {
            dgvInfo.DataSource = loadDao.LoadDataTable(cbTableName.Text);

        }
        private void addImageDauSach_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathFolder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

        }

        LoadAll_DAO loadDao = new LoadAll_DAO();
        Image_BUS img = new Image_BUS();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPathFolder.Text == "")
            {
                MessageBox.Show("Chọn thư mục chứa ảnh đi !!!");
                return;
            }
            if (cbTableName.Text == "")
            {
                MessageBox.Show("Chọn tên bảng đi !! ");
                return;
            }
            string[] files = Directory.GetFiles(txtPathFolder.Text);
            string tablename = cbTableName.Text;
            string maid = "";
            string typeid = "";

            switch (tablename)
            {
                case "DAUSACH":
                    {
                        maid = "DS000000";
                        typeid = "MaDauSach";
                        break;
                    }
                case "NHANVIEN":
                    {
                        maid = "NV000000";
                        typeid = "MaNhanVien";
                        break;
                    }
                case "DOCGIA":
                    {
                        maid = "DG000000";
                        typeid = "MaDocGia";

                        break;
                    }
            }
            MessageBox.Show(files[0]);
            int i = 0;
            foreach (string file in files)
            {
                img.SaveImage(tablename, AutoTaoMa(maid, i), typeid, file);
                i++;
            }

            loaddatatable();

        }

        private string AutoTaoMa(string maMuon, int i)
        {
            string index = i.ToString();
            return maMuon.Substring(0, maMuon.Length - index.Length) + index;
        }
    }
}
