﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;

namespace LibraryManager.BUS
{
    class NhapSach_BUS
    {
        NhapSach_DAO nsDAO = new NhapSach_DAO();
        public DataTable LoadTTNhap()
        {
            return nsDAO.GetTTNhap();
        }

        public string LoadSLSachChuaNhap(string MaDauSach)
        {
            return nsDAO.GetRemainNhap(MaDauSach).ToString();
        }

        public void ThemThongtinNhap(PhieuNhap pn, ThongTinNhapSach ttns)
        {
            nsDAO.InsertPhieuNhap_TTNS(pn, ttns);
        }

        public string AutoTaoMaNhap()
        {
            string index = (nsDAO.GetSoLuongPhieuNhap()).ToString();
            string MaNhap = "PN000000";
            MaNhap = MaNhap.Substring(0, 8 - index.Length) + index;
            return MaNhap;
        }


        public void CallProc_Gen_PN(string manv, DateTime ngay)
        {
            nsDAO.CallProc_Gen_Phieunhap(manv, ngay);
        }


        public int SoLuongSach_ChuaNhap()
        {
            return nsDAO.SLSachchuanhap();
        }


    }

}
