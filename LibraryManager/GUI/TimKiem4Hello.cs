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

        string MaDSCurrent = "";

        public EventHandler clickPM;
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

                    foreach (DataGridViewRow row in dgvChooseBook.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == item.MaDauSach)
                        {
                            return;
                        }
                    }

                    if (item.SoLuong > 0)
                        dgvChooseBook.Rows.Add(new object[] { item.MaDauSach, item.TenSach, "Bỏ" });


                };
            }
        }

        private List<string> DSDauSach = new List<string>();


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

        DauSach_BUS dsBus = new DauSach_BUS();
        private void TimKiem4Hello_Load(object sender, EventArgs e)
        {


            DSDauSach = dsBus.LoadMaDauSach();
            LoadBookFlow();
            LoadComboBoxTheLoai();

        }

        public void LoadComboBoxTheLoai()
        {
            List<string> dsTheLoai = dsBus.LoadAllTheLoai();
            for (int i = 0; i < dsTheLoai.Count; i++)
            {
                cbTheLoai.Items.Insert(i, dsTheLoai[i]);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchByName();
            LoadBookFlow();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả?", "Xóa tất cả sách đã chọn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dgvChooseBook.Rows.Clear();
                foreach (var item in flowLayoutDS.Controls)
                {

                    Template.OneBook it = (Template.OneBook)item;
                    if (it.selected)
                    {
                        it.HighLightItem();
                        
                    }

                }

            }
        }

        private void dgvChooseBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string MaXoa = dgvChooseBook.Rows[e.RowIndex].Cells["MaDauSach"].Value.ToString();
                    dgvChooseBook.Rows.RemoveAt(e.RowIndex);
                    foreach(var item in flowLayoutDS.Controls)
                    {

                        Template.OneBook it = (Template.OneBook)item;
                        if(it.MaDauSach == MaXoa && it.selected)
                        {
                            it.HighLightItem();
                            break;
                        }

                    }
                }

            }
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


        private void btnPreview_Click(object sender, EventArgs e)
        {
            GUI.ThongTinSach newform = new GUI.ThongTinSach(MaDSCurrent);
            newform.Show();
        }

        public static List<string> dsMuon = new List<string>();
        public static bool DaTim = false;
        private void btnCreatePM_Click(object sender, EventArgs e)
        {

            dsMuon.Clear();
            for(int i = 0; i< dgvChooseBook.Rows.Count; i++)
            {
                dsMuon.Add(dgvChooseBook.Rows[i].Cells["MaDauSach"].Value.ToString());
    
            }
            DaTim = true;


            openAfterLog();
        }

        public static void openAfterLog()
        {
            if (!Form1.isLogin)
            {
                frmLogin newlogin = new frmLogin();
                newlogin.Show();
            }
            else
            {
                FrmDocGia newdg = new FrmDocGia(GUI.frmLogin.userstr);
                newdg.Show();
            }
        }
    }
}
