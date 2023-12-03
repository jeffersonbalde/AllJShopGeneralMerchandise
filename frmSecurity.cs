using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OOP_System
{
    public partial class frmSecurity : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        
        public frmSecurity()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSecurity_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application? ", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                string name = "";
                string role = "";

                cn.Open();
                string query = "SELECT * FROM tblUser WHERE username = @username AND password = @password";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();    
                dr.Read();

                if (dr.HasRows)
                {
                    found = true;
                    name = dr["name"].ToString();
                    role = dr["role"].ToString();
                }

                cn.Close();
                dr.Close();

                if ((found) && (role == "System Administrator"))
                {
                    MessageBox.Show("WELCOME " + name + " ", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 frm = new Form1();
                    frm.lblName.Text = name;
                    frm.lblRole.Text = role;
                    frm.ShowDialog();
                    this.Dispose();

                }else if((found) && (role == "Cashier"))
                {
                    MessageBox.Show("WELCOME " + name + " ", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPOS frm = new frmPOS(this);
                    frm.lblUser.Text = name;
                    frm.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Username and password do not match", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
