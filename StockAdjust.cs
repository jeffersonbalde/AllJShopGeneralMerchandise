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
    public partial class StockAdjust : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        int _qty = 0;

        public StockAdjust()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadRecords()
        {
            try
            {

                int i = 0;
                dataGridView7.Rows.Clear();
                cn.Open();
                string query = "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tblProduct as p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE '" + txtSearch.Text + "%' ORDER BY p.pdesc";
                string query1 = "SELECT pcode, barcode, pdesc, price, qty FROM tblProduct WHERE pdesc LIKE '" + txtSearch.Text + "%' ORDER BY pdesc";
                cm = new SqlCommand(query1, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView7.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString());
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtQuantity.Text != String.Empty) && (txtAction.Text != String.Empty))
                {
                    if (int.Parse(txtQuantity.Text) > _qty)
                    {
                        MessageBox.Show("Quantity should be less than the stock quantity", "QUANTITY INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtAction.Text == "REMOVE QUANTITY")
                    {
                        SqlStatement("UPDATE tblproduct SET qty = (qty - " + int.Parse(txtQuantity.Text) + ") WHERE pcode LIKE '" + txtProductCode.Text + "'");
                    }
                    else
                    {
                        SqlStatement("UPDATE tblproduct SET qty = (qty + " + int.Parse(txtQuantity.Text) + ") WHERE pcode LIKE '" + txtProductCode.Text + "'");
                    }

                    SqlStatement("INSERT INTO tbladjustment(pcode, qty, action, sdate) VALUES('" + txtProductCode.Text + "', '" + int.Parse(txtQuantity.Text) + "', '" + txtAction.Text + "', '" + DateTime.Now.ToShortDateString() + "')");

                    MessageBox.Show("Stock has been successfully adjusted.", "ITEM ADJUSTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                    Clear();

                    Form1 frm = new Form1();
                    frm.lblStocks.Text = dbcon.GetStocks().ToString("#,##0");
                    frm.lblLowStocks.Text = dbcon.GetLowStocks().ToString("#,##0");

                    frm.GetDashboard();
                }
                else
                {
                    MessageBox.Show("Please fill up all form", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SqlStatement(string query)
        {
            try
            {

                cn.Open();
                cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtProductCode.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtAction.Text = "";
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView7.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                txtProductCode.Text = dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescription.Text = dataGridView7.Rows[e.RowIndex].Cells[3].Value.ToString();

                _qty = int.Parse(dataGridView7.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
    }
}
