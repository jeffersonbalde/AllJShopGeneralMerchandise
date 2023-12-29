using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_System
{
    public partial class frmUserAccount : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmUserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRetype.Clear();
            txtUser.Clear();
            cboRole.Text = "";
            txtUser.Focus();
        }

        private void metroTabControl1_Resize(object sender, EventArgs e)
        {

        }

        private void frmUserAccount_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width - metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtName.Text == "" || txtPass.Text == "" || txtRetype.Text == "" || txtUser.Text == "" || cboRole.Text == "")
                {
                    MessageBox.Show("Please fill up all fields", "ADD ITEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPass.Text != txtRetype.Text)
                {
                    MessageBox.Show("Please make sure your passwords match.", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cn.Open();
                string query = "INSERT INTO tblUser(username, password, role, name) VALUES(@username, @password, @role, @name)";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                cm.Parameters.AddWithValue("@role", cboRole.Text);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                LoadUsername();
                LoadUsernameDelete();
                Clear();
                MessageBox.Show("Account saved.", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadUsername()
        {
            try
            {
                comboBoxUsername.Items.Clear();
                cn.Open();
                string query = "SELECT * FROM tblUser";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxUsername.Items.Add(dr["username"].ToString());
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

        public void LoadUsernameDelete()
        {
            try
            {
                comboBoxDeleteUsername.Items.Clear();
                cn.Open();
                string query = "SELECT * FROM tblUser";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxDeleteUsername.Items.Add(dr["username"].ToString());
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

        public void DeleteUsername()
        {
            try
            {
                comboBoxDeleteUsername.Items.Clear();
                LoadUsernameDelete();

                if (MessageBox.Show("Deleting your account will remove your access to the system. This can’t be undone.", "DELETE ACCOUNT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    string query = "DELETE FROM tblUser WHERE username LIKE '" + comboBoxDeleteUsername.Text + "'";
                    cm = new SqlCommand(query, cn);
                    cm.ExecuteNonQuery();
                    dr.Close();
                    cn.Close();

                    LoadUsernameDelete();
                    MessageBox.Show("Account " + comboBoxDeleteUsername.Text + " has been deleted.", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxDeleteUsername.Text = "";
                    comboBoxDeleteUsername.Focus();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidateOldPassword()
        {
            try
            {
                cn.Open();
                string query = "SELECT password FROM tblUser WHERE username LIKE '" + comboBoxUsername.Text + "'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    //oldPassword = dr["password"].ToString();
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

        public void UpdatePassword()
        {
            try
            {
                string oldPass = "";
                cn.Open();
                string query = "SELECT password FROM tblUser WHERE username LIKE '" + comboBoxUsername.Text + "'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    oldPass = dr["password"].ToString();
                }
                dr.Close();
                cn.Close();

                if (textBoxOldPassword.Text != oldPass)
                {
                    MessageBox.Show("Old password don't match.");
                    return;
                }

                if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
                {
                    MessageBox.Show("Please make sure your passwords match.", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                comboBoxUsername.Items.Clear();
                LoadUsername();
                cn.Open();
                string query1 = "UPDATE tblUser SET password = '" + textBoxNewPassword.Text + "' WHERE username LIKE '" + comboBoxUsername.Text + "'";
                cm = new SqlCommand(query1, cn);
                cm.ExecuteNonQuery();
                cn.Close();

                LoadUsername();
                MessageBox.Show("Password to " + comboBoxUsername.Text + " has been changed.", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBoxUsername.Text = "";
                textBoxOldPassword.Text = "";
                textBoxNewPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                comboBoxUsername.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBoxDeleteUsername.Text == "")
            {
                MessageBox.Show("Please select username", "ADD ITEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteUsername();
        }

        private void buttonSaveNewPassword_Click(object sender, EventArgs e)
        {

            if (textBoxConfirmPassword.Text == "" || textBoxNewPassword.Text == "" || textBoxOldPassword.Text == "" || comboBoxUsername.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "ADD ITEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdatePassword();

        }

        private void tabPageCreate_Click(object sender, EventArgs e)
        {

        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
