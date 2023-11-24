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
    public partial class frmQty : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmPOS fpos;

        private String pcode;
        private double price;
        private String transno;
        private int qty;

        public frmQty(frmPOS frmpos)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = frmpos;
        }

        private void frmQty_Load(object sender, EventArgs e)
        {

        }

        public void ProductDetails(String pcode, double price, String transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if((e.KeyChar == 13) && (txtQty.Text != String.Empty))
                {

                    bool found = false;
                    string pcode1 = "";
                    string transno1 = "";

                    int cart_qty = 0;

                    cn.Open();
                    string query1 = "SELECT * FROM tblCart WHERE pcode = @pcode AND transno = @transno";
                    cm = new SqlCommand(query1, cn);
                    cm.Parameters.AddWithValue("@pcode", pcode);
                    cm.Parameters.AddWithValue("@transno", fpos.lblTransno.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        found = true;
                        pcode1 = dr["pcode"].ToString();
                        transno1 = dr["transno"].ToString();
                        cart_qty = int.Parse(dr["qty"].ToString());
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
                        string query = "UPDATE tblCart SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE pcode = @pcode AND transno = @transno";
                        cm = new SqlCommand(query, cn);
                        cm.Parameters.AddWithValue("@pcode", pcode1);
                        cm.Parameters.AddWithValue("@transno", transno1);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        fpos.txtSearch.Clear();
                        fpos.txtSearch.Focus();
                        fpos.LoadCart();
                        this.Dispose();

                    }
                    else
                    {

                        if (qty < int.Parse(txtQty.Text))
                        {
                            MessageBox.Show("Insufficient remaing stock, Remaining item is " + qty, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cn.Open();
                        string query = "INSERT INTO tblcart (transno, pcode, price, qty, sdate, cashier)VALUES(@transno, @pcode, @price, @qty, @sdate, @cashier)";
                        cm = new SqlCommand(query, cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@pcode", pcode);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@cashier", fpos.lblUser.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        fpos.txtSearch.Clear();
                        fpos.txtSearch.Focus();
                        fpos.LoadCart();
                        this.Dispose();
                    }

                }
    
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
