using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.extentItem;
using LibraryManager.BUS;

namespace LibraryManager.CreateDB
{
    public partial class create1000Book : Form
    {
        public create1000Book()
        {
            InitializeComponent();
        }
        CuonSach_BUS csBus = new CuonSach_BUS();


        #region random
        private static Random random = new Random();
        public string RanDomViTri()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string num = "0123456789";

            int i = random.Next();
            string res = chars[i % 26].ToString() + num[i % 10].ToString();

            return res;

        }
        public double GetRandomNumberInRange(double minNumber, double maxNumber)
        {
            return new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
        }

        public string randomTinhTrang()
        {
            return ((int)(GetRandomNumberInRange(5, 10)*10)).ToString();
        }

        private void RandomCombobox(ref ComboBox comboBox)
        {
            Random random = new Random();
            int newSelectedIndex = comboBox.SelectedIndex;
            while (newSelectedIndex == comboBox.SelectedIndex)
            {
                newSelectedIndex = random.Next(0, comboBox.Items.Count);
            }
            comboBox.SelectedIndex = newSelectedIndex;
        }
        #endregion
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 1000; i++)
            {
                genOne();
                pushOne();
                lbSoluong.Text = i.ToString();

            }

            dgvCuonsach.DataSource = csBus.LoadSach();


        }

        void genOne()
        {
            txtMaSach.Text = csBus.CreateNext_MaSach();
            RandomCombobox(ref cbDauSach);
            txtViTri.Text = RanDomViTri();
            txtTrangthai.Text = randomTinhTrang();

        }

        void pushOne()
        {
            csBus.InsertOneCuonSach(txtMaSach.Text, cbDauSach.Text, txtViTri.Text, txtTrangthai.Text);

        }
        DauSach_BUS ds = new DauSach_BUS();

        private void create1000Book_Load(object sender, EventArgs e)
        {
            cbDauSach.DataSource = ds.LoadMaDauSach();
            genOne();

        }
    }
}
