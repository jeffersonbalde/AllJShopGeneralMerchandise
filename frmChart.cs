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

        frmRecords frmR;

        public frmChart(frmRecords frmr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frmR = frmr;

            this.KeyPreview = true;
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

        public void LoadChartTopItems()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();

                if (frmR.cboSort.Text == "QUANTITY")
                {
                    da = new SqlDataAdapter("SELECT TOP 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + frmR.dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + frmR.dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                }
                else if (frmR.cboSort.Text == "TOTAL")
                {
                    da = new SqlDataAdapter("SELECT TOP 10 pcode, pdesc, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + frmR.dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + frmR.dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", cn);
                }

                DataSet ds = new DataSet();
                da.Fill(ds, "TOPSELLING");
                chart1.DataSource = ds.Tables["TOPSELLING"];
                Series series = chart1.Series[0];
                //series.ChartType = SeriesChartType.Doughnut;
                series.ChartType = SeriesChartType.RangeColumn;

                series.Name = "TOP ITEMS";
                var chart = chart1;
                chart.Series[0].XValueMember = "pdesc";
                //chart.Series[0].XValueMember = "pcode";

                if (frmR.cboSort.Text == "QUANTITY")
                {
                    chart.Series[0].YValueMembers = "qty";
                }

                if (frmR.cboSort.Text == "TOTAL")
                {
                    chart.Series[0].YValueMembers = "total";
                }

                chart.Series[0].IsValueShownAsLabel = true;

                if (frmR.cboSort.Text == "TOTAL")
                {
                    chart.Series[0].LabelFormat = "{#,##0.00}";
                }

                if (frmR.cboSort.Text == "QUANTITY")
                {
                    chart.Series[0].LabelFormat = "{#,##0}";
                }

                cn.Close();

        }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
}

        private void frmChart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
