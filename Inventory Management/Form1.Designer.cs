namespace Inventory_Management
{
    partial class Form1
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
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label user_typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkpassword = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admintab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stock_ManagementDataSet = new Inventory_Management.Stock_ManagementDataSet();
            this.btndeleteuser = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnshowuser = new System.Windows.Forms.Button();
            this.btnupdateuser = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.user_typeTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.usertab = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.usersTableAdapter = new Inventory_Management.Stock_ManagementDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Inventory_Management.Stock_ManagementDataSetTableAdapters.TableAdapterManager();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            user_idLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            user_typeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.admintab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.usertab.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            user_idLabel.ForeColor = System.Drawing.SystemColors.Window;
            user_idLabel.Location = new System.Drawing.Point(90, 76);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(108, 31);
            user_idLabel.TabIndex = 0;
            user_idLabel.Text = "User id:";
            user_idLabel.Click += new System.EventHandler(this.user_idLabel_Click);
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            user_nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            user_nameLabel.Location = new System.Drawing.Point(81, 170);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(154, 31);
            user_nameLabel.TabIndex = 2;
            user_nameLabel.Text = "User name:";
            user_nameLabel.Click += new System.EventHandler(this.user_nameLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            passwordLabel.ForeColor = System.Drawing.SystemColors.Window;
            passwordLabel.Location = new System.Drawing.Point(81, 252);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(142, 31);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // user_typeLabel
            // 
            user_typeLabel.AutoSize = true;
            user_typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            user_typeLabel.ForeColor = System.Drawing.SystemColors.Window;
            user_typeLabel.Location = new System.Drawing.Point(89, 350);
            user_typeLabel.Name = "user_typeLabel";
            user_typeLabel.Size = new System.Drawing.Size(139, 31);
            user_typeLabel.TabIndex = 6;
            user_typeLabel.Text = "User type:";
            user_typeLabel.Click += new System.EventHandler(this.user_typeLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.chkpassword);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 709);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkpassword
            // 
            this.chkpassword.AutoSize = true;
            this.chkpassword.Enabled = false;
            this.chkpassword.ForeColor = System.Drawing.Color.LavenderBlush;
            this.chkpassword.Location = new System.Drawing.Point(562, 423);
            this.chkpassword.Name = "chkpassword";
            this.chkpassword.Size = new System.Drawing.Size(192, 29);
            this.chkpassword.TabIndex = 7;
            this.chkpassword.Text = "show password";
            this.chkpassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkpassword.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnclear.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnclear.Location = new System.Drawing.Point(697, 493);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(187, 63);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnlogin.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnlogin.Location = new System.Drawing.Point(379, 493);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(193, 63);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(562, 339);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(271, 51);
            this.txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(562, 232);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(271, 49);
            this.txtusername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(79, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1165, 91);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(373, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(368, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // admintab
            // 
            this.admintab.Controls.Add(this.tabPage1);
            this.admintab.Controls.Add(this.tabPage2);
            this.admintab.Controls.Add(this.tabPage3);
            this.admintab.Controls.Add(this.tabPage4);
            this.admintab.Location = new System.Drawing.Point(3, -34);
            this.admintab.Name = "admintab";
            this.admintab.Padding = new System.Drawing.Point(25, 12);
            this.admintab.SelectedIndex = 0;
            this.admintab.Size = new System.Drawing.Size(1347, 795);
            this.admintab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btndeleteuser);
            this.tabPage1.Controls.Add(this.btnexit);
            this.tabPage1.Controls.Add(this.btnshowuser);
            this.tabPage1.Controls.Add(this.btnupdateuser);
            this.tabPage1.Controls.Add(this.btnadduser);
            this.tabPage1.Controls.Add(user_typeLabel);
            this.tabPage1.Controls.Add(this.user_typeTextBox);
            this.tabPage1.Controls.Add(passwordLabel);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(user_nameLabel);
            this.tabPage1.Controls.Add(this.user_nameTextBox);
            this.tabPage1.Controls.Add(user_idLabel);
            this.tabPage1.Controls.Add(this.user_idTextBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1331, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(87, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(889, 194);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "User_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "User_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User_name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 200;
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "user_type";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "user_type";
            this.usertypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            this.usertypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.stock_ManagementDataSet;
            // 
            // stock_ManagementDataSet
            // 
            this.stock_ManagementDataSet.DataSetName = "Stock_ManagementDataSet";
            this.stock_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.BackColor = System.Drawing.Color.Crimson;
            this.btndeleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btndeleteuser.ForeColor = System.Drawing.Color.Cornsilk;
            this.btndeleteuser.Location = new System.Drawing.Point(913, 350);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(221, 60);
            this.btndeleteuser.TabIndex = 12;
            this.btndeleteuser.Text = "Delete User";
            this.btndeleteuser.UseVisualStyleBackColor = false;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnexit.Location = new System.Drawing.Point(1252, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(79, 60);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnshowuser
            // 
            this.btnshowuser.BackColor = System.Drawing.Color.LightPink;
            this.btnshowuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnshowuser.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnshowuser.Location = new System.Drawing.Point(913, 252);
            this.btnshowuser.Name = "btnshowuser";
            this.btnshowuser.Size = new System.Drawing.Size(221, 60);
            this.btnshowuser.TabIndex = 10;
            this.btnshowuser.Text = "Show";
            this.btnshowuser.UseVisualStyleBackColor = false;
            // 
            // btnupdateuser
            // 
            this.btnupdateuser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnupdateuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnupdateuser.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnupdateuser.Location = new System.Drawing.Point(913, 147);
            this.btnupdateuser.Name = "btnupdateuser";
            this.btnupdateuser.Size = new System.Drawing.Size(221, 60);
            this.btnupdateuser.TabIndex = 9;
            this.btnupdateuser.Text = "Update";
            this.btnupdateuser.UseVisualStyleBackColor = false;
            this.btnupdateuser.Click += new System.EventHandler(this.btnupdateuser_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.LightBlue;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnadduser.Location = new System.Drawing.Point(913, 47);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(221, 60);
            this.btnadduser.TabIndex = 8;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // user_typeTextBox
            // 
            this.user_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_type", true));
            this.user_typeTextBox.Location = new System.Drawing.Point(323, 339);
            this.user_typeTextBox.Multiline = true;
            this.user_typeTextBox.Name = "user_typeTextBox";
            this.user_typeTextBox.Size = new System.Drawing.Size(275, 52);
            this.user_typeTextBox.TabIndex = 7;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.stock_ManagementDataSet;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(319, 249);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(275, 52);
            this.passwordTextBox.TabIndex = 5;
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "User_name", true));
            this.user_nameTextBox.Location = new System.Drawing.Point(319, 166);
            this.user_nameTextBox.Multiline = true;
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(275, 52);
            this.user_nameTextBox.TabIndex = 3;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "User_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(319, 76);
            this.user_idTextBox.Multiline = true;
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(275, 52);
            this.user_idTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(8, 55);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1331, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suplier";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage3.Location = new System.Drawing.Point(8, 55);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1331, 695);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Category";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage4.Location = new System.Drawing.Point(8, 55);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1331, 695);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transactions";
            // 
            // usertab
            // 
            this.usertab.Controls.Add(this.tabPage5);
            this.usertab.Controls.Add(this.tabPage6);
            this.usertab.Controls.Add(this.tabPage7);
            this.usertab.Location = new System.Drawing.Point(18, 82);
            this.usertab.Name = "usertab";
            this.usertab.Padding = new System.Drawing.Point(25, 10);
            this.usertab.SelectedIndex = 0;
            this.usertab.Size = new System.Drawing.Size(1336, 627);
            this.usertab.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.tabPage5.Controls.Add(this.admintab);
            this.tabPage5.Location = new System.Drawing.Point(8, 51);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1320, 568);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Suplier";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(160)))));
            this.tabPage6.Location = new System.Drawing.Point(8, 51);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1323, 707);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Category";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.tabPage7.Location = new System.Drawing.Point(8, 51);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1323, 707);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Transactions";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Stock_TransactionsTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inventory_Management.Stock_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersBindingNavigator.Size = new System.Drawing.Size(1388, 42);
            this.usersBindingNavigator.TabIndex = 3;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.usersBindingNavigatorSaveItem.Text = "Save Data";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 821);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usersBindingNavigator);
            this.Controls.Add(this.usertab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.admintab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.usertab.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkpassword;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TabControl admintab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl usertab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private Stock_ManagementDataSet stock_ManagementDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Stock_ManagementDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Stock_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox user_typeTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.Button btndeleteuser;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnshowuser;
        private System.Windows.Forms.Button btnupdateuser;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource1;
    }
}

