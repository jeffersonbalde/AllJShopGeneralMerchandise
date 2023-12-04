namespace OOP_System
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTransno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVatable = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.colAdd,
            this.colRemove,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 334);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView12_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 38;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "PCode";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DESCRIPTION";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "PRICE";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 67;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "QTY";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 54;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "DISCOUNT";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 93;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "TOTAL";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 68;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdd.HeaderText = "";
            this.colAdd.MinimumWidth = 6;
            this.colAdd.Name = "colAdd";
            this.colAdd.Width = 6;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "";
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 6;
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.lblDisplayTotal.Location = new System.Drawing.Point(525, 539);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(108, 53);
            this.lblDisplayTotal.TabIndex = 0;
            this.lblDisplayTotal.Text = "0.00";
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplayTotal.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(200, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "000000000000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "TRANSACTION DATE";
            // 
            // lblTransno
            // 
            this.lblTransno.AutoSize = true;
            this.lblTransno.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblTransno.Location = new System.Drawing.Point(200, 120);
            this.lblTransno.Name = "lblTransno";
            this.lblTransno.Size = new System.Drawing.Size(129, 19);
            this.lblTransno.TabIndex = 1;
            this.lblTransno.Text = "000000000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "TRANSACTION NO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblVatable
            // 
            this.lblVatable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatable.Location = new System.Drawing.Point(504, 677);
            this.lblVatable.Name = "lblVatable";
            this.lblVatable.Size = new System.Drawing.Size(103, 20);
            this.lblVatable.TabIndex = 7;
            this.lblVatable.Text = "0.00";
            this.lblVatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 678);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "VATABLE";
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(504, 642);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(103, 20);
            this.lblVat.TabIndex = 5;
            this.lblVat.Text = "0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 643);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "VAT";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(504, 608);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(103, 20);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscount.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 609);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "DISCOUNT";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(504, 573);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "TOTAL";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 29);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL J SHOP GENERAL MERCHANDISE";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(396, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(158, 41);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblDate1
            // 
            this.lblDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate1.AutoSize = true;
            this.lblDate1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate1.Location = new System.Drawing.Point(401, 52);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(71, 19);
            this.lblDate1.TabIndex = 9;
            this.lblDate1.Text = "00:00:00";
            this.lblDate1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(140, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(187, 22);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "Johannah Salado";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblVatable);
            this.panel2.Controls.Add(this.lblVat);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblTransno);
            this.panel2.Controls.Add(this.lblDisplayTotal);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 720);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.btnSale);
            this.panel3.Controls.Add(this.lblDate1);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.btnPayment);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Location = new System.Drawing.Point(653, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 236);
            this.panel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cashier";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 6;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox1.Icon")));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(1019, 35);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Scan Barcode";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(339, 31);
            this.metroTextBox1.TabIndex = 21;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Scan Barcode";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OOP_System.Properties.Resources.icons8_cashier_60_1;
            this.pictureBox4.Location = new System.Drawing.Point(71, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.Pink;
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.Black;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(252, 158);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(222, 52);
            this.btnSale.TabIndex = 10;
            this.btnSale.Text = "  [ F6 ] PRODUCT SALES";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.Enabled = false;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(252, 87);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(222, 52);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.Text = "  [ F3 ] ADD DISCOUNT";
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Enabled = false;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtQty.Icon = ((System.Drawing.Image)(resources.GetObject("txtQty.Icon")));
            this.txtQty.Lines = new string[] {
        "1"};
            this.txtQty.Location = new System.Drawing.Point(457, 21);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PromptText = "Qty";
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(97, 31);
            this.txtQty.TabIndex = 9;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.UseSelectable = true;
            this.txtQty.Visible = false;
            this.txtQty.WaterMark = "Qty";
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightGreen;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(489, 158);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(205, 52);
            this.button11.TabIndex = 15;
            this.button11.Text = "  [ F8 ] LOG OUT";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LightCoral;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Enabled = false;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(489, 87);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(205, 52);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "  [ F4 ] PAYMENT";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(222, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "  [ F5 ] CLEAR PRODUCT";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(12, 87);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(222, 52);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "  [ F1 ] NEW TRANSACTION";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(653, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "  [ F2 ] SEARCH PRODUCT";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, -38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1337, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(330, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Enabled = false;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(653, 35);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Scan Barcode";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(360, 31);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Scan Barcode";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPOS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public MetroFramework.Controls.MetroTextBox txtSearch;
        public System.Windows.Forms.Label lblTransno;
        private System.Windows.Forms.Label lblDisplayTotal;
        public System.Windows.Forms.Label lblVatable;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public MetroFramework.Controls.MetroTextBox metroTextBox1;
        public System.Windows.Forms.Button btnPayment;
        public System.Windows.Forms.Button btnDiscount;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button btnSale;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroTextBox txtQty;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}