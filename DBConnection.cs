using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_System
{
    public class DBConnection
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public string MyConnection()
        {
            string con = @"Data Source=LAPTOP-6ODBNAGM\SQLEXPRESS01;Initial Catalog=OOP;Integrated Security=True";
            return con;
        }

        public double GetVal()
        {
            double vat = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            string query = "SELECT * FROM tblVat";
            cm = new SqlCommand(query, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            cn.Close();
            return vat;
        }
    }
}
