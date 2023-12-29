using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Windows.Forms.DataVisualization.Charting;

namespace OOP_System
{
    public partial class frmRecords : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        int _qty = 0;
        readonly Form1 form1;

        public frmRecords()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            cboSort.Text = "QUANTITY";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadRecord()
        {
            try
            {
                int i = 0;
                cn.Open();
                dataGridView1.Rows.Clear();
                if(cboSort.Text == "QUANTITY")
                {
                    cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                }
                else if(cboSort.Text == "TOTAL")
                {
                    cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", cn);
                }
                else
                {
                    cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                }
                //Top 10 products only
                //string query = "SELECT top 10 pcode, pdesc, SUM(qty) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC";
                //cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                //cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while(dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr["pdesc"].ToString(), dr["qty"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }

                dr.Close();
                cn.Close();

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void VoidItems()
        {
            try
            {

                int i = 0;
                dataGridView5.Rows.Clear();
                cn.Open();
                string query = "SELECT * FROM vwcancelledorder WHERE sdate BETWEEN '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView5.Rows.Add(i, dr["transno"].ToString(), int.Parse(dr["pcode"].ToString()), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["cancelledby"].ToString(), dr["action"].ToString());
                }
                dr.Close();
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();

                int i = 0;
                cn.Open();
                //string query = "SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY c.pcode, p.pdesc c.price";
                string query1 = "SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY c.pcode, p.pdesc, c.price";
                cm = new SqlCommand(query1, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView2.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["tot_qty"].ToString(), dr["tot_disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }

                dr.Close();
                cn.Close();

                cn.Open();
                string query2 = "SELECT ISNULL(SUM(total),0) FROM tblcart WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "'";
                cm = new SqlCommand(query2, cn);
                lblTotal.Text = Double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadInventory()
        {
            try
            {

                int i = 0;
                dataGridView4.Rows.Clear();
                cn.Open();
                string query4 = "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder FROM tblProduct AS p INNER JOIN tblbrand AS b ON p.bid = b.id INNER JOIN tblcategory AS c ON p.cid = c.id ";
                string query = "SELECT pcode, barcode, pdesc, price, qty, reorder FROM tblproduct";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dataGridView4.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["reorder"].ToString());
                }
                dr.Close();
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            frm.LoadReport();

            frm.ShowDialog();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VoidItems();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        public void LoadStockInHistory()
        {
            try
            {
                int i = 0;
                dataGridView6.Rows.Clear();
                cn.Open();
                //string query = "SELECT * FROM vwStockin WHERE cast(sdate as date) between '" + date1.Value.ToShortDateString() + "' and '" + date2.Value.ToShortDateString() + "' and status LIKE 'Done'";
                cm = new SqlCommand("Select * from vwStockin where cast(sdate as date) between '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "' and status like 'Done'", cn);
                //cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView6.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString());
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInventoryReport   f = new frmInventoryReport();
            if(cboSort.Text == "QUANTITY")
            {
                f.LoadTopSelling("SELECT top 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", "From: " + dt1.Value.ToString("yyyy-MM-dd") + " To: " + dt2.Value.ToString("yyyy-MM-dd"), "TOP SELLING ITEMS SORT BY QUANTITY");
            }else if(cboSort.Text == "TOTAL")
            {
                f.LoadTopSelling("SELECT top 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", "From: " + dt1.Value.ToString("yyyy-MM-dd") + " To: " + dt2.Value.ToString("yyyy-MM-dd"), "TOP SELLING ITEMS SORT BY TOTAL AMOUNT");
            }
            else
            {
                f.LoadTopSelling("SELECT top 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", "From: " + dt1.Value.ToString("yyyy-MM-dd") + " To: " + dt2.Value.ToString("yyyy-MM-dd"), "TOP SELLING ITEMS SORT BY QUANTITY");
            }
            f.ShowDialog();
        }

        //private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    frmInventoryReport f = new frmInventoryReport();
        //    f.LoadSoldItems("SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY c.pcode, p.pdesc, c.price", "From: " + dt3.Value.ToString("yyyy-MM-dd") + " To: " + dt4.Value.ToString("yyyy-MM-dd"));
        //    f.ShowDialog();
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //public void LoadRecords()
        //{
        //    try
        //    {

        //        int i = 0;
        //        dataGridView7.Rows.Clear();
        //        cn.Open();
        //        string query = "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tblProduct as p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE '" + txtSearch.Text + "%' ORDER BY p.pdesc";
        //        string query1 = "SELECT pcode, barcode, pdesc, price, qty FROM tblProduct WHERE pdesc LIKE '" + txtSearch.Text + "%' ORDER BY pdesc";
        //        cm = new SqlCommand(query1, cn);
        //        dr = cm.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            i++;
        //            dataGridView7.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString());
        //        }
        //        dr.Close();
        //        cn.Close();

        //    }
        //    catch(Exception ex)
        //    {
        //        cn.Close();
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    LoadRecords();
        //}

        //private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string colName = dataGridView7.Columns[e.ColumnIndex].Name;
        //    if(colName == "Select")
        //    {
        //        txtProductCode.Text = dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        txtDescription.Text = dataGridView7.Rows[e.RowIndex].Cells[3].Value.ToString();

        //        _qty = int.Parse(dataGridView7.Rows[e.RowIndex].Cells[5].Value.ToString());
        //    }
        //}

        //public void SqlStatement(string query)
        //{
        //    try
        //    {

        //        cn.Open();
        //        cm = new SqlCommand(query, cn);
        //        cm.ExecuteNonQuery();
        //        cn.Close();

        //    }
        //    catch(Exception ex)
        //    {
        //        cn.Close();
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void Clear()
        //{
        //    txtProductCode.Clear();
        //    txtDescription.Clear();
        //    txtQuantity.Clear();
        //    txtAction.Text = "";
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if ((txtQuantity.Text != String.Empty) && (txtAction.Text != String.Empty))
        //        {
        //            if (int.Parse(txtQuantity.Text) > _qty)
        //            {
        //                MessageBox.Show("Quantity should be less than the stock quantity", "QUANTITY INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            if (txtAction.Text == "REMOVE QUANTITY")
        //            {
        //                SqlStatement("UPDATE tblproduct SET qty = (qty - " + int.Parse(txtQuantity.Text) + ") WHERE pcode LIKE '" + txtProductCode.Text + "'");
        //            }
        //            else
        //            {
        //                SqlStatement("UPDATE tblproduct SET qty = (qty + " + int.Parse(txtQuantity.Text) + ") WHERE pcode LIKE '" + txtProductCode.Text + "'");
        //            }

        //            SqlStatement("INSERT INTO tbladj
        //            ustment(pcode, qty, action, sdate) VALUES('" + txtProductCode.Text + "', '" + int.Parse(txtQuantity.Text) + "', '" + txtAction.Text + "', '" + DateTime.Now.ToShortDateString() + "')");

        //            MessageBox.Show("Stock has been successfully adjusted.", "ITEM ADJUSTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LoadRecords();
        //            LoadCriticalItems();
        //            Clear();

        //            Form1 frm = new Form1();
        //            frm.lblStocks.Text = dbcon.GetStocks().ToString("#,##0");
        //            frm.lblLowStocks.Text = dbcon.GetLowStocks().ToString("#,##0");

        //            frm.GetDashboard();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please fill up all form", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        cn.Close();
        //        MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void frmRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click_1(sender, e);
            }
        }

        private void cboSort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChart frm = new frmChart(this);
            frm.lblTitle.Text = "ITEM SALES (" + dt3.Value.ToShortDateString() + " -  " + dt4.Value.ToShortDateString() + ")";
            frm.LoadChartItemSales("SELECT p.pdesc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY p.pdesc ORDER BY total DESC");
            frm.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmInventoryReport f = new frmInventoryReport();
            if (cboSort.Text == "QUANTITY")
            {
                f.LoadTopSelling("SELECT top 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", "From: " + dt1.Value.ToString("yyyy-MM-dd") + " To: " + dt2.Value.ToString("yyyy-MM-dd"), "TOP SELLING ITEMS SORT BY QUANTITY");
            }
            else if (cboSort.Text == "TOTAL")
            {
                f.LoadTopSelling("SELECT top 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", "From: " + dt1.Value.ToString("yyyy-MM-dd") + " To: " + dt2.Value.ToString("yyyy-MM-dd"), "TOP SELLING ITEMS SORT BY TOTAL AMOUNT");
            }
            else
            {
                f.LoadTopSelling("SELECT top 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", "From: " + dt1.Value.ToString("yyyy-MM-dd") + " To: " + dt2.Value.ToString("yyyy-MM-dd"), "TOP SELLING ITEMS SORT BY QUANTITY");
            }
            f.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmChart frm = new frmChart(this);
            frm.lblTitle.Text = "ITEM SALES (" + dt3.Value.ToShortDateString() + " -  " + dt4.Value.ToShortDateString() + ")";
            frm.LoadChartItemSales("SELECT p.pdesc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY p.pdesc ORDER BY total DESC");
            frm.ShowDialog();

        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    frmInventoryReport f = new frmInventoryReport();
        //    f.LoadSoldItems("SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY c.pcode, p.pdesc, c.price", "From: " + dt3.Value.ToString("yyyy-MM-dd") + " To: " + dt4.Value.ToString("yyyy-MM-dd"));
        //    f.ShowDialog();
        //}

        private void button9_Click(object sender, EventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            string date = "DATE: (" + date1.Value.ToString("yyyy-MM-dd") + " - " + date2.Value.ToString("yyyy-MM-dd") + ")";
            frm.LoadStockInReport("Select * from vwStockin where cast(sdate as date) between '" + date1.Value.ToString("yyyy-MM-dd") + "' AND '" + date2.Value.ToString("yyyy-MM-dd") + "' and status like 'Done'", date);
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            string query = "SELECT * FROM vwcancelledorder WHERE sdate BETWEEN '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
            string date = "DATE: ( " + dateTimePicker2.Value.ToString("yyyy-MM-dd") + " - " + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " )";
            frm.LoadReturnItems(query, date);
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChart frm = new frmChart(this);
            frm.lblTitle.Text = "TOP ITEMS (" + dt1.Value.ToShortDateString() + " -  " + dt2.Value.ToShortDateString() + ")";
            frm.LoadChartTopItems();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecord();

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void dt2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
