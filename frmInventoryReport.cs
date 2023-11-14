using Microsoft.Reporting.WinForms;
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

namespace OOP_System
{
    public partial class frmInventoryReport : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
            
        public frmInventoryReport()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void LoadReport()
        {
            ReportDataSource rptDS;
            try
            {

                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report3.rdlc";

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                string query = "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder FROM tblProduct AS p INNER JOIN tblbrand AS b ON p.bid = b.id INNER JOIN tblcategory AS c ON p.cid = c.id ";
                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(ds.Tables["dtInventory"]);
                cn.Close();

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
