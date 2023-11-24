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
    public partial class frmChangePassword : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        frmPOS f;

        public frmChangePassword(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string _oldpass = dbcon.GetPassword(f.lblUser.Text);

                if(_oldpass != txtOld.Text)
                {
                    MessageBox.Show("Old password did not matched, Please try again", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNew.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Please make sure your password match", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to change your password?", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        string query = "UPDATE tbluser SET password = @password WHERE name = @name";
                        cm = new SqlCommand(query, cn);
                        cm.Parameters.AddWithValue("@password", txtNew.Text);
                        cm.Parameters.AddWithValue("@name", f.lblUser.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Password Changed!", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
