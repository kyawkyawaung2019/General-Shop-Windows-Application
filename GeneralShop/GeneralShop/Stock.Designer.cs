namespace GeneralShop
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tpStock = new System.Windows.Forms.TabControl();
            this.tpProductRegistration = new System.Windows.Forms.TabPage();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cboProductGroup = new System.Windows.Forms.ComboBox();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.txtProductGroup_M = new System.Windows.Forms.TextBox();
            this.txtProductType_M = new System.Windows.Forms.TextBox();
            this.txtProductName_M = new System.Windows.Forms.TextBox();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.txtProductGroup_E = new System.Windows.Forms.TextBox();
            this.txtProductType_E = new System.Windows.Forms.TextBox();
            this.txtProductName_E = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.tpStockInfo = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tpStock.SuspendLayout();
            this.tpProductRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.gbRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Orchid;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lblStaffName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.cboLanguage);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.monthCalendar1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 25);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1219, 181);
            this.panelTop.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(248, 135);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 36);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "DATE";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(643, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(564, 111);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "12:00:01 AM";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Thistle;
            this.btnLogout.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(643, 139);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(724, 142);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(87, 25);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Staff Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(991, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Language : ";
            // 
            // cboLanguage
            // 
            this.cboLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Myanmar"});
            this.cboLanguage.Location = new System.Drawing.Point(1087, 142);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(121, 25);
            this.cboLanguage.TabIndex = 2;
            this.cboLanguage.TabStop = false;
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(248, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 75);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "STOCK";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 685);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1219, 50);
            this.panelBottom.TabIndex = 2;
            // 
            // tpStock
            // 
            this.tpStock.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tpStock.Controls.Add(this.tpProductRegistration);
            this.tpStock.Controls.Add(this.tpStockInfo);
            this.tpStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpStock.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpStock.Location = new System.Drawing.Point(0, 206);
            this.tpStock.Name = "tpStock";
            this.tpStock.SelectedIndex = 0;
            this.tpStock.Size = new System.Drawing.Size(1219, 479);
            this.tpStock.TabIndex = 3;
            // 
            // tpProductRegistration
            // 
            this.tpProductRegistration.Controls.Add(this.pbLock);
            this.tpProductRegistration.Controls.Add(this.lblGroup);
            this.tpProductRegistration.Controls.Add(this.lblType);
            this.tpProductRegistration.Controls.Add(this.lblName);
            this.tpProductRegistration.Controls.Add(this.cboProductGroup);
            this.tpProductRegistration.Controls.Add(this.cboProductType);
            this.tpProductRegistration.Controls.Add(this.cboProductName);
            this.tpProductRegistration.Controls.Add(this.gbRegistration);
            this.tpProductRegistration.Controls.Add(this.dgvProductList);
            this.tpProductRegistration.Location = new System.Drawing.Point(4, 37);
            this.tpProductRegistration.Name = "tpProductRegistration";
            this.tpProductRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductRegistration.Size = new System.Drawing.Size(1211, 438);
            this.tpProductRegistration.TabIndex = 1;
            this.tpProductRegistration.Text = "Product Registration";
            this.tpProductRegistration.UseVisualStyleBackColor = true;
            // 
            // pbLock
            // 
            this.pbLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLock.Image = global::GeneralShop.Properties.Resources.Stock;
            this.pbLock.Location = new System.Drawing.Point(537, 259);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(104, 105);
            this.pbLock.TabIndex = 8;
            this.pbLock.TabStop = false;
            this.pbLock.Click += new System.EventHandler(this.pbLock_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(10, 161);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(66, 25);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Group : ";
            this.lblGroup.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(329, 161);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(61, 25);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type : ";
            this.lblType.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(645, 161);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name : ";
            this.lblName.Visible = false;
            // 
            // cboProductGroup
            // 
            this.cboProductGroup.DropDownHeight = 240;
            this.cboProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductGroup.FormattingEnabled = true;
            this.cboProductGroup.IntegralHeight = false;
            this.cboProductGroup.Items.AddRange(new object[] {
            "ALL"});
            this.cboProductGroup.Location = new System.Drawing.Point(82, 158);
            this.cboProductGroup.Name = "cboProductGroup";
            this.cboProductGroup.Size = new System.Drawing.Size(245, 33);
            this.cboProductGroup.TabIndex = 4;
            this.cboProductGroup.TabStop = false;
            this.cboProductGroup.Visible = false;
            this.cboProductGroup.SelectedIndexChanged += new System.EventHandler(this.cboProductGroup_SelectedIndexChanged);
            // 
            // cboProductType
            // 
            this.cboProductType.DropDownHeight = 240;
            this.cboProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.IntegralHeight = false;
            this.cboProductType.Items.AddRange(new object[] {
            "ALL"});
            this.cboProductType.Location = new System.Drawing.Point(396, 158);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(245, 33);
            this.cboProductType.TabIndex = 3;
            this.cboProductType.TabStop = false;
            this.cboProductType.Visible = false;
            this.cboProductType.SelectedIndexChanged += new System.EventHandler(this.cboProductType_SelectedIndexChanged);
            // 
            // cboProductName
            // 
            this.cboProductName.DropDownHeight = 240;
            this.cboProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.IntegralHeight = false;
            this.cboProductName.Items.AddRange(new object[] {
            "ALL"});
            this.cboProductName.Location = new System.Drawing.Point(717, 158);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(245, 33);
            this.cboProductName.TabIndex = 2;
            this.cboProductName.TabStop = false;
            this.cboProductName.Visible = false;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // gbRegistration
            // 
            this.gbRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbRegistration.Controls.Add(this.lblRate);
            this.gbRegistration.Controls.Add(this.txtRate);
            this.gbRegistration.Controls.Add(this.btnRegister);
            this.gbRegistration.Controls.Add(this.lblLocationID);
            this.gbRegistration.Controls.Add(this.lblProductGroup);
            this.gbRegistration.Controls.Add(this.lblProductType);
            this.gbRegistration.Controls.Add(this.lblProductName);
            this.gbRegistration.Controls.Add(this.lblProductID);
            this.gbRegistration.Controls.Add(this.tt);
            this.gbRegistration.Controls.Add(this.txtProductGroup_M);
            this.gbRegistration.Controls.Add(this.txtProductType_M);
            this.gbRegistration.Controls.Add(this.txtProductName_M);
            this.gbRegistration.Controls.Add(this.txtLocationID);
            this.gbRegistration.Controls.Add(this.txtProductGroup_E);
            this.gbRegistration.Controls.Add(this.txtProductType_E);
            this.gbRegistration.Controls.Add(this.txtProductName_E);
            this.gbRegistration.Controls.Add(this.txtProductID);
            this.gbRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRegistration.Location = new System.Drawing.Point(3, 3);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(1205, 149);
            this.gbRegistration.TabIndex = 1;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Registration";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(934, 104);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(57, 25);
            this.lblRate.TabIndex = 17;
            this.lblRate.Text = "Rate : ";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(999, 96);
            this.txtRate.Name = "txtRate";
            this.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRate.Size = new System.Drawing.Size(78, 32);
            this.txtRate.TabIndex = 5;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.GreenYellow;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegister.Location = new System.Drawing.Point(1102, 28);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 118);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(895, 66);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(96, 25);
            this.lblLocationID.TabIndex = 14;
            this.lblLocationID.Text = "LocationID : ";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.Location = new System.Drawing.Point(634, 28);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(100, 25);
            this.lblProductGroup.TabIndex = 13;
            this.lblProductGroup.Text = "ProductGroup";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(378, 28);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(100, 25);
            this.lblProductType.TabIndex = 12;
            this.lblProductType.Text = "Product Type";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(123, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(105, 25);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(6, 28);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(77, 25);
            this.lblProductID.TabIndex = 10;
            this.lblProductID.Text = "ProductID";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Location = new System.Drawing.Point(6, 103);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(114, 25);
            this.tt.TabIndex = 9;
            this.tt.Text = "ျမန္မာဘာသာျဖင့္";
            // 
            // txtProductGroup_M
            // 
            this.txtProductGroup_M.Location = new System.Drawing.Point(639, 100);
            this.txtProductGroup_M.Name = "txtProductGroup_M";
            this.txtProductGroup_M.Size = new System.Drawing.Size(250, 32);
            this.txtProductGroup_M.TabIndex = 8;
            // 
            // txtProductType_M
            // 
            this.txtProductType_M.Location = new System.Drawing.Point(383, 100);
            this.txtProductType_M.Name = "txtProductType_M";
            this.txtProductType_M.Size = new System.Drawing.Size(250, 32);
            this.txtProductType_M.TabIndex = 7;
            // 
            // txtProductName_M
            // 
            this.txtProductName_M.Location = new System.Drawing.Point(128, 100);
            this.txtProductName_M.Name = "txtProductName_M";
            this.txtProductName_M.Size = new System.Drawing.Size(250, 32);
            this.txtProductName_M.TabIndex = 6;
            // 
            // txtLocationID
            // 
            this.txtLocationID.Location = new System.Drawing.Point(999, 62);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.ReadOnly = true;
            this.txtLocationID.Size = new System.Drawing.Size(78, 32);
            this.txtLocationID.TabIndex = 4;
            this.txtLocationID.TabStop = false;
            this.txtLocationID.Text = "0000";
            // 
            // txtProductGroup_E
            // 
            this.txtProductGroup_E.Location = new System.Drawing.Point(639, 62);
            this.txtProductGroup_E.Name = "txtProductGroup_E";
            this.txtProductGroup_E.Size = new System.Drawing.Size(250, 32);
            this.txtProductGroup_E.TabIndex = 3;
            // 
            // txtProductType_E
            // 
            this.txtProductType_E.Location = new System.Drawing.Point(383, 62);
            this.txtProductType_E.Name = "txtProductType_E";
            this.txtProductType_E.Size = new System.Drawing.Size(250, 32);
            this.txtProductType_E.TabIndex = 2;
            // 
            // txtProductName_E
            // 
            this.txtProductName_E.Location = new System.Drawing.Point(128, 62);
            this.txtProductName_E.Name = "txtProductName_E";
            this.txtProductName_E.Size = new System.Drawing.Size(250, 32);
            this.txtProductName_E.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(6, 62);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(116, 32);
            this.txtProductID.TabIndex = 0;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductList.Location = new System.Drawing.Point(3, 193);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(1205, 242);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.TabStop = false;
            this.dgvProductList.Visible = false;
            // 
            // tpStockInfo
            // 
            this.tpStockInfo.Location = new System.Drawing.Point(4, 37);
            this.tpStockInfo.Name = "tpStockInfo";
            this.tpStockInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpStockInfo.Size = new System.Drawing.Size(1211, 438);
            this.tpStockInfo.TabIndex = 0;
            this.tpStockInfo.Text = "Stock Information";
            this.tpStockInfo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 735);
            this.Controls.Add(this.tpStock);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK INFORMATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tpStock.ResumeLayout(false);
            this.tpProductRegistration.ResumeLayout(false);
            this.tpProductRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tpStock;
        private System.Windows.Forms.TabPage tpStockInfo;
        private System.Windows.Forms.TabPage tpProductRegistration;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.TextBox txtProductGroup_M;
        private System.Windows.Forms.TextBox txtProductType_M;
        private System.Windows.Forms.TextBox txtProductName_M;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.TextBox txtProductGroup_E;
        private System.Windows.Forms.TextBox txtProductType_E;
        private System.Windows.Forms.TextBox txtProductName_E;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboProductGroup;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
    }
}