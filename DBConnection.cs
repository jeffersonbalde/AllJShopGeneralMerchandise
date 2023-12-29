using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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

        private string con;
        private double sales;
        private int items;
        private int stocks;
        private int lowStocks;

        public string MyConnection()
        {

            con = @"Data Source=DESKTOP-RDVC33C\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True";

            return con;
        }

        public double GetSales()
        {
            string sdate = DateTime.Now.ToString("yyyy-MM-dd");

            cn = new SqlConnection();
            cn.ConnectionString = con;

            cn.Open();
            string query = "SELECT ISNULL(SUM(total), 0) AS total FROM tblcart WHERE sdate BETWEEN '" + sdate + "' AND '" + sdate + "' AND status LIKE 'sold'";
            cm = new SqlCommand(query, cn);
            sales = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return sales;
        }

        public double GetItems()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;

            cn.Open();
            string query = "SELECT COUNT(*) FROM tblproduct";
            cm = new SqlCommand(query, cn);
            items = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return items;
        }

        public double GetStocks()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;

            cn.Open();
            string query = "SELECT ISNULL(SUM(qty), 0) AS qty FROM tblproduct";
            cm = new SqlCommand(query, cn);
            stocks = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return stocks;
        }

        public double GetLowStocks()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;

            cn.Open();
            string query = "SELECT COUNT(*) FROM vwCriticalItems";
            cm = new SqlCommand(query, cn);
            lowStocks = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return lowStocks;
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

        public string GetPassword(string user)
        {
            string password = "";

            cn.ConnectionString = MyConnection();
            cn.Open();
            string query = "SELECT * FROM tblUser WHERE name = @name";
            cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@name", user);
            dr = cm.ExecuteReader();
            dr.Read();

            if(dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();

            return password;
        }
    }
}
