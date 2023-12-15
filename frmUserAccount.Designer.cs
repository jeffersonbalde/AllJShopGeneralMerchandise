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
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageCreate = new MetroFramework.Controls.MetroTabPage();
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
            this.tabPageChange = new MetroFramework.Controls.MetroTabPage();
            this.comboBoxUsername = new System.Windows.Forms.ComboBox();
            this.buttonSaveNewPassword = new System.Windows.Forms.Button();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabPageDelete = new MetroFramework.Controls.MetroTabPage();
            this.comboBoxDeleteUsername = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.labelDeleteUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.tabPageChange.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabPageCreate);
            this.metroTabControl2.Controls.Add(this.tabPageChange);
            this.metroTabControl2.Controls.Add(this.tabPageDelete);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
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
            this.tabPageCreate.HorizontalScrollbarSize = 7;
            this.tabPageCreate.Location = new System.Drawing.Point(4, 38);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Size = new System.Drawing.Size(1068, 555);
            this.tabPageCreate.TabIndex = 0;
            this.tabPageCreate.Text = "CREATE ACCOUNT  ";
            this.tabPageCreate.VerticalScrollbarBarColor = true;
            this.tabPageCreate.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageCreate.VerticalScrollbarSize = 9;
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
            // tabPageChange
            // 
            this.tabPageChange.Controls.Add(this.comboBoxUsername);
            this.tabPageChange.Controls.Add(this.buttonSaveNewPassword);
            this.tabPageChange.Controls.Add(this.textBoxConfirmPassword);
            this.tabPageChange.Controls.Add(this.labelConfirmPassword);
            this.tabPageChange.Controls.Add(this.textBoxNewPassword);
            this.tabPageChange.Controls.Add(this.labelNewPassword);
            this.tabPageChange.Controls.Add(this.textBoxOldPassword);
            this.tabPageChange.Controls.Add(this.labelOldPassword);
            this.tabPageChange.Controls.Add(this.labelUsername);
            this.tabPageChange.HorizontalScrollbarBarColor = true;
            this.tabPageChange.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageChange.HorizontalScrollbarSize = 7;
            this.tabPageChange.Location = new System.Drawing.Point(4, 38);
            this.tabPageChange.Name = "tabPageChange";
            this.tabPageChange.Size = new System.Drawing.Size(1068, 555);
            this.tabPageChange.TabIndex = 1;
            this.tabPageChange.Text = "  CHANGE PASSWORD  ";
            this.tabPageChange.VerticalScrollbarBarColor = true;
            this.tabPageChange.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageChange.VerticalScrollbarSize = 9;
            // 
            // comboBoxUsername
            // 
            this.comboBoxUsername.FormattingEnabled = true;
            this.comboBoxUsername.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBoxUsername.Location = new System.Drawing.Point(344, 85);
            this.comboBoxUsername.Name = "comboBoxUsername";
            this.comboBoxUsername.Size = new System.Drawing.Size(563, 33);
            this.comboBoxUsername.TabIndex = 25;
            // 
            // buttonSaveNewPassword
            // 
            this.buttonSaveNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.buttonSaveNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveNewPassword.FlatAppearance.BorderSize = 0;
            this.buttonSaveNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNewPassword.ForeColor = System.Drawing.Color.White;
            this.buttonSaveNewPassword.Location = new System.Drawing.Point(775, 291);
            this.buttonSaveNewPassword.Name = "buttonSaveNewPassword";
            this.buttonSaveNewPassword.Size = new System.Drawing.Size(132, 49);
            this.buttonSaveNewPassword.TabIndex = 23;
            this.buttonSaveNewPassword.Text = "Save";
            this.buttonSaveNewPassword.UseVisualStyleBackColor = false;
            this.buttonSaveNewPassword.Click += new System.EventHandler(this.buttonSaveNewPassword_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(344, 243);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(563, 31);
            this.textBoxConfirmPassword.TabIndex = 22;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Location = new System.Drawing.Point(99, 247);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(162, 25);
            this.labelConfirmPassword.TabIndex = 21;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(344, 194);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '•';
            this.textBoxNewPassword.Size = new System.Drawing.Size(563, 31);
            this.textBoxNewPassword.TabIndex = 18;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.White;
            this.labelNewPassword.Location = new System.Drawing.Point(99, 198);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(133, 25);
            this.labelNewPassword.TabIndex = 17;
            this.labelNewPassword.Text = "New Password";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(344, 139);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '•';
            this.textBoxOldPassword.Size = new System.Drawing.Size(563, 31);
            this.textBoxOldPassword.TabIndex = 16;
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.BackColor = System.Drawing.Color.White;
            this.labelOldPassword.Location = new System.Drawing.Point(99, 145);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(125, 25);
            this.labelOldPassword.TabIndex = 15;
            this.labelOldPassword.Text = "Old Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(99, 93);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 25);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "Username:";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.comboBoxDeleteUsername);
            this.tabPageDelete.Controls.Add(this.button5);
            this.tabPageDelete.Controls.Add(this.labelDeleteUsername);
            this.tabPageDelete.HorizontalScrollbarBarColor = true;
            this.tabPageDelete.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageDelete.HorizontalScrollbarSize = 7;
            this.tabPageDelete.Location = new System.Drawing.Point(4, 38);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(1068, 555);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "  DELETE ACCOUNT  ";
            this.tabPageDelete.VerticalScrollbarBarColor = true;
            this.tabPageDelete.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageDelete.VerticalScrollbarSize = 9;
            // 
            // comboBoxDeleteUsername
            // 
            this.comboBoxDeleteUsername.FormattingEnabled = true;
            this.comboBoxDeleteUsername.Items.AddRange(new object[] {
            "System Administrator",
            "Cashier"});
            this.comboBoxDeleteUsername.Location = new System.Drawing.Point(344, 85);
            this.comboBoxDeleteUsername.Name = "comboBoxDeleteUsername";
            this.comboBoxDeleteUsername.Size = new System.Drawing.Size(563, 33);
            this.comboBoxDeleteUsername.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(775, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 49);
            this.button5.TabIndex = 23;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelDeleteUsername
            // 
            this.labelDeleteUsername.AutoSize = true;
            this.labelDeleteUsername.BackColor = System.Drawing.Color.White;
            this.labelDeleteUsername.Location = new System.Drawing.Point(99, 93);
            this.labelDeleteUsername.Name = "labelDeleteUsername";
            this.labelDeleteUsername.Size = new System.Drawing.Size(100, 25);
            this.labelDeleteUsername.TabIndex = 13;
            this.labelDeleteUsername.Text = "Username:";
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
            this.metroTabControl2.ResumeLayout(false);
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.tabPageChange.ResumeLayout(false);
            this.tabPageChange.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        public System.Windows.Forms.Button buttonSaveNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Label labelUsername;
        private MetroFramework.Controls.MetroTabPage tabPageDelete;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelDeleteUsername;
        private System.Windows.Forms.ComboBox comboBoxUsername;
        private System.Windows.Forms.ComboBox comboBoxDeleteUsername;
    }
}