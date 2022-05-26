using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManager.BUS
{
    class DauSach_BUS : Image_BUS
    {
        DauSach_DAO dsDao = new DauSach_DAO();

        public List<string> LoadMaDauSach()
        {
            DataTable temp =  dsDao.GetMaDauSach();
            List<string> res = new List<string>();
            for(int i = 0; i < temp.Rows.Count; i++)
            {
                string item = temp.Rows[i]["MaDauSach"].ToString();
                res.Add(item);
            }
            return res;
        }

        public List<string> LoadMaDauSach_SanCo()
        {
            DataTable temp = dsDao.GetMaDauSach_SanCo();
            List<string> res = new List<string>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                string item = temp.Rows[i]["MaDauSach"].ToString();
                res.Add(item);
            }
            return res;
        }
        public List<string> LoadMaDauSach(string keyword, string TL)
        {
            DataTable temp = dsDao.GetMaDauSach(keyword,TL);

            List<string> res = new List<string>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                string item = temp.Rows[0]["MaDauSach"].ToString();
                res.Add(item);
            }
            return res;
        }


        public bool CheckMaDauSach(string ma)
        {
            if (dsDao.GetCheckMaDauSach(ma) != 0) return true;
            else return false;
        }

        public void ThemThongtinNhap(DauSach ds,SangTac st, XuatBan xb)
        {
            dsDao.InsertDauSach(ds,st,xb);
        }

        public void Update(DauSach ds, SangTac st, XuatBan xb)
        {
            dsDao.UpdateDauSach(ds, st, xb);
        }

        public void Delete(DauSach ds, SangTac st, XuatBan xb)
        {
            dsDao.DeleteDauSach(ds, st, xb);
        }

        public DataTable SearchDS(string TuKhoa, string MucTimKiem)
        {
            return dsDao.Search(TuKhoa,MucTimKiem);
        }
        

        public DataTable LoadListDS()
        {
            return dsDao.LoadDauSach();
        }
        public DataTable LoadListDSMini()
        {
            return dsDao.LoadDauSachMini();
        }

        public DataTable LoadThongTinSach(string MaDauSach)
        {
            return dsDao.GetInfo(MaDauSach);
        }

        // Xử lý load ảnh lên pictureBox; ->get
        public Image LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("DauSach", maID, "MaDauSach");
            PictureBox avt = new PictureBox();
            if (img.Length > 10)
            {
                return Image.FromStream(new MemoryStream(img));
            }
            else
            {
                return Properties.Resources.icons8_circled_user_male_skin_type_6_80px;
            }
        }

        // -> set
        public void LuuAnh(string maID, string imgPath)
        {
            SaveImage("DauSach", maID, "MaDauSach", imgPath);
        }


        #region thongtinsach

        public DataTable LoadThongtinSach_DS(string MaDS)
        {
            return dsDao.GetInfo2(MaDS);
        }


        public string LoadSL_SanCo(string MaDS)
        {
            return dsDao.GetSLCuonSach_Sanco(MaDS).ToString();
        }

        public string LoadTenDS(string MaDS)
        {
            return dsDao.GetTenDauSach(MaDS);
        }

        public string LoadTenTG(string MaDS)
        {
            return dsDao.GetTenTacGia(MaDS);
        }
        public string LoadTenTheLoai(string Ma)
        {
            return dsDao.GetTheLoai(Ma);
        }


        public string LoadViTriAvailable(string Ma)
        {
            return dsDao.ViTriAvailable(Ma);
        }

        #endregion


        #region TimKiem

        public List<string> LoadAllTheLoai()
        {
            DataTable temp = dsDao.LoadTheLoai();

            List<string> dsTheloai = new List<string>();

            for(int i = 0; i < temp.Rows.Count; i++)
            {
                dsTheloai.Add(temp.Rows[i]["TenTheLoai"].ToString());
            }


            return dsTheloai;
        }

        public List<string> LoadMaDS_TG_TL(string TenTheLoai, string TenTacGia)
        {
            DataTable temp = dsDao.SearchMaDS_TG_TL(TenTheLoai, TenTacGia);

            List<string> ds = new List<string>();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                ds.Add(temp.Rows[i]["MaDauSach"].ToString());
            }
            return ds;
        }

        public List<string> LoadMaDS_OnlyTG(string TenTacGia)
        {
            DataTable temp = dsDao.SearchMaDS_onlyTG(TenTacGia);

            List<string> ds = new List<string>();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                ds.Add(temp.Rows[i]["MaDauSach"].ToString());
            }
            return ds;
        }

        public List<string> LoadMaDS_onlyTenSach(string TenSach)
        {
            DataTable temp = dsDao.SearchMaDS_onlyTenSach(TenSach);

            List<string> ds = new List<string>();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                ds.Add(temp.Rows[i]["MaDauSach"].ToString());
            }
            return ds;
        }


        public List<string> LoadMaDS_TS_TL(string TenTheLoai, string TenSach)
        {
            DataTable temp = dsDao.SearchMaDS_TS_TL(TenTheLoai, TenSach);

            List<string> ds = new List<string>();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                ds.Add(temp.Rows[i]["MaDauSach"].ToString());
            }
            return ds;
        }

        public List<string> LoadMaDS_onlyTheloai(string TenTheLoai)
        {
            DataTable temp = dsDao.SearchMaDS_onlyTheLoai(TenTheLoai);

            List<string> ds = new List<string>();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                ds.Add(temp.Rows[i]["MaDauSach"].ToString());
            }
            return ds;
        }


        #endregion

        #region 
        public DataTable ThongKeSachMuon_DS()
        {
            return dsDao.ThongKeSachMuon_DS();
        }

        #endregion


    }
}
