using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibraryManager.BUS
{
    class DocGia_BUS : Image_BUS
    {
        DocGia_DAO dgDao = new DocGia_DAO();
        public DataTable GetList()
        {
            return dgDao.loadDocGia();
        }
        public DataTable GetListDGInfo()
        {
            return dgDao.loadDocGiaInfo();
        }

        public DataTable GetListDGLoc(string loai)
        {
            return dgDao.loadDocGiaLoc(loai);
        }

        public void Xoa(string mDG)
        {
            dgDao.Delete(mDG);
        }
        public bool Sua(DocGia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            dgDao.Update(dg);
            return true;
        }
        public bool Them(DocGia dg)
        {
            return dgDao.Insert(dg);
        }
        public DataTable TimKiem(string _timkiem)
        {
            return dgDao.Search(_timkiem);
        }

        // Xử lý load ảnh lên pictureBox; ->get
        public Image LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("DocGia", maID, "MaDocGia");
            PictureBox avt = new PictureBox();
            if (img != null && img.Length > 0)
            {
                return Image.FromStream(new MemoryStream(img));
            }
            else
            {
                return Properties.Resources.icons8_search_client_80px;
            }

        }

        // -> set
        public void LuuAnh(string maID, string imgPath)
        {
            SaveImage("DocGia", maID, "MaDocGia", imgPath);
        }

        public DocGia GetOne(string maDG)
        {
            return dgDao.GetMotDG(maDG);
        }

        #region getMaDocGia
        public DataTable LoadMaDocGia()
        {
            return dgDao.GetMaDG();
        }
        public string LoadMaDocGia_PhieuMuon(string MaMT)
        {
            return dgDao.GetMaDG_PhieuMuon(MaMT);
        }





        #endregion

        #region hoatdong
        public DataTable LoadLoiViPham(string MaDG)
        {
            return dgDao.LoiViPham(MaDG);
        }

        public DataTable LoadSachDenHan(string MaDG)
        {
            return dgDao.SachDenHan(MaDG);
        }

        public DataTable LoadMuon_SL(string MaDG)
        {
            return dgDao.SachDaMuon_Soluong(MaDG);
        }
        public string TongSachTra(string MaDG)
        {
            return dgDao.TongSachTra1Month(MaDG);
        }

        public int TongSachChuaTra(string MaDG)
        {
            return dgDao.TongSoSachChuaTra(MaDG);
        }

        public DataTable TraGanDay(string MaDG)
        {
            return dgDao.TraGanNhat(MaDG);
        }

        #endregion

        #region xuathongtin


        public bool UpdateOne(DocGia dg)
        {
            return dgDao.Update(dg);
        }
        #endregion


        public string LoadMaDG_TK(string tk)
        {
            return dgDao.GetMaDG_TaiKhoan(tk);
        }




        #region NhanvienXuly

        public bool checkTonTaiDG(string MaDG)
        {
            return dgDao.checkTonTaiDG(MaDG);
        }
        public string LoadTenDG(string MaDG)
        {
            return dgDao.GetTenDocGia(MaDG);
        }

        #endregion


        #region themdocgia
        public string GetLastestMaDG()
        {
            return dgDao.GetLastest_MaDG();
        }

        public string CreateNext_MaDG()
        {
            string current = GetLastestMaDG();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string maMuon = "DG000000";
            maMuon = maMuon.Substring(0, maMuon.Length - index.Length) + index;

            return maMuon;
        }

        #endregion



        #region khoataikhoan

        public void KhoaTaiKhoan(string MaDocGia)
        {
            dgDao.KhoaTaiKhoan(MaDocGia);

        }
        public void MoKhoaTK(string MaDocGia)
        {
            dgDao.KhoaTaiKhoan(MaDocGia);
        }
    }
}
#endregion