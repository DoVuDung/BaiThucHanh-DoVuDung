using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


    public class DataAccess
    {
        private SqlConnection conection;
        public void MoKetNoiCSDL()
        {
            conection = new SqlConnection();
            conection.ConnectionString = @"
           Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andy\source\repos\BaiThucHanh-DoVuDung\BaiThucHanh-DoVuDung\App_Data\Database.mdf;Integrated Security=True
        ";
            conection.Open();
        }     
        public DataTable LayBangDuLieu(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, this.conection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void DongKetNoiCSDL()
        {
            if (conection.State == ConnectionState.Open)
                conection.Close();
        }
}
