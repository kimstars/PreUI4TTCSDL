using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManager.Template
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void closeYCollapse()
        {
            if(QLSachTickCollapse) QLSachTick.Start();
            if (QLNVTickCollapse) QLNVtick.Start();
            if(QLDGTickCollapse) QLDGtick.Start();


        }

        bool sidebarExpand;
        private void sidebartick_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // thu vao
            {
                closeYCollapse();
                PanelMenuBar.Width -= 100;
                if (PanelMenuBar.Width == PanelMenuBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartick.Stop();
                }
                pictureAvt.Size = new Size(40,40);


            }
            else // mo ra
            {
                PanelMenuBar.Width += 100;
                if (PanelMenuBar.Width == PanelMenuBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartick.Stop();
                }
                pictureAvt.Size = new Size(60,60);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {
            PanelMenuBar.Width = PanelMenuBar.MaximumSize.Width;


            hideChildFrm();

        }
        #region open_QLsach

        bool QLSachTickCollapse;

        private void QLSachTick_Tick(object sender, EventArgs e)
        {
            if (QLSachTickCollapse)
            {
                PanelQLSach.Height -= 100;
                if (PanelQLSach.Height == PanelQLSach.MinimumSize.Height)
                {
                    QLSachTickCollapse = false;
                    QLSachTick.Stop();
                }
            }
            else
            {
                PanelQLSach.Height += 100;
                if (PanelQLSach.Height == PanelQLSach.MaximumSize.Height)
                {
                    QLSachTickCollapse = true;
                    QLSachTick.Stop();
                }
            }
        }
        private void btnQLSach_Click(object sender, EventArgs e)
        {
            QLSachTick.Start();
        }
        #endregion

        #region QLNV

        bool QLNVTickCollapse;

        private void QLNVtick_Tick(object sender, EventArgs e)
        {
            if (QLNVTickCollapse)
            {
                panelQLNV.Height -= 100;
                if (panelQLNV.Height == panelQLNV.MinimumSize.Height)
                {
                    QLNVTickCollapse = false;
                    QLNVtick.Stop();
                }
            }
            else
            {
                panelQLNV.Height += 100;
                if (panelQLNV.Height == panelQLNV.MaximumSize.Height)
                {
                    QLNVTickCollapse = true;
                    QLNVtick.Stop();
                }
            }
        }
        private void btnOpenQLNV_Click(object sender, EventArgs e)
        {
            QLNVtick.Start();
        }



        #endregion

        #region QLDG
        bool QLDGTickCollapse;

        private void QLDGtick_Tick(object sender, EventArgs e)
        {
            if (QLDGTickCollapse)
            {
                panelQLDocGia.Height -= 100;
                if (panelQLDocGia.Height == panelQLDocGia.MinimumSize.Height)
                {
                    QLDGTickCollapse = false;
                    QLDGtick.Stop();
                }
            }
            else
            {
                panelQLDocGia.Height += 100;
                if (panelQLDocGia.Height == panelQLDocGia.MaximumSize.Height)
                {
                    QLDGTickCollapse = true;
                    QLDGtick.Stop();
                }
            }
        }
        private void btnOpenQLDG_Click(object sender, EventArgs e)
        {
            QLDGtick.Start();
        }


        #endregion



        void hideChildFrm()
        {
            danhsachNV1.Visible = false;
            
            //infoDG.Visible = false;
            danhSachDG1.Visible = false;
        }


        private void btnDSNV_Click(object sender, EventArgs e)
        {
            hideChildFrm();
            danhsachNV1.Visible = true;
        }

        private void btnDSDocGia_ClientSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThuNghiem_Click(object sender, EventArgs e)
        {
            hideChildFrm();
            //infoDG.Visible = true;
            phieuMuon.Visible = true;
        }

        private void btnDSDocGia_Click(object sender, EventArgs e)
        {
            hideChildFrm();
            danhSachDG1.Visible = true;
        }

        private void btnPhieumuon_Click(object sender, EventArgs e)
        {
            hideChildFrm();
            phieuMuon.Visible = true;
        }
    }
}
