using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_System
{
    public partial class frmCancelDetails : Form
    {
        frmSoldItems f;

        public frmCancelDetails(frmSoldItems frm)
        {
            InitializeComponent();
            f = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCancelDetails_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;   
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if ((cboAction.Text != String.Empty) && (txtCancelQty.Text != String.Empty))
                {
                    if(int.Parse(txtQty.Text ) >= int.Parse(txtCancelQty.Text))
                    {
                        frmVoid f = new frmVoid(this);
                        f.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("Quantity Invalid", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the form", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshList()
        {
            f.LoadRecord();
        }
    }
}
