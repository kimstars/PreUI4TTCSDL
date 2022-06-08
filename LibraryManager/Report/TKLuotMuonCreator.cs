using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.BUS;
using DevExpress.XtraReports.UI;



namespace LibraryManager.Report
{

    class TKLuotMuonCreator
    {
        public string MaNhanVien;
        public string MaHoaDon;
        public DauSach_BUS dsBus;
        public TKLuotMuonRP RP;
        public TKLuotMuon_Dataset DS;
        public int sumLuot;
        public int sumDS;
        public TKLuotMuonCreator(string manv)
        {
            this.MaNhanVien = manv;
            this.dsBus = new DauSach_BUS();
            this.RP = new TKLuotMuonRP();
            this.DS = new TKLuotMuon_Dataset();
            sumDS = sumLuot = 0;
        }




        public bool NhapDuLieuTK_VaoDataSet()
        {
            DataTable tkDS = dsBus.ThongKeSachMuon_DS();


            //(Mã đầu sách, Tên đầu sách, Lượt mượn)

            foreach(DataRow row in tkDS.Rows)
            {
                string MaDS = row["MaDauSach"].ToString();
                string TenDs = row["TenDauSach"].ToString();
                string SL = row["SoLuong"].ToString();
                sumDS++;
                sumLuot += int.Parse(SL);

                DS.thongkeDSmuon.Rows.Add(new object[] {
                    MaDS, TenDs,SL
                });
            }


            return true;
        }

        NhanVien_BUS nvBus = new NhanVien_BUS();

        public void ShowReportHoaDon()
        {
            RP.DataSource = DS;
            RP.DataMember = DS.thongkeDSmuon.TableName;
            NhapDuLieuTK_VaoDataSet();

            RP.lbTenNV.Text = nvBus.GetName(MaNhanVien);
            RP.tbCellSumLuot.Text = sumLuot.ToString();
            RP.tbcellSumTenDS.Text = sumDS.ToString();

            RP.lbNgayLap.Text = "Ngày lập : "+DateTime.Now.ToString("dd/MM/yyyy");
            
            ReportPrintTool ViewRP = new ReportPrintTool(RP);

            ViewRP.ShowPreview();
        }
        
    }



}