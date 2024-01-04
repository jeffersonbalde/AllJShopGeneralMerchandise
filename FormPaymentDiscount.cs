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
    public partial class FormPaymentDiscount : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmSettle frm;

        public FormPaymentDiscount(frmSettle form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            if (e.KeyChar == 46)
            {
                //accept . character
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //accept code 48-57 between 0-9
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frm.lblDiscount.Text = txtDiscountAmount.Text;
            double sale = double.Parse(frm.txtSale.Text);
            double discount = double.Parse(txtDiscountAmount.Text);
            double grandTotal = sale - discount;
            //frm.lblGrandTotal.Text = grandTotal.ToString("#,##0.00");
            this.Dispose();
        }

        private void FormPaymentDiscount_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtDiscountAmount;
        }
    }
}
