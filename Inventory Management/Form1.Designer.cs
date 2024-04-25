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
            System.Windows.Forms.Label supplier_idLabel;
            System.Windows.Forms.Label supplier_nameLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label category_nameLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label serialnumberLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label supplier_IDLabel1;
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.usertab = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.supplier_nameTextBox = new System.Windows.Forms.TextBox();
            this.supplier_idTextBox = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.category_nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplier_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.serialnumberTextBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new Inventory_Management.Stock_ManagementDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Inventory_Management.Stock_ManagementDataSetTableAdapters.TableAdapterManager();
            this.supplierTableAdapter = new Inventory_Management.Stock_ManagementDataSetTableAdapters.SupplierTableAdapter();
            this.categoryTableAdapter = new Inventory_Management.Stock_ManagementDataSetTableAdapters.CategoryTableAdapter();
            this.productTableAdapter = new Inventory_Management.Stock_ManagementDataSetTableAdapters.ProductTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            user_idLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            user_typeLabel = new System.Windows.Forms.Label();
            supplier_idLabel = new System.Windows.Forms.Label();
            supplier_nameLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            category_nameLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            serialnumberLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            supplier_IDLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.admintab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.usertab.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            user_idLabel.ForeColor = System.Drawing.SystemColors.Window;
            user_idLabel.Location = new System.Drawing.Point(68, 61);
            user_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(79, 25);
            user_idLabel.TabIndex = 0;
            user_idLabel.Text = "User id:";
            user_idLabel.Click += new System.EventHandler(this.user_idLabel_Click);
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            user_nameLabel.ForeColor = System.Drawing.SystemColors.Window;
            user_nameLabel.Location = new System.Drawing.Point(61, 136);
            user_nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(113, 25);
            user_nameLabel.TabIndex = 2;
            user_nameLabel.Text = "User name:";
            user_nameLabel.Click += new System.EventHandler(this.user_nameLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            passwordLabel.ForeColor = System.Drawing.SystemColors.Window;
            passwordLabel.Location = new System.Drawing.Point(61, 202);
            passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(104, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // user_typeLabel
            // 
            user_typeLabel.AutoSize = true;
            user_typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            user_typeLabel.ForeColor = System.Drawing.SystemColors.Window;
            user_typeLabel.Location = new System.Drawing.Point(67, 280);
            user_typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            user_typeLabel.Name = "user_typeLabel";
            user_typeLabel.Size = new System.Drawing.Size(101, 25);
            user_typeLabel.TabIndex = 6;
            user_typeLabel.Text = "User type:";
            user_typeLabel.Click += new System.EventHandler(this.user_typeLabel_Click);
            // 
            // supplier_idLabel
            // 
            supplier_idLabel.AutoSize = true;
            supplier_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            supplier_idLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            supplier_idLabel.Location = new System.Drawing.Point(35, 35);
            supplier_idLabel.Name = "supplier_idLabel";
            supplier_idLabel.Size = new System.Drawing.Size(110, 25);
            supplier_idLabel.TabIndex = 0;
            supplier_idLabel.Text = "Supplier id:";
            // 
            // supplier_nameLabel
            // 
            supplier_nameLabel.AutoSize = true;
            supplier_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            supplier_nameLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            supplier_nameLabel.Location = new System.Drawing.Point(273, 35);
            supplier_nameLabel.Name = "supplier_nameLabel";
            supplier_nameLabel.Size = new System.Drawing.Size(144, 25);
            supplier_nameLabel.TabIndex = 2;
            supplier_nameLabel.Text = "Supplier name:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            adressLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            adressLabel.Location = new System.Drawing.Point(545, 35);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(80, 25);
            adressLabel.TabIndex = 4;
            adressLabel.Text = "Adress:";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            category_idLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            category_idLabel.Location = new System.Drawing.Point(74, 94);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(118, 25);
            category_idLabel.TabIndex = 18;
            category_idLabel.Text = "Category id:";
            // 
            // category_nameLabel
            // 
            category_nameLabel.AutoSize = true;
            category_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            category_nameLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            category_nameLabel.Location = new System.Drawing.Point(74, 195);
            category_nameLabel.Name = "category_nameLabel";
            category_nameLabel.Size = new System.Drawing.Size(152, 25);
            category_nameLabel.TabIndex = 19;
            category_nameLabel.Text = "Category name:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            product_idLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            product_idLabel.Location = new System.Drawing.Point(58, 68);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(105, 25);
            product_idLabel.TabIndex = 0;
            product_idLabel.Text = "Product id:";
            product_idLabel.Click += new System.EventHandler(this.product_idLabel_Click);
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            product_nameLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            product_nameLabel.Location = new System.Drawing.Point(244, 68);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(139, 25);
            product_nameLabel.TabIndex = 2;
            product_nameLabel.Text = "Product name:";
            // 
            // serialnumberLabel
            // 
            serialnumberLabel.AutoSize = true;
            serialnumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            serialnumberLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            serialnumberLabel.Location = new System.Drawing.Point(453, 68);
            serialnumberLabel.Name = "serialnumberLabel";
            serialnumberLabel.Size = new System.Drawing.Size(134, 25);
            serialnumberLabel.TabIndex = 6;
            serialnumberLabel.Text = "Serialnumber:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            quantityLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            quantityLabel.Location = new System.Drawing.Point(688, 68);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(91, 25);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // supplier_IDLabel1
            // 
            supplier_IDLabel1.AutoSize = true;
            supplier_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            supplier_IDLabel1.ForeColor = System.Drawing.Color.LavenderBlush;
            supplier_IDLabel1.Location = new System.Drawing.Point(48, 180);
            supplier_IDLabel1.Name = "supplier_IDLabel1";
            supplier_IDLabel1.Size = new System.Drawing.Size(114, 25);
            supplier_IDLabel1.TabIndex = 10;
            supplier_IDLabel1.Text = "Supplier ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.chkpassword);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1166, 608);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkpassword
            // 
            this.chkpassword.AutoSize = true;
            this.chkpassword.Enabled = false;
            this.chkpassword.ForeColor = System.Drawing.Color.LavenderBlush;
            this.chkpassword.Location = new System.Drawing.Point(525, 360);
            this.chkpassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkpassword.Name = "chkpassword";
            this.chkpassword.Size = new System.Drawing.Size(144, 24);
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
            this.btnclear.Location = new System.Drawing.Point(626, 416);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 50);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnlogin.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnlogin.Location = new System.Drawing.Point(387, 416);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(145, 50);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(525, 293);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(204, 42);
            this.txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(525, 208);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(204, 40);
            this.txtusername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(184, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(883, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Management System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(383, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(379, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // admintab
            // 
            this.admintab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admintab.Controls.Add(this.tabPage2);
            this.admintab.Controls.Add(this.tabPage4);
            this.admintab.Controls.Add(this.tabPage1);
            this.admintab.Controls.Add(this.tabPage3);
            this.admintab.Location = new System.Drawing.Point(0, 29);
            this.admintab.Margin = new System.Windows.Forms.Padding(2);
            this.admintab.Name = "admintab";
            this.admintab.Padding = new System.Drawing.Point(25, 12);
            this.admintab.SelectedIndex = 0;
            this.admintab.Size = new System.Drawing.Size(1201, 586);
            this.admintab.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1123, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suplier";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage4.Location = new System.Drawing.Point(4, 47);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1028, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transactions";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.button6);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1193, 535);
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
            this.dataGridView1.Location = new System.Drawing.Point(31, 350);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(923, 155);
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
            this.btndeleteuser.Location = new System.Drawing.Point(788, 78);
            this.btndeleteuser.Margin = new System.Windows.Forms.Padding(2);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(166, 48);
            this.btndeleteuser.TabIndex = 12;
            this.btndeleteuser.Text = "Delete User";
            this.btndeleteuser.UseVisualStyleBackColor = false;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnexit.Location = new System.Drawing.Point(955, 0);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(74, 50);
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
            this.btnshowuser.Location = new System.Drawing.Point(588, 271);
            this.btnshowuser.Margin = new System.Windows.Forms.Padding(2);
            this.btnshowuser.Name = "btnshowuser";
            this.btnshowuser.Size = new System.Drawing.Size(166, 48);
            this.btnshowuser.TabIndex = 10;
            this.btnshowuser.Text = "Search";
            this.btnshowuser.UseVisualStyleBackColor = false;
            this.btnshowuser.Click += new System.EventHandler(this.btnshowuser_Click_1);
            // 
            // btnupdateuser
            // 
            this.btnupdateuser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnupdateuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnupdateuser.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnupdateuser.Location = new System.Drawing.Point(588, 179);
            this.btnupdateuser.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdateuser.Name = "btnupdateuser";
            this.btnupdateuser.Size = new System.Drawing.Size(166, 48);
            this.btnupdateuser.TabIndex = 9;
            this.btnupdateuser.Text = "Update";
            this.btnupdateuser.UseVisualStyleBackColor = false;
            this.btnupdateuser.Click += new System.EventHandler(this.btnupdateuser_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.LightBlue;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnadduser.Location = new System.Drawing.Point(588, 78);
            this.btnadduser.Margin = new System.Windows.Forms.Padding(2);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(166, 48);
            this.btnadduser.TabIndex = 8;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // user_typeTextBox
            // 
            this.user_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_type", true));
            this.user_typeTextBox.Location = new System.Drawing.Point(242, 271);
            this.user_typeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.user_typeTextBox.Multiline = true;
            this.user_typeTextBox.Name = "user_typeTextBox";
            this.user_typeTextBox.Size = new System.Drawing.Size(207, 42);
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
            this.passwordTextBox.Location = new System.Drawing.Point(239, 199);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(207, 42);
            this.passwordTextBox.TabIndex = 5;
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "User_name", true));
            this.user_nameTextBox.Location = new System.Drawing.Point(239, 133);
            this.user_nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.user_nameTextBox.Multiline = true;
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(207, 42);
            this.user_nameTextBox.TabIndex = 3;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "User_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(239, 61);
            this.user_idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.user_idTextBox.Multiline = true;
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(207, 42);
            this.user_idTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 47);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1111, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Category";
            // 
            // usertab
            // 
            this.usertab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usertab.Controls.Add(this.tabPage5);
            this.usertab.Controls.Add(this.tabPage6);
            this.usertab.Controls.Add(this.tabPage7);
            this.usertab.Controls.Add(this.tabPage8);
            this.usertab.Location = new System.Drawing.Point(6, 24);
            this.usertab.Margin = new System.Windows.Forms.Padding(2);
            this.usertab.Name = "usertab";
            this.usertab.Padding = new System.Drawing.Point(25, 10);
            this.usertab.SelectedIndex = 0;
            this.usertab.Size = new System.Drawing.Size(1195, 639);
            this.usertab.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Controls.Add(adressLabel);
            this.tabPage5.Controls.Add(this.adressTextBox);
            this.tabPage5.Controls.Add(supplier_nameLabel);
            this.tabPage5.Controls.Add(this.supplier_nameTextBox);
            this.tabPage5.Controls.Add(supplier_idLabel);
            this.tabPage5.Controls.Add(this.supplier_idTextBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 43);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1187, 592);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Suplier";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.supplierBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(40, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 80;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(899, 247);
            this.dataGridView2.TabIndex = 8;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "Supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "Supplier_id";
            this.supplieridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplieridDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.stock_ManagementDataSet;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.stock_ManagementDataSet;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(550, 68);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(163, 36);
            this.adressTextBox.TabIndex = 5;
            // 
            // supplier_nameTextBox
            // 
            this.supplier_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Supplier_name", true));
            this.supplier_nameTextBox.Location = new System.Drawing.Point(275, 71);
            this.supplier_nameTextBox.Multiline = true;
            this.supplier_nameTextBox.Name = "supplier_nameTextBox";
            this.supplier_nameTextBox.Size = new System.Drawing.Size(190, 33);
            this.supplier_nameTextBox.TabIndex = 3;
            // 
            // supplier_idTextBox
            // 
            this.supplier_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Supplier_id", true));
            this.supplier_idTextBox.Location = new System.Drawing.Point(40, 69);
            this.supplier_idTextBox.Multiline = true;
            this.supplier_idTextBox.Name = "supplier_idTextBox";
            this.supplier_idTextBox.Size = new System.Drawing.Size(171, 35);
            this.supplier_idTextBox.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(160)))));
            this.tabPage6.Controls.Add(this.button8);
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(category_nameLabel);
            this.tabPage6.Controls.Add(this.category_nameTextBox);
            this.tabPage6.Controls.Add(category_idLabel);
            this.tabPage6.Controls.Add(this.category_idTextBox);
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Location = new System.Drawing.Point(4, 43);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(1187, 592);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 52);
            this.button2.TabIndex = 21;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // category_nameTextBox
            // 
            this.category_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Category_name", true));
            this.category_nameTextBox.Location = new System.Drawing.Point(79, 236);
            this.category_nameTextBox.Multiline = true;
            this.category_nameTextBox.Name = "category_nameTextBox";
            this.category_nameTextBox.Size = new System.Drawing.Size(199, 40);
            this.category_nameTextBox.TabIndex = 20;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.stock_ManagementDataSet;
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(79, 134);
            this.category_idTextBox.Multiline = true;
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(199, 40);
            this.category_idTextBox.TabIndex = 19;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryidDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.categoryBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(431, 94);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 80;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(569, 313);
            this.dataGridView3.TabIndex = 18;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "Category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryidDataGridViewTextBoxColumn.Width = 150;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "Category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category_name";
            this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.tabPage7.Location = new System.Drawing.Point(4, 43);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(1154, 561);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Transactions";
            // 
            // tabPage8
            // 
            this.tabPage8.AutoScroll = true;
            this.tabPage8.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tabPage8.Controls.Add(this.button4);
            this.tabPage8.Controls.Add(this.button3);
            this.tabPage8.Controls.Add(this.productDataGridView);
            this.tabPage8.Controls.Add(supplier_IDLabel1);
            this.tabPage8.Controls.Add(this.supplier_IDTextBox1);
            this.tabPage8.Controls.Add(quantityLabel);
            this.tabPage8.Controls.Add(this.quantityTextBox);
            this.tabPage8.Controls.Add(serialnumberLabel);
            this.tabPage8.Controls.Add(this.serialnumberTextBox);
            this.tabPage8.Controls.Add(product_nameLabel);
            this.tabPage8.Controls.Add(this.product_nameTextBox);
            this.tabPage8.Controls.Add(product_idLabel);
            this.tabPage8.Controls.Add(this.product_idTextBox);
            this.tabPage8.Location = new System.Drawing.Point(4, 43);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1187, 592);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Product";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(619, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Show All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(15, 289);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.Size = new System.Drawing.Size(1136, 220);
            this.productDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Serialnumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serialnumber";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Category_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Category_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Supplier_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Supplier_ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.stock_ManagementDataSet;
            // 
            // supplier_IDTextBox1
            // 
            this.supplier_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Supplier_ID", true));
            this.supplier_IDTextBox1.Location = new System.Drawing.Point(53, 217);
            this.supplier_IDTextBox1.Multiline = true;
            this.supplier_IDTextBox1.Name = "supplier_IDTextBox1";
            this.supplier_IDTextBox1.Size = new System.Drawing.Size(163, 39);
            this.supplier_IDTextBox1.TabIndex = 11;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(693, 110);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(155, 36);
            this.quantityTextBox.TabIndex = 9;
            // 
            // serialnumberTextBox
            // 
            this.serialnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Serialnumber", true));
            this.serialnumberTextBox.Location = new System.Drawing.Point(458, 110);
            this.serialnumberTextBox.Multiline = true;
            this.serialnumberTextBox.Name = "serialnumberTextBox";
            this.serialnumberTextBox.Size = new System.Drawing.Size(160, 34);
            this.serialnumberTextBox.TabIndex = 7;
            this.serialnumberTextBox.TextChanged += new System.EventHandler(this.serialnumberTextBox_TextChanged);
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(249, 110);
            this.product_nameTextBox.Multiline = true;
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(165, 36);
            this.product_nameTextBox.TabIndex = 3;
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(53, 110);
            this.product_idTextBox.Multiline = true;
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(163, 36);
            this.product_idTextBox.TabIndex = 1;
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
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(788, 179);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 48);
            this.button6.TabIndex = 14;
            this.button6.Text = "Display All";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button7.Location = new System.Drawing.Point(286, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 49);
            this.button7.TabIndex = 10;
            this.button7.Text = "Show All";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(77, 402);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(199, 54);
            this.button8.TabIndex = 22;
            this.button8.Text = "Show All";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.usertab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.admintab);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Stock_ManagementDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.TextBox supplier_nameTextBox;
        private System.Windows.Forms.TextBox supplier_idTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Stock_ManagementDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox category_nameTextBox;
        private System.Windows.Forms.TextBox category_idTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Stock_ManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox serialnumberTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox supplier_IDTextBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

