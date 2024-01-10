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

            this.KeyPreview = true;
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

        public void LoadTopSelling(string sql, string param, string header) 
        {
            try
            {

                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptTop.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtTopSelling"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pHeader = new ReportParameter("pHeader", header);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pHeader);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtTopSelling"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSoldItems(string sql, string param, string pcashier)
        {
            try
            {

                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSold.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtSoldItems"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter cashier = new ReportParameter("cashier", pcashier);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(cashier);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldItems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadReport()
        {
            ReportDataSource rptDS;
            try
            {

                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                string query = "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder FROM tblProduct AS p INNER JOIN tblbrand AS b ON p.bid = b.id INNER JOIN tblcategory AS c ON p.cid = c.id ";
                string query1 = "SELECT pcode, barcode, pdesc, price, qty, reorder FROM tblProduct";
                da.SelectCommand = new SqlCommand(query1, cn);
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

        public void LoadStockInReport(string query, string date)
        {
            ReportDataSource rptDS;
            try
            {

                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptStockIn.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                ReportParameter pDate = new ReportParameter("pDate", date);
                reportViewer1.LocalReport.SetParameters(pDate);

                cn.Open();
                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(ds.Tables["dtStockIn"]); 
                cn.Close();

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtStockIn"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadReturnItems(string query, string date)
        {
            ReportDataSource rptDS;
            try
            {

                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptReturnItems.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                ReportParameter pDate = new ReportParameter("PDate", date);
                reportViewer1.LocalReport.SetParameters(pDate);

                cn.Open();
                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(ds.Tables["dtReturnItems"]);
                cn.Close();

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtReturnItems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmInventoryReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
