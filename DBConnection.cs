using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_System
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=LAPTOP-6ODBNAGM\SQLEXPRESS01;Initial Catalog=OOP;Integrated Security=True";
            return con;
        }
    }
}
