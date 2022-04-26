﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManager.DAO
{
    class DataProvider
    {
        static string provider = @"Data Source=CHU-TUAN-KIET;Initial Catalog=THUVIENMTA;Integrated Security=True";
        SqlConnection connect = new SqlConnection(provider);

        public DataTable GetData(string sql)
        {
            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(rs);
            return rs;
        }
        public void Excute(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void ExcuteWithParam(string sql, SqlParameter[] listParam )
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);

            foreach (var i in listParam)
            {
                command.Parameters.Add(i);
            }
            command.ExecuteNonQuery();
            connect.Close();
        }

        public byte[] LoadImage(string sql)
        {
            
            if (connect.State != ConnectionState.Open)
                connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            byte[] imgbin = new byte[100000000];
            if (reader.HasRows)
            {
                imgbin = (byte[])reader[0];
            }
            connect.Close();
            return imgbin;
        }


    }
}
