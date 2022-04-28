using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;

namespace LibraryManager.DAO
{
    class DocGia_DAO : DataProvider
    {
        public DataTable loadDocGia()
        {
            string sqlString = @"select * from DOCGIA";
            return GetData(sqlString);
        }
        public bool Insert(DocGia dg)
        {
            if (GetData("select* from DOCGIA where MaDocGia = '" + dg.MaDocGia + "'").Rows.Count > 0)
                return false;

            string sql = string.Format("Insert Into TaiKhoan values('{0}', '{1}', '{2}', '{3}')", dg.MaDocGia, dg.TenDangNhap, "", 1);
            Excute(sql);

            sql = string.Format("Insert Into DOCGIA values('{0}','{1}','{2}','{3}','{4}','{5}')",
                dg.MaDocGia, dg.TenDocGia, dg.DiaChi, dg.NgaySinh, dg.GioiTinh, dg.SDT, dg.CMND, dg.NgayDangKi, dg.TenDangNhap, dg.Anh);
            Excute(sql);


            return true;
        }

        public void Delete(string mDG)
        {
            Excute("delete from DOCGIA where MaDocGia = '" + mDG + "'");
        }

        public void Update(DocGia dg)
        {
            //string sql = string.Format("update DOCGIA set TenDocGia = N'{0}', DiaChi = N'{1}', NgaySinh = '{2}', GioiTinh = N'{3}', SDT = '{5}', CMND = '{6}', NgayDangKi = '{7}', NgayDangKi = '{7} where MaDocGia = '{4}'",
            //      dg.TenDocGia, dg.DiaChi, dg.NgaySinh, dg.GioiTinh, dg.SDT, dg.CMND, dg.NgayDangKi, dg.Anh, dg.MaDocGia );
            //Excute(sql);

            //sql = string.Format("update ACCOUNT set TenDangNhap = '{0}' where TenDangNhap = '{1}'", dg.TenDangNhap, dg.MaDocGia);
            //Excute(sql);
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from DOCGIA where MaDocGia like N'%{0}%' or TenDocGia like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }


        public DocGia GetMotDG(string maDG)
        {

            string sql = $"select * from DocGia where MaDocGia = '{maDG}'";
            DataTable res = GetData(sql);
            DocGia dg = new DocGia();
            if (res.Rows.Count == 1)
            {
                //MessageBox.Show(res.Rows[0][0].ToString());
                dg.MaDocGia = maDG;
                dg.TenDocGia = res.Rows[0][2].ToString();
                dg.DiaChi = res.Rows[0][3].ToString();
                dg.NgaySinh = DateTime.Parse(res.Rows[0][4].ToString());
                dg.GioiTinh = res.Rows[0][5].ToString();
                dg.SDT = res.Rows[0][6].ToString();
                dg.CMND = res.Rows[0][7].ToString();
                dg.NgayDangKi = DateTime.Parse(res.Rows[0][8].ToString());
                dg.TenDangNhap = res.Rows[0][9].ToString();
                dg.Anh = (byte[])res.Rows[0][10];
            }

            return dg;

        }




        #region get

        public DataTable GetMaDG()
        {
            string sql = "SELECT MaDocGia FROM dbo.DOCGIA";
            return GetData(sql);
        }

        #endregion
    }
}
