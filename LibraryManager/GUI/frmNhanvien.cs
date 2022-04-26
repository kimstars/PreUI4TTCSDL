using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        private Button currentButton;

        private Random random;

        private int tempIndex;

        private Form activeForm;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(51, 51, 76);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                   
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenuBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
        bool QuanLyExpand;

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            if (QuanLyExpand)
            {
                QuanLyTickTime.Start();

            }
        }

        private void QuanLyTickTime_Tick(object sender, EventArgs e)
        {
            opencloseBarDoc(PanelQLsach, QuanLyExpand, QuanLyTickTime);
        }
        bool sidebarExpand;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarTickTime.Start();

            }
        }

        private void opencloseBarDoc(Panel thisPanel,bool thisExpand,Timer thisTick)
        {
            if (thisExpand)
            {
                thisPanel.Height -= 100;
                if (thisPanel.Height == thisPanel.MinimumSize.Height)
                {
                    thisExpand = false;
                    thisTick.Stop();
                }
            }
            else
            {
                thisPanel.Height += 100;
                if (thisPanel.Height == thisPanel.MaximumSize.Height)
                {
                    thisExpand = true;
                    thisTick.Stop();
                }
            }
        }
        private void opencloseBarNgang(Panel thisPanel, bool thisExpand, Timer thisTick)
        {
            if (thisExpand)
            {
                thisPanel.Height -= 100;
                if (thisPanel.Height == thisPanel.MinimumSize.Height)
                {
                    thisExpand = false;
                    thisTick.Stop();
                }
            }
            else
            {
                thisPanel.Height += 100;
                if (thisPanel.Height == thisPanel.MaximumSize.Height)
                {
                    thisExpand = true;
                    thisTick.Stop();
                }
            }
        }

        private void sidebarTickTime_Tick(object sender, EventArgs e)
        {
            opencloseBarNgang(PanelMenuBar, sidebarExpand, sidebarTickTime);
        }

        bool infoExpand;
        private void avtPicture_Click(object sender, EventArgs e)
        {
            if (infoExpand)
            {
                infoUserTick.Start();

            }
        }

        private void infoUserTick_Tick(object sender, EventArgs e)
        {
            opencloseBarDoc(panelInfoUser, infoExpand, infoUserTick);
        }
    }
}
