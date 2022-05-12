using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    class ManagerBar
    {

        public static void opencloseBarDoc(Panel thisPanel, bool thisExpand, Timer thisTick)
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
        public static void opencloseBarNgang(Panel thisPanel, bool thisExpand, Timer thisTick)
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
    }
}
