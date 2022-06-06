using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using LibraryManager.BUS;
using DevExpress.XtraReports.UI;

namespace LibraryManager.Report
{
    class PhieuNhapCreator
    {
       
        public PhieuNhap_Dataset DS;
        public PhieuNhapRP RP;
        public PhieuNhap_BUS pnBus;
        public string MaNhanVien;
        public string TenNhanVien;
        public DateTime NgayLap;
        public PhieuNhapCreator(string MaNV, DateTime Ngay)
        {
            
            this.DS = new PhieuNhap_Dataset();
            this.RP = new PhieuNhapRP();
            this.pnBus = new PhieuNhap_BUS();
            this.MaNhanVien = MaNV;
            this.TenNhanVien = "";
            this.NgayLap = Ngay;
            
        }
        public bool NhapDuLieuVaoDataSet()
        {
            DataTable tkDS = pnBus.LoadTTPhieuNhap(MaNhanVien,NgayLap);



            DataTable tempnvdg = pnBus.LoadTenNV(MaNhanVien);
            if (tempnvdg.Rows.Count > 0)
            {
                TenNhanVien = tempnvdg.Rows[0]["TenNhanVien"].ToString();
            }

            foreach (DataRow row in tkDS.Rows)
            {
                string MaPhieuNhap = row["MaPhieuNhap"].ToString();
                string MaSach = row["MaSach"].ToString();
                string TenDs = row["TenDauSach"].ToString();
                string ViTri = row["ViTriSach"].ToString();
                string MoiCu = row["TinhTrangMoiCu"].ToString();
                DS._PhieuNhap_Dataset.Rows.Add(new object[] {
                    MaPhieuNhap,MaSach, TenDs,ViTri,MoiCu,
                });
            }

            return true;
        }

        NhanVien_BUS nvBus = new NhanVien_BUS();
        DocGia_BUS dgBus = new DocGia_BUS();
        public void ShowReportHoaDon()
        {
            RP.DataSource = DS;
            RP.DataMember = DS._PhieuNhap_Dataset.TableName;
            NhapDuLieuVaoDataSet();

            RP.lbMaNVnhap.Text = "Mã nhân viên:  " + MaNhanVien;
            RP.lbTenNVnhap.Text = "Tên nhân viên nhập: " + TenNhanVien;
            RP.lbTenNVxl.Text = TenNhanVien;



            RP.xrBarCode1.Text = MaNhanVien;


            RP.lbNgayLap.Text = $"Ngày nhập : {NgayLap.ToString("dd/MM/yyyy")}";

            ReportPrintTool ViewRP = new ReportPrintTool(RP);

            ViewRP.ShowPreview();
        }
    }
}
