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

        int n = 0;
        void loaddatatable()
        {
            dgvInfo.DataSource = loadDao.LoadDataTable(cbTableName.Text);
            n = dgvInfo.RowCount;
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
            

            string[] filenames = Directory.GetFiles(txtPathFolder.Text).OrderBy(f => int.Parse(Path.GetFileNameWithoutExtension(f))).ToArray();




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


            loaddatatable();

            for (int i = 0; i < n; i++ )
            {
                img.SaveImage(tablename, AutoTaoMa(maid, i), typeid, filenames[i]);

            }

            loaddatatable();

        }

        private string AutoTaoMa(string MaID, int i)
        {
            string index = i.ToString();
            return MaID.Substring(0, MaID.Length - index.Length) + index;
        }
    }
}
