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

namespace LibraryManager.GUI
{
    public partial class TimKiem4Hello : Form
    {
        public TimKiem4Hello()
        {
            
            InitializeComponent();
        }


        public void AddItem(string MaDauSach)
        {
            
            if(MaDauSach != "")
            {
                    flowLayoutDS.Controls.Add(new Template.OneBook(MaDauSach));
            }

    
        }
        private List<string> DSDauSach = null;
        private List<string> DSRoot = null;

        private void LoadBookFlow()
        {
            flowLayoutDS.Controls.Clear();
            string keyword = txtSearch.Text;

            if (keyword.Trim().Length == 0)
            {
                if(DSRoot == null)   DSRoot = dsBus.LoadMaDauSach();
                DSDauSach = DSRoot;
            }
            else
            { 
                DSDauSach = dsBus.LoadMaDauSach(keyword, "");
            }

            if (DSDauSach.Count > 0)
            {
                foreach(var item in DSDauSach)
                {
                    AddItem(item);
                }
            }
        }
        
        DauSach_BUS dsBus = new DauSach_BUS();
        private void TimKiem4Hello_Load(object sender, EventArgs e)
        {
            
            //LoadBookFlow();
            LoadComboBoxTheLoai();

        }

        public void LoadComboBoxTheLoai()
        {
            cbTheLoai.Items.Insert(0, "admin");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isSearchTG)
            {

                LoadBookFlow();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvChooseBook.Rows.Clear();
        }

        private void dgvChooseBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvChooseBook.Rows.RemoveAt(e.RowIndex);
                }
                   
            }
        }
        bool isSearchTG = false;
        private void btnFindByTG_Click(object sender, EventArgs e)
        {
            if(btnFindByTG.Text == btnFindByTG.Tag.ToString())
            {
                btnFindByTG.Text = "Tìm theo tên sách";
                txtSearch.PlaceholderText = "Nhập tên tác giả để tôi tìm sách cho bạn ";
                isSearchTG = true;
            }
            else
            {
                btnFindByTG.Text = btnFindByTG.Tag.ToString();
                txtSearch.PlaceholderText = "Nhập tên sách để tôi tìm cho bạn ";
                isSearchTG = false;

            }

            
        }


        private void LoadOne_Search()
        {
            foreach(var item in flowLayoutDS.Controls)
            {
                var book = (Template.OneBook)item;
                //book.Visible = book.
            }
            
        }
        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cbTheLoai.SelectedValue.ToString();
            
            MessageBox.Show(key);
        }
    }
}
