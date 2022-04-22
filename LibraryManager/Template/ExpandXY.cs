using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Template
{
    public class ExpandXY
    {
        private bool sidebarExpand { get; set; }
        private Panel PanelBar { get; set; }
        private Timer SidebarTick { get; set; }


        public ExpandXY(bool sidebarExpand1, Panel PanelBar1, Timer SidebarTick1)
        {
            sidebarExpand = sidebarExpand1;
            PanelBar = PanelBar1;
            SidebarTick = SidebarTick1;
            
        }
     

        public void ExpandX_Tick()
        {
            if (sidebarExpand)
            {
                PanelBar.Width -= 100;
                if (PanelBar.Width == PanelBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTick.Stop();

                }
                else
                {
                    PanelBar.Width += 100;
                    if (PanelBar.Width == PanelBar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        SidebarTick.Stop();
                    }
                }
            }
        }
        public void ExpandY_Tick()
        {

            if (sidebarExpand)
            {
                PanelBar.Height -= 100;
                if (PanelBar.Height == PanelBar.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    SidebarTick.Stop();
                }
            }
            else
            {
                PanelBar.Height += 100;
                if (PanelBar.Height == PanelBar.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    SidebarTick.Stop();
                }
            }
        }
    }  
}
