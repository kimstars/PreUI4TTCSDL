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
    public partial class DSSachCoSan : UserControl
    {
        public DSSachCoSan()
        {
            InitializeComponent();
        }
        string MaDSCurrent = "";

        public void AddItem(string MaDauSach)
        {

            if (MaDauSach != "")
            {
                Template.OneBook newbook = new Template.OneBook(MaDauSach);
                flowLayoutDS.Controls.Add(newbook);

                newbook.OnSelect += (ss, ee) =>
                {
                    var item = (Template.OneBook)ss;
                    MaDSCurrent = item.MaDauSach;

                };
            }
        }

        private List<string> DSDauSach = new List<string>();
        DauSach_BUS dsBus = new DauSach_BUS();

        public void LoadComboBoxTheLoai()
        {
            List<string> dsTheLoai = dsBus.LoadAllTheLoai();
            for (int i = 0; i < dsTheLoai.Count; i++)
            {
                cbTheLoai.Items.Insert(i, dsTheLoai[i]);
            }

        }

        private void LoadBookFlow()
        {
            flowLayoutDS.Controls.Clear();
            lbSLBook.Text = $"Danh sách này có {DSDauSach.Count.ToString()} đầu sách.";
            if (DSDauSach.Count > 0)
            {
                foreach (var item in DSDauSach)
                {
                    AddItem(item);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchByName();
            LoadBookFlow();
        }


        bool isSearchTG = false;
        private void btnFindByTG_Click(object sender, EventArgs e)
        {
            if (btnFindByTG.Text == btnFindByTG.Tag.ToString())
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

        private void ShowAll()
        {
            DSDauSach = dsBus.LoadMaDauSach();
        }

        private void SearchByName()
        {
            string tl = cbTheLoai.Text.Trim();
            string keysearch = txtSearch.Text.Trim();

            if (keysearch != "")
            {
                if (!isSearchTG)
                {
                    if (tl != "Tất cả thể loại")
                    {
                        DSDauSach = dsBus.LoadMaDS_TS_TL(tl, keysearch);

                    }
                    else
                    {
                        DSDauSach = dsBus.LoadMaDS_onlyTenSach(keysearch);
                    }

                }
                else
                {
                    if (tl != "Tất cả thể loại")
                    {
                        DSDauSach = dsBus.LoadMaDS_TG_TL(tl, keysearch);
                    }
                    else
                    {
                        DSDauSach = dsBus.LoadMaDS_OnlyTG(keysearch);
                    }
                }
            }
            else
            {
                DSDauSach = dsBus.LoadMaDS_onlyTheloai(tl);

                if (tl == "Tất cả thể loại")
                {
                    DSDauSach = dsBus.LoadMaDauSach();
                }

            }
        }



        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cbTheLoai.Text;


        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            LoadBookFlow();

        }

        private void DSSachCoSan_Load(object sender, EventArgs e)
        {
            DSDauSach = dsBus.LoadMaDauSach_SanCo();
            LoadBookFlow();
            LoadComboBoxTheLoai();
        }
    }
}
