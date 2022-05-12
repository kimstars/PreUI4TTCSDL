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

namespace LibraryManager.Template
{
    public partial class OneBook : UserControl
    {
        public OneBook()
        {
            InitializeComponent();
        }

        public OneBook(string Ma)
        {
            InitializeComponent();

            maDauSach = Ma;
        }

        public event EventHandler OnSelect = null;

        private void imgBook_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }


        private Image imageBook;
        private string maDauSach = "DS000003";
        public Image ImageBook { get => imageBook; set => imageBook = value; }
        public string MaDauSach { get => maDauSach; set => maDauSach = value; }

        public string TenSach;
        public string TenTacGia;

        public bool selected = false;
        private void HighLightItem()
        {
            int sl = int.Parse(lbSoLuong.Text);
            if(sl > 0)
            {
                if (selected)
                {
                    panelMain.BorderColor = System.Drawing.Color.FromArgb(0,192,0);
                    tickPic.Visible = true;

                }
                else
                {
                    panelMain.BorderColor = System.Drawing.Color.FromArgb(255,255,255);

                    tickPic.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Đã hết sách " + TenSach + " rồi nhé!!");
            }
        }
        DauSach_BUS dsBus = new DauSach_BUS();

        

        private void OneBook_Load(object sender, EventArgs e)
        {

            if(MaDauSach != "")
            {

                DataTable thongtin = dsBus.LoadThongTinSach(MaDauSach);

                imgBook.BackgroundImage = dsBus.LoadAnh(MaDauSach);

                TenSach = dsBus.LoadTenDS(maDauSach);
                lbInfoTenSach.Text = TenSach;

                TenTacGia = dsBus.LoadTenTG(maDauSach);
                lbInfoTenTG.Text = TenTacGia;

                lbSoLuong.Text = dsBus.LoadSL_SanCo(MaDauSach);
            }



        }

      
    }
}
