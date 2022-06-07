using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using LibraryManager.BUS;

namespace LibraryManager.Report
{
    class BBViphamCreator
    {
        public string MaViPham;
        public BBVP_DataSet DS;
        public BBvipham RP;
        public int sumPhat;
        public int sumSL;
        public string MaNhanVien;
        public string MaDocGia;

        public BienbanVP_BUS bbBus = new BienbanVP_BUS();
        public BBViphamCreator(string MaVP, string MaNV)
        {
            this.MaViPham = MaVP;
            this.DS = new BBVP_DataSet();

            this.RP = new BBvipham();

            this.MaNhanVien = MaNV;
            this.MaDocGia = "";
            sumSL = sumPhat = 0;
        }

        public bool NhapDuLieuTK_VaoDataSet()
        {

            DataTable ChiTietVP_DT = bbBus.RP_GetDSVP(MaViPham);



            DataTable ThongTinBB = bbBus.RP_GetThongtin_BB(MaViPham);
            DS.TTBienBan.Rows.Add(new object[] {
                ThongTinBB.Rows[0]["NgayTra"],
                ThongTinBB.Rows[0]["MaDocGia"],
                ThongTinBB.Rows[0]["TenDocGia"],
                ThongTinBB.Rows[0]["TenNhanVien"],
                MaViPham
            });

            foreach (DataRow row in ChiTietVP_DT.Rows)
            {
                string MaSach = row["MaSach"].ToString();
                string TenDs = row["TenDauSach"].ToString();
                string LyDo = row["LyDo"].ToString();
                string TienPhat = row["TienPhat"].ToString();
                sumSL++;
                
                sumPhat += (int)double.Parse(TienPhat);

                DS.ChiTietVP.Rows.Add(new object[] {
                    MaSach, TenDs,LyDo,TienPhat
                });
            }

            return true;
        }

        NhanVien_BUS nvBus = new NhanVien_BUS();
        DocGia_BUS dgBus = new DocGia_BUS();
        public void ShowReportHoaDon()
        {
            
            NhapDuLieuTK_VaoDataSet();

            RP.tbCellSumTienPhat.Text = sumPhat.ToString();
            RP.tbSLDausach.Text = sumSL.ToString();

            ReportPrintTool ViewRP = new ReportPrintTool(RP);

            ViewRP.ShowPreview();
        }
    }
}
