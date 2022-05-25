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
    class PhieuMuonCreator
    {
        public string MaMuonTra;
        public PhieuMuon_DataSet DS;
        public PhieuMuonRP RP;
        public PhieuMuon_BUS pmBus;
        public int sumGia;
        public int sumCoc;
        public string MaNhanVien;
        public string MaDocGia;
        public PhieuMuonCreator(string MaMT)
        {
            this.MaMuonTra = MaMT;
            this.DS = new PhieuMuon_DataSet();
            this.RP = new PhieuMuonRP();
            this.pmBus = new PhieuMuon_BUS();
            this.MaNhanVien = "";
            this.MaDocGia = "";
            sumCoc = sumGia = 0;
        }

        public bool NhapDuLieuTK_VaoDataSet()
        {
            DataTable tkDS = pmBus.LoadTTPhieuMuon(MaMuonTra);


            //(mã sách, tên sách, vị trí, giá tiền , tiền cọc(10% giá tiền))


            DataTable tempnvdg = pmBus.LoadMaNV_MaDG_PM(MaMuonTra);
            if(tempnvdg.Rows.Count > 0)
            {
                MaNhanVien = tempnvdg.Rows[0]["MaNhanVien"].ToString();
                MaDocGia = tempnvdg.Rows[0]["MaDocGia"].ToString();

            }

            foreach (DataRow row in tkDS.Rows)
            {
                string MaSach = row["MaSach"].ToString();
                string TenDs = row["TenDauSach"].ToString();
                string ViTri = row["ViTriSach"].ToString();
                string GiaTien = row["GiaTien"].ToString();
                string TienCoc = row["TienCoc"].ToString();

                sumGia += int.Parse(GiaTien);
                sumCoc += (int)double.Parse(TienCoc);

                DS.PhieuMuon_dataset.Rows.Add(new object[] {
                    MaSach, TenDs,ViTri,GiaTien,TienCoc
                });
            }

            return true;
        }

        NhanVien_BUS nvBus = new NhanVien_BUS();
        DocGia_BUS dgBus = new DocGia_BUS();
        public void ShowReportHoaDon()
        {
            RP.DataSource = DS;
            RP.DataMember = DS.PhieuMuon_dataset.TableName;
            NhapDuLieuTK_VaoDataSet();

            RP.lbTenNV.Text = nvBus.GetName(MaNhanVien);
            RP.lbTenNVxl.Text = "Nhân viên xử lý: " + nvBus.GetName(MaNhanVien);
            RP.tbCellSumGiaTien.Text = sumGia.ToString();
            RP.tbCellSumTienCoc.Text = sumCoc.ToString();
            RP.lbMaDG.Text = "Mã độc giả: " + MaDocGia;
            RP.lbTenDG.Text = "Tên độc giả : " + dgBus.LoadTenDG(MaDocGia);
            RP.lbMaMT.Text = "Mã mượn trả : " + MaMuonTra;

            RP.xrBarCode1.Text = MaMuonTra;
            DateTime ngaymuon = DateTime.Now;
            DateTime hantra = ngaymuon.Add(new TimeSpan(180, 0, 0, 0));


            RP.lbNgayLap.Text = $"Ngày mượn : {ngaymuon.ToString("dd/MM/yyyy")}                  Hạn trả : {hantra.ToString("dd/MM/yyyy")}";

            ReportPrintTool ViewRP = new ReportPrintTool(RP);

            ViewRP.ShowPreview();
        }


    }
}
