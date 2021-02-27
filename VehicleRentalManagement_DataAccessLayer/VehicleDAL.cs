using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace VehicleRentalManagement_DataAccessLayer
{
    public class VehicleDAL
    {
        public static SqlConnection cd = new SqlConnection();

        public void connectionTest()
        {
            string s = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            cd.ConnectionString = s;
            cd.Open();
            SqlCommand cmd = new SqlCommand("insert into gui_table values(100,'xyzi')",cd);
            cmd.ExecuteNonQuery();
            cd.Close();
        }
    }
}
