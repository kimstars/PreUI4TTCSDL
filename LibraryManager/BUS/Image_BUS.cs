using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.DAO;
using LibraryManager.DTO;

namespace LibraryManager.BUS
{
    class Image_BUS
    {
        Image_DAO imgdao = new Image_DAO();
        public void SaveImage(string tableName, string MaID, string typeID, string img)
        {
            imgdao.SaveImgToDB(tableName, MaID, typeID, img);
        }

        public byte[] LoadImageFromTableDB(string tableName, string MaID, string typeID)
        {
            return imgdao.LoadImageFromDB(tableName, MaID, typeID);
        }


        public List<byte[]> LoadDSAnh(string tableName)
        {
            return imgdao.LoadDSAnh(tableName);
        }


        public Image Load1Anh(byte[] img)
        {
            
            PictureBox avt = new PictureBox();
            if (img != null)
            {
                return Image.FromStream(new MemoryStream(img));
            }
            else
            {
                return Properties.Resources.icons8_search_client_80px;
            }

        }
    }
}
