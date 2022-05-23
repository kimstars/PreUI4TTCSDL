using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibraryManager.BUS;

namespace LibraryManager
{
    public partial class FrmDocGia : Form
    {
        public FrmDocGia()
        {
            InitializeComponent();
            listSachMuon = new List<string>();

        }
        public FrmDocGia(string username)
        {
            InitializeComponent();
            user = username;
            listSachMuon = new List<string>();
        }


        public FrmDocGia(string username, List<string> lsMuon)
        {
            InitializeComponent();
            user = username;
            listSachMuon = lsMuon;

            

        }

        string Madocgia = "DG000001";
        string user = "";

        bool sidebarExpand = true;

        public static List<string> listSachMuon;

        private void sidebartick_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // thu vao
            {
   
                PanelMenuBar.Width -= 100;
                if (PanelMenuBar.Width == PanelMenuBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartick.Stop();
                }
                pictureAvt.Size = new Size(40, 40);
                pictureAvt.Dock = DockStyle.Fill;
                picIcon.Visible = false;
                btnMenu.Dock = DockStyle.Top;
   
                foreach (var btn in panel4.Controls.OfType<Guna2Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(0);
                }

            }
            else // mo ra
            {
                PanelMenuBar.Width += 100;
                if (PanelMenuBar.Width == PanelMenuBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartick.Stop();

                }
                pictureAvt.Size = new Size(60, 60);
                pictureAvt.Dock = DockStyle.None;

                picIcon.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach(Guna2Button btn in panel4.Controls.OfType<Guna2Button>())
                {
                    btn.Text = btn.Tag.ToString();
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(10,0,0,0);
                }

            }
        }
        void loadAvt()
        {
            pictureAvt.Image = dgBus.LoadAnh(Madocgia);
        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.HomeHello());
            loadAvt();

        }

        DocGia_BUS dgBus = new DocGia_BUS();

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            if(user != "")
            {
                nameuser.Text = user;
                Madocgia = dgBus.LoadMaDG_TK(user);
                pictureAvt.Image = dgBus.LoadAnh(Madocgia);
            }
            if (GUI.TimKiem4Hello.DaTim)
            {
                panelShow.Controls.Clear();
                List<string> dsmuon = GUI.TimKiem4Hello.dsMuon;

                panelShow.Controls.Add(new Template.PhieuMuon(Madocgia,dsmuon));
                GUI.TimKiem4Hello.DaTim = false;
            }

            panelShow.Controls.Clear();

            if (listSachMuon.Count > 0)
            {
                panelShow.Controls.Add(new Template.PhieuMuon(Madocgia, listSachMuon));
            }
            else
            {
                panelShow.Controls.Add(new Template.HomeHello());
            }

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            loadAvt();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.InfoDG(Madocgia));
        }

     

        private void btnTk_Sach_Click(object sender, EventArgs e)
        {
            loadAvt();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.TK_sachmuon_dg(Madocgia));
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            loadAvt();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.FrmTimKiemForDG());
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            loadAvt();
            //nếu list sách mượn chưa có sách nào thì cho độc giả tìm sách xong mới mượn
            panelShow.Controls.Clear();

            if (listSachMuon.Count == 0)
            {
                Template.TimKiem4HelloV2 usertimkiem = new Template.TimKiem4HelloV2();

                usertimkiem.OnClick += (ss, ee) =>
                {
                    panelShow.Controls.Clear();
                    
                    panelShow.Controls.Add(new Template.PhieuMuon(Madocgia, listSachMuon));

                };

                panelShow.Controls.Add(usertimkiem);

            }
            else
            {
                 panelShow.Controls.Add(new Template.PhieuMuon(Madocgia, listSachMuon));
            }
        }
    }
}
