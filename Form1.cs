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
using Tulpep.NotificationWindow;
using System.Drawing.Text;

namespace OOP_System
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        frmSecurity f;


        DBConnection dbcon = new DBConnection();
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            GetDashboard();
            NotifyCriticalItems();
            //cn.Open();
            //MessageBox.Show("Connected");

            //lblSales.Text = dbcon.GetSales().ToString("#,##0.00");
            //lblItems.Text = dbcon.GetItems().ToString("#,##0");
            //lblStocks.Text = dbcon.GetStocks().ToString("#,##0");
            //lblLowStocks.Text = dbcon.GetLowStocks().ToString("#,##0");

            this.KeyPreview = true;
        }

        public void GetDashboard()
        {
            lblSales.Text = dbcon.GetSales().ToString("#,##0.00");
            lblItems.Text = dbcon.GetItems().ToString("#,##0");
            lblStocks.Text = dbcon.GetStocks().ToString("#,##0");
            lblLowStocks.Text = dbcon.GetLowStocks().ToString("#,##0");
        }

        public void GetItems()
        {
            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblproduct";
                cm = new SqlCommand(query, cn);
                int items = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                lblItems.Text = items.ToString();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(@"C:\Users\jeffe\OneDrive\Documents\inter font\inter\inter-Regular.ttf");
            //foreach (Control c in this.Controls)
            //{
            //    c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            //}
        }

        public void NotifyCriticalItems()
        {
            string critical = "";
            int i = 0;

            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM vwCriticalItems", cn);
            string count = cm.ExecuteScalar().ToString();
            cn.Close();

            cn.Open();
            string query = "SELECT * FROM vwCriticalItems";
            cm = new SqlCommand(query, cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                critical += i + ". " +  dr["pdesc"].ToString() + Environment.NewLine;
            }
            dr.Close();
            cn.Close();

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.x;
            popup.TitleText = count + " LOW STOCK ITEMS";   
            popup.ContentText = critical;
            popup.Popup();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application? ", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmSecurity frm = new frmSecurity();
                frm.ShowDialog();
            }
        }

       



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //not in use brand
        private void button7_Click(object sender, EventArgs e)
        {
            frmBrandList frm = new frmBrandList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        //not in use category
        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList frm = new frmCategoryList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadCategory();
            frm.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmProductList frm = new frmProductList(this);
            //frm.comboBoxCategory.Text = "CATEGORY";
            frm.LoadCategory();
            frm.GetTotalItem();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadRecords();
            frm.Show();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmStockIn frm = new frmStockIn(this);
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //frmPOS frm = new frmPOS(this);
            //frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmUserAccount frm = new frmUserAccount();
            frm.LoadUsername();
            frm.LoadUsernameDelete();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmSoldItems frm = new frmSoldItems();
            frm.suser = lblName.Text;
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmRecords frm = new frmRecords();
            frm.TopLevel = false;
            frm.LoadRecord();
            frm.LoadChartTopItems();
            frm.LoadCriticalItems();
            frm.LoadInventory();
            frm.VoidItems();
            frm.LoadStockInHistory();
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            StockAdjust frm = new StockAdjust(this);
            frm.TopLevel = false;
            frm.LoadRecords();
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }


        //storename not in use
        private void StoreNameBtn_Click(object sender, EventArgs e)
        {
            StoreName storeName = new StoreName();
            storeName.LoadRecords();
            storeName.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }





        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button3_Click_2(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnStockIn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                button6_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnSalesHistory_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                button11_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                button3_Click_3(sender, e);
            }
            else if (e.KeyCode == Keys.Escape) {
                button1_Click(sender, e);
            }
        }

        private void lblLowStocks_Click(object sender, EventArgs e)
        {

        }

       

        public void CheckForUserType()
        {
            try
            {
                cn.Open();
                string query = "SELECT * FROM tblUser WHERE role LIKE 'System Administrator'";
                cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    //userType = dr["role"].ToString();
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

        private void button3_Click_3(object sender, EventArgs e)
        {
            try
            {
                frmPOS frm = new frmPOS(f);

                cn.Open();
                string query = "SELECT * FROM tblUser WHERE role LIKE 'System Administrator'";
                cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    frm.lblUserType.Text = dr["role"].ToString();
                }

                frm.lblUser.Text = lblName.Text;
                frm.ShowDialog();
                this.Dispose();
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
