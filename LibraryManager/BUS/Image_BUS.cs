using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
