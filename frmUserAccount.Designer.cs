namespace OOP_System
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageCreate = new MetroFramework.Controls.MetroTabPage();
            this.tabPageChange = new MetroFramework.Controls.MetroTabPage();
            this.tabPageDelete = new MetroFramework.Controls.MetroTabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.tabPageChange.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1084, 647);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            this.metroTabControl1.Resize += new System.EventHandler(this.metroTabControl1_Resize);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1076, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREATE ACCOUNT";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.metroTabControl2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 597);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroTabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 647);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 42);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1034, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCOUNT";
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabPageCreate);
            this.metroTabControl2.Controls.Add(this.tabPageChange);
            this.metroTabControl2.Controls.Add(this.tabPageDelete);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(1076, 597);
            this.metroTabControl2.TabIndex = 13;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.btnCancel);
            this.tabPageCreate.Controls.Add(this.btnSave);
            this.tabPageCreate.Controls.Add(this.txtName);
            this.tabPageCreate.Controls.Add(this.label6);
            this.tabPageCreate.Controls.Add(this.cboRole);
            this.tabPageCreate.Controls.Add(this.label5);
            this.tabPageCreate.Controls.Add(this.txtRetype);
            this.tabPageCreate.Controls.Add(this.label4);
            this.tabPageCreate.Controls.Add(this.txtPass);
            this.tabPageCreate.Controls.Add(this.label3);
            this.tabPageCreate.Controls.Add(this.txtUser);
            this.tabPageCreate.Controls.Add(this.label2);
            this.tabPageCreate.HorizontalScrollbarBarColor = true;
            this.tabPageCreate.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageCreate.HorizontalScrollbarSize = 10;
            this.tabPageCreate.Location = new System.Drawing.Point(4, 38);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Size = new System.Drawing.Size(1068, 555);
            this.tabPageCreate.TabIndex = 0;
            this.tabPageCreate.Text = "CREATE ACCOUNT  ";
            this.tabPageCreate.VerticalScrollbarBarColor = true;
            this.tabPageCreate.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageCreate.VerticalScrollbarSize = 10;
            // 
            // tabPageChange
            // 
            this.tabPageChange.Controls.Add(this.comboBox3);
            this.tabPageChange.Controls.Add(this.button2);
            this.tabPageChange.Controls.Add(this.button3);
            this.tabPageChange.Controls.Add(this.textBox1);
            this.tabPageChange.Controls.Add(this.label7);
            this.tabPageChange.Controls.Add(this.comboBox1);
            this.tabPageChange.Controls.Add(this.label8);
            this.tabPageChange.Controls.Add(this.textBox2);
            this.tabPageChange.Controls.Add(this.label9);
            this.tabPageChange.Controls.Add(this.textBox3);
            this.tabPageChange.Controls.Add(this.label10);
            this.tabPageChange.Controls.Add(this.label11);
            this.tabPageChange.HorizontalScrollbarBarColor = true;
            this.tabPageChange.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageChange.HorizontalScrollbarSize = 10;
            this.tabPageChange.Location = new System.Drawing.Point(4, 38);
            this.tabPageChange.Name = "tabPageChange";
            this.tabPageChange.Size = new System.Drawing.Size(1068, 555);
            this.tabPageChange.TabIndex = 1;
            this.tabPageChange.Text = "  CHANGE PASSWORD  ";
            this.tabPageChange.VerticalScrollbarBarColor = true;
            this.tabPageChange.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageChange.VerticalScrollbarSize = 10;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.comboBox4);
            this.tabPageDelete.Controls.Add(this.button4);
            this.tabPageDelete.Controls.Add(this.button5);
            this.tabPageDelete.Controls.Add(this.textBox5);
            this.tabPageDelete.Controls.Add(this.label12);
            this.tabPageDelete.Controls.Add(this.comboBox2);
            this.tabPageDelete.Controls.Add(this.label13);
            this.tabPageDelete.Controls.Add(this.textBox6);
            this.tabPageDelete.Controls.Add(this.label14);
            this.tabPageDelete.Controls.Add(this.textBox7);
            this.tabPageDelete.Controls.Add(this.label15);
            this.tabPageDelete.Controls.Add(this.label16);
            this.tabPageDelete.HorizontalScrollbarBarColor = true;
            this.tabPageDelete.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageDelete.HorizontalScrollbarSize = 10;
            this.tabPageDelete.Location = new System.Drawing.Point(4, 38);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(1068, 555);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "  DELETE ACCOUNT  ";
            this.tabPageDelete.VerticalScrollbarBarColor = true;
            this.tabPageDelete.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageDelete.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(775, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 49);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(627, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 49);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(344, 306);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(563, 31);
            this.txtName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name:";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.cboRole.Location = new System.Drawing.Point(344, 249);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(563, 33);
            this.cboRole.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "User Type:";
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(344, 194);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.PasswordChar = '•';
            this.txtRetype.Size = new System.Drawing.Size(563, 31);
            this.txtRetype.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(344, 139);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(563, 31);
            this.txtPass.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(344, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(563, 31);
            this.txtUser.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(775, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 49);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(627, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(563, 31);
            this.textBox1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(99, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBox1.Location = new System.Drawing.Point(344, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(563, 33);
            this.comboBox1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(99, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "User Type:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(563, 31);
            this.textBox2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(99, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Confirm Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(344, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '•';
            this.textBox3.Size = new System.Drawing.Size(563, 31);
            this.textBox3.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(99, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(99, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Username:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(775, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 49);
            this.button4.TabIndex = 24;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(627, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 49);
            this.button5.TabIndex = 23;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(344, 306);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(563, 31);
            this.textBox5.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(99, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Name:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBox2.Location = new System.Drawing.Point(344, 249);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(563, 33);
            this.comboBox2.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(99, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "User Type:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(344, 194);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '•';
            this.textBox6.Size = new System.Drawing.Size(563, 31);
            this.textBox6.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(99, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Confirm Password:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(344, 139);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '•';
            this.textBox7.Size = new System.Drawing.Size(563, 31);
            this.textBox7.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(99, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Password:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(99, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 25);
            this.label16.TabIndex = 13;
            this.label16.Text = "Username:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBox3.Location = new System.Drawing.Point(344, 85);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(563, 33);
            this.comboBox3.TabIndex = 25;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBox4.Location = new System.Drawing.Point(344, 85);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(563, 33);
            this.comboBox4.TabIndex = 25;
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserAccount";
            this.Text = "frmUserAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmUserAccount_Resize);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl2.ResumeLayout(false);
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.tabPageChange.ResumeLayout(false);
            this.tabPageChange.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabPageCreate;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage tabPageChange;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTabPage tabPageDelete;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}