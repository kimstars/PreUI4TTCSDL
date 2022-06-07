using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManager.DAO
{
    class DocGia_DAO : DataProvider
    {
        //proc lấy ra tất cả thông tin độc giả từ bảng độc giả
        public DataTable loadDocGia()
        {

            string NameProc = "proc_DG_loadDocGia";

            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MaDG", "");


            return GetData_Proc_NParam(NameProc, sParams);
        }

        //proc lấy ra thông tin độc giả đã mượn sách
        public DataTable loadDocGiaInfo()
        {

            string NameProc = "proc_DG_loadDocGiaInfo";

            SqlParameter[] sParams = new SqlParameter[0];

            return GetData_Proc_NParam(NameProc, sParams);
        }

        // lọc độc giả
        public DataTable loadDocGiaLoc(string loai)
        {
            string sqlString = @"EXEC LOCDOCGIA '"+loai+"'";
            return GetData(sqlString);
        }

        public bool Insert(DocGia dg)
        {
            if (GetData("select* from DOCGIA where MaDocGia = '" + dg.MaDocGia + "'").Rows.Count > 0)
                return false;

            string sql = $"Insert Into TaiKhoan values('{dg.TenDangNhap}', '{dg.MatKhau}', 'docgia')";

            Excute(sql);

            sql = $"Insert Into DOCGIA values('{dg.MaDocGia}',N'{dg.TenDocGia}',N'{dg.DiaChi}','{dg.NgaySinh}',N'{dg.GioiTinh}','{dg.SDT}','{dg.CMND}','{dg.NgayDangKi}','{dg.TenDangNhap}',NULL)";

            Excute(sql);

            return true;
        }

        public void Delete(string mDG)
        {
            Excute("Delete from DOCGIA where MaDocGia = '" + mDG + "'");
        }

        public bool Update(DocGia dg)
        {

            string sql = $"update DOCGIA set TenDocGia = N'{dg.TenDocGia}', DiaChi = N'{dg.DiaChi}', NgaySinh = '{DateToString(dg.NgaySinh)}', GioiTinh = N'{dg.GioiTinh}', SDT = '{dg.SDT}', CMND = '{dg.CMND}' where MaDocGia = '{dg.MaDocGia}'";

            Excute(sql);
            return true;

        
        }

        //proc tìm kiếm độc giả theo mã hoặc họ tên từ bảng độcgiả
        public DataTable Search(string timkiem)
        {
            string NameProc = "proc_PM_Search";
            timkiem = $"%{timkiem}%";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@timkiem", timkiem);
            return GetData_Proc_NParam(NameProc, sParams);
        }


        #region khoataikhoan

        public void KhoaTaiKhoan(string MaDocGia)
        {
            string NameProc = "KhoaTaiKhoan";

            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@ma", MaDocGia);
            Excute_Proc_NParam(NameProc,sParams);

        }
        public void MoKhoaTK(string MaDocGia)
        {
            string NameProc = "MoKhoaTaiKhoan";

            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@ma", MaDocGia);
            Excute_Proc_NParam(NameProc, sParams);

        }



        #endregion

        public DocGia GetMotDG(string maDG)
        {

            string NameProc = "proc_DG_loadDocGia";

            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MaDG", maDG);

            DataTable res = GetData_Proc_NParam(NameProc, sParams);
            DocGia dg = new DocGia();
            if (res.Rows.Count == 1)
            {
                //MessageBox.Show(res.Rows[0][1].ToString());
                dg.MaDocGia = maDG;
                dg.TenDocGia = res.Rows[0][2].ToString();
                dg.DiaChi = res.Rows[0][3].ToString();
                dg.NgaySinh = DateTime.Parse(res.Rows[0][4].ToString());
                dg.GioiTinh = res.Rows[0][5].ToString();
                dg.SDT = res.Rows[0][6].ToString();
                dg.CMND = res.Rows[0][7].ToString();
                dg.NgayDangKi = DateTime.Parse(res.Rows[0][8].ToString());
                dg.TenDangNhap = res.Rows[0][9].ToString();

            }

            return dg;

        }



        #region get MADOCGIA

        public string GetLastest_MaDG()
        {
            string sql = "SELECT TOP 1 MaDocGia FROM dbo.DOCGIA ORDER BY MaDocGia DESC";
            return GetString(sql);
        }

        public DataTable GetMaDG()
        {
            string sql = "SELECT MaDocGia FROM dbo.DOCGIA";
            return GetData(sql);
        }

        public string GetMaDG_PhieuMuon(string MaMuonTra)
        {
            string sql = $"SELECT MaDocGia FROM dbo.PHIEUMUONTRA WHERE MaMuonTra = '{MaMuonTra}'";
            return GetString(sql);
        }

        #endregion


        #region HoatDong
           
        public string TongSachMuon1Month(string MaDocGia)
        {
            DateTime date = DateTime.Today.Subtract(new TimeSpan(30, 0, 0, 0));
            string start = DateToString(date);
            string end = DateToString(DateTime.Today);

            string sql = $"SELECT pm.NgayMuon, COUNT(MaSach) FROM dbo.THONGTINMUONTRA tt INNER JOIN dbo.PHIEUMUONTRA pm ON pm.MaMuonTra = tt.MaMuonTra WHERE pm.MaDocGia = '{MaDocGia}' AND pm.NgayMuon BETWEEN '{start}' AND '{end}'GROUP BY pm.NgayMuon";


            return GetCount(sql).ToString();
            
        }

        public string TongSachTra1Month(string MaDocGia)
        {
            DateTime date = DateTime.Today.Subtract(new TimeSpan(30, 0, 0, 0));
            string start = DateToString(date);
            string end = DateToString(DateTime.Today);

            string sql = $"SELECT tt.NgayTra, COUNT(tt.MaSach) FROM dbo.THONGTINMUONTRA tt INNER JOIN  dbo.PHIEUMUONTRA pm ON pm.MaMuonTra = tt.MaMuonTra WHERE pm.MaDocGia = '{MaDocGia}' AND tt.NgayTra BETWEEN '{start}' AND '{end}' GROUP BY tt.NgayTra";


            return GetCount(sql).ToString();
        }

        public DataTable LoiViPham(string MaDocGia)
        {
            string sql = $"SELECT vp.LyDo, vp.MaSach FROM dbo.VIPHAM vp INNER JOIN dbo.BIENBANVIPHAM AS bb ON bb.MaViPham = vp.MaViPham WHERE bb.MaDocGia = '{MaDocGia}'";
            return GetData(sql);
        }


        public DataTable SachDenHan(string MaDocGia)
        {
            string sql = $"SELECT pm.MaMuonTra,pm.HanTra, COUNT(tt.MaSach) AS soluong FROM dbo.PHIEUMUONTRA pm INNER JOIN dbo.THONGTINMUONTRA tt ON tt.MaMuonTra = pm.MaMuonTra WHERE tt.NgayTra IS NULL AND pm.MaDocGia = '{MaDocGia}' AND DATEDIFF(DAY, pm.HanTra, GETDATE()) > 10 GROUP BY pm.MaMuonTra,pm.HanTra";
            return GetData(sql);
        }


        public DataTable SachDaMuon_Soluong(string MaDocGia)
        {
            string sql = $"SELECT COUNT(tt.MaSach) sl, pm.NgayMuon FROM dbo.THONGTINMUONTRA tt INNER JOIN dbo.PHIEUMUONTRA pm ON tt.MaMuonTra = pm.MaMuonTra WHERE pm.MaDocGia = '{MaDocGia}' GROUP BY pm.NgayMuon ORDER BY pm.NgayMuon DESC";


            return GetData(sql);
        }

        public int TongSoSachChuaTra(string MaDocGia)
        {
            string sql = $"SELECT COUNT(tt.MaSach) FROM dbo.THONGTINMUONTRA tt INNER JOIN dbo.PHIEUMUONTRA pm ON pm.MaMuonTra = tt.MaMuonTra WHERE pm.MaDocGia = '{MaDocGia}'";

            return (int)GetCount(sql);

        }

        public DataTable TraGanNhat(string MaDocGia)
        {
            string sql = $"SELECT COUNT(tt.MaSach) sl, tt.NgayTra FROM dbo.THONGTINMUONTRA tt INNER JOIN dbo.PHIEUMUONTRA pm ON tt.MaMuonTra = pm.MaMuonTra WHERE pm.MaDocGia = '{MaDocGia}' AND tt.NgayTra IS NOT NULL GROUP BY tt.NgayTra ORDER BY tt.NgayTra DESC";

            return GetData(sql);
        }



        #endregion



        #region khoataikhoan
        


        #endregion


        public string GetMaDG_TaiKhoan(string TenDangNhap)
        {
            string sql = $"SELECT dg.MaDocGia FROM dbo.DOCGIA dg INNER JOIN dbo.TAIKHOAN tk ON  tk.TenDangNhap = dg.TenDangNhap WHERE dg.TenDangNhap = '{TenDangNhap}'";
            return GetString(sql);

        }




        #region NhanvienXuLy
        public string GetTenDocGia(string MaDG)
        {
            string sql = $"SELECT TenDocGia FROM dbo.DOCGIA WHERE MaDocGia = '{MaDG}'";
            return GetString(sql);
        }

        public bool checkTonTaiDG(string MaDG)
        {
            string ten = GetTenDocGia(MaDG); 
            if(ten != "")
            {
                return false;
            }
            return true;
        }

        #endregion
    }



}
