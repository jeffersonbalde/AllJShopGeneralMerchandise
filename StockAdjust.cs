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
        Form1 f;
        frmProductList frmpl;

        public StockAdjust(Form1 frm, frmProductList frmPL)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
            frmpl = frmPL;

            f.GetDashboard();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //}

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

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    LoadRecords();
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtQuantity.Text != String.Empty) && (txtAction.Text != String.Empty))
                {
                    if (int.Parse(txtQuantity.Text) > _qty)
                    {
                        MessageBox.Show("Quantity should be less than the item quantity", "QUANTITY INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQuantity.Focus();
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

                    SqlStatement("INSERT INTO tbladjustment(pcode, qty, action, sdate) VALUES('" + txtProductCode.Text + "', '" + int.Parse(txtQuantity.Text) + "', '" + txtAction.Text + "', '" + DateTime.Now.ToString("yyyyMMdd") + "')"); 

                    MessageBox.Show("Stock has been successfully adjusted.", "ITEM ADJUSTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                    Clear();
                    frmpl.LoadRecords();

                    Form1 frm = new Form1();
                    frm.lblStocks.Text = dbcon.GetStocks().ToString("#,##0");
                    frm.lblLowStocks.Text = dbcon.GetLowStocks().ToString("#,##0");
                }
                else
                {
                    MessageBox.Show("Please fill up all fields.", "SAVE ITEMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                f.GetDashboard();
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
            textBoxItem.Clear();
            txtQuantity.Clear();
            txtAction.Text = "";
        }


        private void StockAdjust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose(true);
            }
        }

        //private void button1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        button1_Click(sender, e);
        //    }
        //}

        //private void txtSearch_Click(object sender, EventArgs e)
        //{

        //}

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void StockAdjust_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView7.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                //txtProductCode.Text = dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxItem.Text = dataGridView7.Rows[e.RowIndex].Cells[3].Value.ToString();

                _qty = int.Parse(dataGridView7.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void dataGridView7_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView7.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                txtProductCode.Text = dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxItem.Text = dataGridView7.Rows[e.RowIndex].Cells[3].Value.ToString();

                _qty = int.Parse(dataGridView7.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
    }
}
