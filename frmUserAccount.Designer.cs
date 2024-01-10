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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageDelete = new MetroFramework.Controls.MetroTabPage();
            this.labelDeleteUsername = new System.Windows.Forms.Label();
            this.comboBoxDeleteUsername = new System.Windows.Forms.ComboBox();
            this.tabPageChange = new MetroFramework.Controls.MetroTabPage();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.comboBoxUsername = new System.Windows.Forms.ComboBox();
            this.tabPageCreate = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.tabPageChange.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroTabControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 647);
            this.panel3.TabIndex = 4;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabPageCreate);
            this.metroTabControl2.Controls.Add(this.tabPageChange);
            this.metroTabControl2.Controls.Add(this.tabPageDelete);
            this.metroTabControl2.Controls.Add(this.tabPage1);
            this.metroTabControl2.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl2.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl2.Location = new System.Drawing.Point(12, 16);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 3;
            this.metroTabControl2.Size = new System.Drawing.Size(1060, 614);
            this.metroTabControl2.TabIndex = 13;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.button6);
            this.tabPageDelete.Controls.Add(this.button5);
            this.tabPageDelete.Controls.Add(this.comboBoxDeleteUsername);
            this.tabPageDelete.Controls.Add(this.labelDeleteUsername);
            this.tabPageDelete.HorizontalScrollbarBarColor = true;
            this.tabPageDelete.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageDelete.HorizontalScrollbarSize = 3;
            this.tabPageDelete.Location = new System.Drawing.Point(4, 44);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(1052, 566);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "  DELETE ACCOUNT  ";
            this.tabPageDelete.VerticalScrollbarBarColor = true;
            this.tabPageDelete.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageDelete.VerticalScrollbarSize = 7;
            // 
            // labelDeleteUsername
            // 
            this.labelDeleteUsername.AutoSize = true;
            this.labelDeleteUsername.BackColor = System.Drawing.Color.White;
            this.labelDeleteUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.labelDeleteUsername.Location = new System.Drawing.Point(83, 65);
            this.labelDeleteUsername.Name = "labelDeleteUsername";
            this.labelDeleteUsername.Size = new System.Drawing.Size(148, 38);
            this.labelDeleteUsername.TabIndex = 13;
            this.labelDeleteUsername.Text = "Username:";
            // 
            // comboBoxDeleteUsername
            // 
            this.comboBoxDeleteUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.comboBoxDeleteUsername.FormattingEnabled = true;
            this.comboBoxDeleteUsername.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBoxDeleteUsername.Location = new System.Drawing.Point(306, 62);
            this.comboBoxDeleteUsername.Name = "comboBoxDeleteUsername";
            this.comboBoxDeleteUsername.Size = new System.Drawing.Size(563, 45);
            this.comboBoxDeleteUsername.TabIndex = 25;
            this.comboBoxDeleteUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDeleteUsername_KeyPress);
            // 
            // tabPageChange
            // 
            this.tabPageChange.Controls.Add(this.button4);
            this.tabPageChange.Controls.Add(this.button2);
            this.tabPageChange.Controls.Add(this.comboBoxUsername);
            this.tabPageChange.Controls.Add(this.textBoxConfirmPassword);
            this.tabPageChange.Controls.Add(this.labelConfirmPassword);
            this.tabPageChange.Controls.Add(this.textBoxNewPassword);
            this.tabPageChange.Controls.Add(this.labelNewPassword);
            this.tabPageChange.Controls.Add(this.textBoxOldPassword);
            this.tabPageChange.Controls.Add(this.labelOldPassword);
            this.tabPageChange.Controls.Add(this.labelUsername);
            this.tabPageChange.HorizontalScrollbarBarColor = true;
            this.tabPageChange.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageChange.HorizontalScrollbarSize = 3;
            this.tabPageChange.Location = new System.Drawing.Point(4, 44);
            this.tabPageChange.Name = "tabPageChange";
            this.tabPageChange.Size = new System.Drawing.Size(1052, 566);
            this.tabPageChange.TabIndex = 1;
            this.tabPageChange.Text = "  CHANGE PASSWORD  ";
            this.tabPageChange.VerticalScrollbarBarColor = true;
            this.tabPageChange.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageChange.VerticalScrollbarSize = 7;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.labelUsername.Location = new System.Drawing.Point(83, 65);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(148, 38);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "Username:";
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.BackColor = System.Drawing.Color.White;
            this.labelOldPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.labelOldPassword.Location = new System.Drawing.Point(83, 145);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(190, 38);
            this.labelOldPassword.TabIndex = 15;
            this.labelOldPassword.Text = "Old Password:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.textBoxOldPassword.Location = new System.Drawing.Point(369, 140);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '•';
            this.textBoxOldPassword.Size = new System.Drawing.Size(563, 43);
            this.textBoxOldPassword.TabIndex = 16;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.White;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.labelNewPassword.Location = new System.Drawing.Point(83, 231);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(202, 38);
            this.labelNewPassword.TabIndex = 17;
            this.labelNewPassword.Text = "New Password:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.textBoxNewPassword.Location = new System.Drawing.Point(369, 226);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '•';
            this.textBoxNewPassword.Size = new System.Drawing.Size(563, 43);
            this.textBoxNewPassword.TabIndex = 18;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(83, 324);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(245, 38);
            this.labelConfirmPassword.TabIndex = 21;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(369, 317);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(563, 43);
            this.textBoxConfirmPassword.TabIndex = 22;
            // 
            // comboBoxUsername
            // 
            this.comboBoxUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.comboBoxUsername.FormattingEnabled = true;
            this.comboBoxUsername.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBoxUsername.Location = new System.Drawing.Point(369, 58);
            this.comboBoxUsername.Name = "comboBoxUsername";
            this.comboBoxUsername.Size = new System.Drawing.Size(563, 45);
            this.comboBoxUsername.TabIndex = 25;
            this.comboBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUsername_KeyPress);
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.button1);
            this.tabPageCreate.Controls.Add(this.buttonClose);
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
            this.tabPageCreate.HorizontalScrollbarSize = 3;
            this.tabPageCreate.Location = new System.Drawing.Point(4, 38);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Size = new System.Drawing.Size(1052, 572);
            this.tabPageCreate.TabIndex = 0;
            this.tabPageCreate.Text = "CREATE ACCOUNT  ";
            this.tabPageCreate.VerticalScrollbarBarColor = true;
            this.tabPageCreate.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageCreate.VerticalScrollbarSize = 7;
            this.tabPageCreate.Click += new System.EventHandler(this.tabPageCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtUser.Location = new System.Drawing.Point(379, 56);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(563, 43);
            this.txtUser.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtPass.Location = new System.Drawing.Point(379, 133);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(563, 43);
            this.txtPass.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password:";
            // 
            // txtRetype
            // 
            this.txtRetype.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtRetype.Location = new System.Drawing.Point(379, 209);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.PasswordChar = '•';
            this.txtRetype.Size = new System.Drawing.Size(563, 43);
            this.txtRetype.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Account Type:";
            // 
            // cboRole
            // 
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cboRole.Location = new System.Drawing.Point(379, 288);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(563, 45);
            this.cboRole.TabIndex = 20;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            this.cboRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboRole_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 38);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtName.Location = new System.Drawing.Point(379, 369);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(563, 43);
            this.txtName.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(634, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 52);
            this.button1.TabIndex = 26;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(103)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(103)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(791, 433);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(151, 52);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "ESC - CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(624, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 52);
            this.button2.TabIndex = 27;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1052, 566);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "ACCOUNTS LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(30, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(986, 472);
            this.dataGridView1.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 51;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "NAME";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "USERNAME";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 132;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "PASSWORD";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 136;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "ACCOUNT TYPE";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 165;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(103)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(103)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(781, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 52);
            this.button4.TabIndex = 28;
            this.button4.Text = "ESC - CLOSE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(103)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(103)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(718, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 52);
            this.button5.TabIndex = 27;
            this.button5.Text = "ESC - CLOSE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(561, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 52);
            this.button6.TabIndex = 28;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 647);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserAccount";
            this.Text = "frmUserAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserAccount_KeyDown);
            this.Resize += new System.EventHandler(this.frmUserAccount_Resize);
            this.panel3.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.tabPageChange.ResumeLayout(false);
            this.tabPageChange.PerformLayout();
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabPageCreate;
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
        private System.Windows.Forms.ComboBox comboBoxUsername;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Label labelUsername;
        private MetroFramework.Controls.MetroTabPage tabPageDelete;
        private System.Windows.Forms.ComboBox comboBoxDeleteUsername;
        private System.Windows.Forms.Label labelDeleteUsername;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
    }
}