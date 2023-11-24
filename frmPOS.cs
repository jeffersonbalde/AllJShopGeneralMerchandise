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
    public partial class frmPOS : Form
    {

        String id;
        String price;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr; 
        DBConnection dbcon = new DBConnection();

        frmSecurity f;

        int qty;

        public frmPOS(frmSecurity frm)
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            f = frm;
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("You have pending items in your current transaction", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void GetCartTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblTotal.Text);
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;

            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = sales.ToString("#,##0.00");
        }

        public void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                string query = "SELECT TOP 1 transno FROM tblcart WHERE transno LIKE '" + sdate + "%' ORDER BY id DESC";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransno.Text = sdate + (count + 1);
                }else
                {
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
                dr.Close();
                cn.Close();

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtSearch.Text == String.Empty) { return; }
                else
                {

                    String _pcode;
                    double _price;
                    int _qty;

                    cn.Open();
                    string query = "SELECT * FROM tblproduct WHERE barcode LIKE '" + txtSearch.Text + "'";
                    cm = new SqlCommand(query, cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                     
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        //frmQty frm = new frmQty(this);
                        //frm.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransno.Text, qty);

                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);

                        dr.Close();
                        cn.Close();

                        //frm.ShowDialog();

                        AddToCart(_pcode, _price, _qty);

                    } else
                    {
                        dr.Close();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddToCart(String _pcode, double _price, int _qty)
        {

            String id = "";
            bool found = false;
            int cart_qty = 0;

            cn.Open();
            string query1 = "SELECT * FROM tblCart WHERE pcode = @pcode AND transno = @transno";
            cm = new SqlCommand(query1, cn);
            cm.Parameters.AddWithValue("@pcode", _pcode);
            cm.Parameters.AddWithValue("@transno", lblTransno.Text);
            dr = cm.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                found = true;
                id = dr["id"].ToString();
                cart_qty = int.Parse(dr["qty"].ToString());
            }
            else
            {
                found = false;
            }
            dr.Close();
            cn.Close();

            if (found)
            {

                if (qty < (int.Parse(txtQty.Text) + cart_qty))
                {
                    MessageBox.Show("Insufficient remaing stock, Remaing item is " + qty, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cn.Open();
                string query = "UPDATE tblCart SET qty = (qty + " + _qty  + ") WHERE id = '" + id + "'";
                cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();
                cn.Close();

                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
                LoadCart();

            }
            else
            {

                if (qty < int.Parse(txtQty.Text))
                {
                    MessageBox.Show("Insufficient remaing stock, Remaing item is " + qty, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cn.Open();
                string query = "INSERT INTO tblcart (transno, pcode, price, qty, sdate, cashier)VALUES(@transno, @pcode, @price, @qty, @sdate, @cashier)";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@transno", lblTransno.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                cm.Parameters.AddWithValue("@price", _price);
                cm.Parameters.AddWithValue("@qty", _qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", lblUser.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
                LoadCart();
            }

        }

        public void LoadCart()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                cn.Open();
                string query = "SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tblcart AS c INNER JOIN tblproduct AS p ON c.pcode = p.pcode WHERE transno LIKE '" + lblTransno.Text + "' AND status LIKE 'Pending'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    discount += Double.Parse(dr["disc"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"), "[ + ]", "[ - ]");
                    hasrecord = true;
                }
                dr.Close(); 
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
                if(hasrecord == true)
                {
                    btnPayment.Enabled = true;
                    btnDiscount.Enabled = true;
                }else
                {
                    btnPayment.Enabled = false;
                    btnDiscount.Enabled = false; 
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if(colName == "Delete")
            {
                if(MessageBox.Show("Remove this item?", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "DELETE FROM tblcart WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    cm = new SqlCommand(query, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been removed", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(lblTransno.Text == "000000000000000")
            {
                return;
            }

            frmLookUp frm = new frmLookUp(this);
            frm.LoadRecords();
            frm.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            price = dataGridView1[4, i].Value.ToString();   
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount frm = new frmDiscount(this);
            frm.lblID.Text = id;
            frm.txtPrice.Text = price;
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if(colName == "Delete")
            {
                if(MessageBox.Show("Remove this item?", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "DELETE FROM tblcart WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    cm = new SqlCommand(query, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been removed", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "DELETE FROM tblcart WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    cm = new SqlCommand(query, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been removed", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colName == "colAdd")
            {
                int i = 0;
                cn.Open();
                string query = "SELECT sum(qty) AS qty FROM tblproduct WHERE pcode LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode";
                cm = new SqlCommand(query, cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {

                    cn.Open();
                    string query1 = "UPDATE tblCart SET qty  = qty + " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTransno.Text + "' AND pcode LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
                    cm = new SqlCommand(query1, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Insufficient remaing stock, Remaining item is " + i + " ", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if(colName == "colRemove")
            {
                int i = 0;
                cn.Open();
                string query = "SELECT sum(qty) AS qty FROM tblCart WHERE pcode LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' AND transno LIKE '" + lblTransno.Text + "' GROUP BY transno, pcode";
                cm = new SqlCommand(query, cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (i > 1)
                {

                    cn.Open();
                    string query1 = "UPDATE tblCart SET qty  = qty - " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTransno.Text + "' AND pcode LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
                    cm = new SqlCommand(query1, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Insufficient item, Remaining item is " + i + " ", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate1.Text = DateTime.Now.ToLongDateString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmSettle frm = new frmSettle(this);
            frm.txtSale.Text = lblDisplayTotal.Text;
            frm.ShowDialog();
            frm.txtCash.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            frmSoldItems frm = new frmSoldItems();
            frm.suser = lblUser.Text;
            frm.dt1.Enabled = false;
            frm.dt2.Enabled = false;
            frm.cboCashier.Enabled = false;
            frm.cboCashier.Text = lblUser.Text;
            frm.ShowDialog();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("You have pending items in your current transaction", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else
            {
                if (MessageBox.Show("Are you sure you want to log out and close the application?", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                    frmSecurity frm = new frmSecurity();
                    frm.ShowDialog();
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
            
        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDiscount_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnPayment_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                //todo
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnSale_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnChangePass_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                button11_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F9)
            {
                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(this);
            frm.ShowDialog();
        }
    }
}
