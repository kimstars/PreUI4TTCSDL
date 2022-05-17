using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class NhaXuatBan_DAO : DataProvider
    {

        public DataTable GetTenNXB()
        {
            string sql = "SELECT * FROM dbo.NhaXuatBan";
            return GetData(sql);
        }

        public DataTable LoadNhaXuatBan()
        {
            string sqlString = @"select * from NhaXuatBan";
            return GetData(sqlString);
        }

        public void InsertNhaXuatBan(NhaXuatBan nxb)
        {
            string sql = $"EXEC PROC_THEMNHAXUATBAN  '{nxb.MaNhaXuatBan}','{nxb.TenNhaXuatBan}','{nxb.DiaChi}'";

            Excute(sql);
        }

        public void UpdateNhaXuatBan(string MaNhaXuatBan, string TenNhaXuatBan, string DiaChi)
        {
            string sql = $"EXEC PROC_SUANHAXUATBAN '{MaNhaXuatBan}','{TenNhaXuatBan}','{DiaChi}'";

            Excute(sql);
        }

        public void DeleteNhaXuatBan(NhaXuatBan nxb)
        {
            string sql = $"EXEC PROC_XOANHAXUATBAN '{nxb.MaNhaXuatBan}'";

            Excute(sql);
        }

    }
}
