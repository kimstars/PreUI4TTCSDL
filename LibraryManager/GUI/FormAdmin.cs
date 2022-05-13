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
            

        }

        bool sidebarExpand;
        bool QLSachTickCollapse;
        bool QLNVTickCollapse;
        bool QLDGTickCollapse;


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
        



        private void Open_Y(ref Panel thisPanel,ref bool thisCollapse)
        {
            if (thisCollapse)
            {
                thisPanel.Height = thisPanel.MinimumSize.Height;

                QLSachTickCollapse = false;
                   
            }
            else
            {
                thisPanel.Height = thisPanel.MaximumSize.Height;

                thisCollapse = true;
            }
        }






        void hideChildFrm()
        {
           

        }


        private void btnDSNV_Click(object sender, EventArgs e)
        {
            hideChildFrm();
            
        }

     

        private void btnThuNghiem_Click(object sender, EventArgs e)
        {
            hideChildFrm();
            //infoDG.Visible = true;
            

        }

       

      
    }
}
