using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Data;

namespace LibraryManager.DAO
{
    class Image_DAO : DataProvider
    {
        public void SaveImgToDB(string tableName, string MaID, string typeID, string imgPath)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                string filename = Path.GetFileName(imgPath);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = $"Update {tableName} set Anh = @img where {typeID} = '{MaID}'";

                SqlParameter[] sParams = new SqlParameter[1]; 

                sParams[0] = new SqlParameter("@img", img);

                ExcuteWithParam(sql, sParams);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public byte[] LoadImageFromDB(string tableName, string MaID,string typeID) // MaID : MaNV, MaDG, MaDauSach
        {

            string sql = $"Select ANH from {tableName} where {typeID}='{MaID}'";

            return LoadImage(sql);

        }


        public List<byte[]> LoadDSAnh(string tableName)
        {
            string sql = $"SELECT Anh FROM {tableName}";
            DataTable temp = GetData(sql);

            List<byte[]> listAnh = new List<byte[]>();
            for(int i = 0; i < temp.Rows.Count; i++)
            {
                byte[] anhtemp = (byte[])temp.Rows[i]["Anh"];
                listAnh.Add(anhtemp);
            }

            return listAnh;

        }


    }
}
