using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibraryManager.BUS
{
    class NhanVien_BUS : Image_BUS
    {
        NhanVien_DAO nvDao = new NhanVien_DAO();

        public DataTable GetList()
        {
            return nvDao.loadNhanVien();
        }

        public void Xoa(string mNV)
        {
            nvDao.Delete(mNV);
        }
        public bool Sua(NhanVien nv)
        {
            if (string.IsNullOrEmpty(nv.MaNhanVien))
                return false;
            nvDao.Update(nv);
            return true;
        }
        public int Them(NhanVien nv)
        {
            if (string.IsNullOrEmpty(nv.MaNhanVien))
                return 0;
            if (!nvDao.Insert(nv))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {

            return nvDao.Search(_timkiem);
        }

        // Xử lý load ảnh lên pictureBox;
        public PictureBox LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("NhanVien", maID, "MaNhanVien");
            PictureBox avt = new PictureBox();
            avt.Image = Image.FromStream(new MemoryStream(img));
            return avt; 
        }

        #region LoadMaNhanVien
        public DataTable LoadMaNhanVien() {
            return nvDao.GetMaNV();
        }

        public string LoadMaNhanVien_PhieuMuon(string MaMT)
        {
            return nvDao.GetMaNV_PM(MaMT);
        }

        #endregion
    }

}
