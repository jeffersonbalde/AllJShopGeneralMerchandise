using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OOP_System
{
    public partial class frmChart : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmChart()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadChartItemSales(string sql)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "SOLD");
                chart1.DataSource = ds.Tables["SOLD"];
                Series series = chart1.Series[0];
                series.ChartType = SeriesChartType.RangeColumn;

                series.Name = "ITEM SALES";
                chart1.Series[0].XValueMember = "pdesc";
                chart1.Series[0].YValueMembers = "total";
                chart1.Series[0].LabelFormat = "{#,##0.00}";
                chart1.Series[0].IsValueShownAsLabel = true;
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
