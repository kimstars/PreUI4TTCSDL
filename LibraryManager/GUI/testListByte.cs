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

namespace LibraryManager.GUI
{
    public partial class testListByte : Form
    {
        public testListByte()
        {
            InitializeComponent();
        }

        Image_BUS imgBus = new Image_BUS();
        List<byte[]> listAnh;
        private void testListByte_Load(object sender, EventArgs e)
        {
            listAnh = imgBus.LoadDSAnh("DAUSACH");
            lbCount.Text = listAnh.Count.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtSTT.Text);

            picImage.Image = imgBus.Load1Anh(listAnh[index]);


        }
    }
}
