namespace GeneralShop
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblSearchByType = new System.Windows.Forms.Label();
            this.lblSearchByGroup = new System.Windows.Forms.Label();
            this.cboSearchByName = new System.Windows.Forms.ComboBox();
            this.cboSearchByType = new System.Windows.Forms.ComboBox();
            this.cboSearchByGroup = new System.Windows.Forms.ComboBox();
            this.txtProductGroup_Myanmar = new System.Windows.Forms.TextBox();
            this.txtProductType_Myanmar = new System.Windows.Forms.TextBox();
            this.txtProductName_Myanmar = new System.Windows.Forms.TextBox();
            this.txtProductGroup_English = new System.Windows.Forms.TextBox();
            this.txtProductType_English = new System.Windows.Forms.TextBox();
            this.txtProductName_English = new System.Windows.Forms.TextBox();
            this.lblProductGroup_Myanmar = new System.Windows.Forms.Label();
            this.lblProductType_Myanmar = new System.Windows.Forms.Label();
            this.lblProductName_Myanmar = new System.Windows.Forms.Label();
            this.lblProductGroup_English = new System.Windows.Forms.Label();
            this.lblProductType_English = new System.Windows.Forms.Label();
            this.lblProductName_English = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.tabControlNeedToPurchase = new System.Windows.Forms.TabControl();
            this.tpCurrentPurchase = new System.Windows.Forms.TabPage();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtCurrentPurchaseAmount = new System.Windows.Forms.TextBox();
            this.dgvCurrentPurchase = new System.Windows.Forms.DataGridView();
            this.tpDailyPurchase = new System.Windows.Forms.TabPage();
            this.txtDailyPurchaseAmount = new System.Windows.Forms.TextBox();
            this.pbLockDailyPurchase = new System.Windows.Forms.PictureBox();
            this.dgvDailyPurchase = new System.Windows.Forms.DataGridView();
            this.tpMonthlyPurchase = new System.Windows.Forms.TabPage();
            this.txtMonthlyPurchaseAmount = new System.Windows.Forms.TextBox();
            this.pbLockMonthlyPurchase = new System.Windows.Forms.PictureBox();
            this.dgvMonthlyPurchase = new System.Windows.Forms.DataGridView();
            this.tpNeedToPurchase = new System.Windows.Forms.TabPage();
            this.pbLockNeedToPurchase = new System.Windows.Forms.PictureBox();
            this.dgvNeedToPurchase = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlNeedToPurchase.SuspendLayout();
            this.tpCurrentPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPurchase)).BeginInit();
            this.tpDailyPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockDailyPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyPurchase)).BeginInit();
            this.tpMonthlyPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockMonthlyPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyPurchase)).BeginInit();
            this.tpNeedToPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockNeedToPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeedToPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblStaffName);
            this.panel3.Controls.Add(this.btnLanguage);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1270, 180);
            this.panel3.TabIndex = 8;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStaffName.Font = new System.Drawing.Font("Zawgyi-One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(798, 136);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(110, 33);
            this.lblStaffName.TabIndex = 13;
            this.lblStaffName.Text = "Staff Name";
            // 
            // btnLanguage
            // 
            this.btnLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLanguage.Location = new System.Drawing.Point(1156, 134);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(100, 35);
            this.btnLanguage.TabIndex = 12;
            this.btnLanguage.TabStop = false;
            this.btnLanguage.Text = "ENGLISH";
            this.btnLanguage.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(692, 134);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Olive;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(692, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(564, 111);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "12:00:00 AM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Olive;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(261, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(353, 31);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Wednesday, November 1, 2017";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Olive;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(258, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 55);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "PURCHASE";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 7);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1270, 50);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.lblSearchByName);
            this.panel2.Controls.Add(this.lblSearchByType);
            this.panel2.Controls.Add(this.lblSearchByGroup);
            this.panel2.Controls.Add(this.cboSearchByName);
            this.panel2.Controls.Add(this.cboSearchByType);
            this.panel2.Controls.Add(this.cboSearchByGroup);
            this.panel2.Controls.Add(this.txtProductGroup_Myanmar);
            this.panel2.Controls.Add(this.txtProductType_Myanmar);
            this.panel2.Controls.Add(this.txtProductName_Myanmar);
            this.panel2.Controls.Add(this.txtProductGroup_English);
            this.panel2.Controls.Add(this.txtProductType_English);
            this.panel2.Controls.Add(this.txtProductName_English);
            this.panel2.Controls.Add(this.lblProductGroup_Myanmar);
            this.panel2.Controls.Add(this.lblProductType_Myanmar);
            this.panel2.Controls.Add(this.lblProductName_Myanmar);
            this.panel2.Controls.Add(this.lblProductGroup_English);
            this.panel2.Controls.Add(this.lblProductType_English);
            this.panel2.Controls.Add(this.lblProductName_English);
            this.panel2.Controls.Add(this.lblSupplierID);
            this.panel2.Controls.Add(this.txtSupplierID);
            this.panel2.Controls.Add(this.tabControlNeedToPurchase);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtProductID);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblProductId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 458);
            this.panel2.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(980, 105);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(276, 32);
            this.txtDate.TabIndex = 62;
            this.txtDate.TabStop = false;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(676, 81);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(113, 19);
            this.lblSearchByName.TabIndex = 61;
            this.lblSearchByName.Text = "Search By Name";
            // 
            // lblSearchByType
            // 
            this.lblSearchByType.AutoSize = true;
            this.lblSearchByType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByType.Location = new System.Drawing.Point(420, 81);
            this.lblSearchByType.Name = "lblSearchByType";
            this.lblSearchByType.Size = new System.Drawing.Size(106, 19);
            this.lblSearchByType.TabIndex = 60;
            this.lblSearchByType.Text = "Search By Type";
            // 
            // lblSearchByGroup
            // 
            this.lblSearchByGroup.AutoSize = true;
            this.lblSearchByGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByGroup.Location = new System.Drawing.Point(165, 81);
            this.lblSearchByGroup.Name = "lblSearchByGroup";
            this.lblSearchByGroup.Size = new System.Drawing.Size(115, 19);
            this.lblSearchByGroup.TabIndex = 59;
            this.lblSearchByGroup.Text = "Search By Group";
            // 
            // cboSearchByName
            // 
            this.cboSearchByName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchByName.DropDownWidth = 200;
            this.cboSearchByName.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchByName.FormattingEnabled = true;
            this.cboSearchByName.IntegralHeight = false;
            this.cboSearchByName.Items.AddRange(new object[] {
            "ALL"});
            this.cboSearchByName.Location = new System.Drawing.Point(680, 105);
            this.cboSearchByName.Name = "cboSearchByName";
            this.cboSearchByName.Size = new System.Drawing.Size(250, 33);
            this.cboSearchByName.TabIndex = 58;
            this.cboSearchByName.TabStop = false;
            this.cboSearchByName.SelectedIndexChanged += new System.EventHandler(this.cboSearchByName_SelectedIndexChanged);
            // 
            // cboSearchByType
            // 
            this.cboSearchByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchByType.DropDownWidth = 200;
            this.cboSearchByType.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchByType.FormattingEnabled = true;
            this.cboSearchByType.IntegralHeight = false;
            this.cboSearchByType.Items.AddRange(new object[] {
            "ALL"});
            this.cboSearchByType.Location = new System.Drawing.Point(424, 106);
            this.cboSearchByType.Name = "cboSearchByType";
            this.cboSearchByType.Size = new System.Drawing.Size(250, 33);
            this.cboSearchByType.TabIndex = 57;
            this.cboSearchByType.TabStop = false;
            this.cboSearchByType.SelectedIndexChanged += new System.EventHandler(this.cboSearchByType_SelectedIndexChanged);
            // 
            // cboSearchByGroup
            // 
            this.cboSearchByGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchByGroup.DropDownWidth = 200;
            this.cboSearchByGroup.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchByGroup.FormattingEnabled = true;
            this.cboSearchByGroup.IntegralHeight = false;
            this.cboSearchByGroup.Items.AddRange(new object[] {
            "ALL"});
            this.cboSearchByGroup.Location = new System.Drawing.Point(168, 105);
            this.cboSearchByGroup.Name = "cboSearchByGroup";
            this.cboSearchByGroup.Size = new System.Drawing.Size(250, 33);
            this.cboSearchByGroup.TabIndex = 56;
            this.cboSearchByGroup.TabStop = false;
            this.cboSearchByGroup.SelectedIndexChanged += new System.EventHandler(this.cboSearchByGroup_SelectedIndexChanged);
            // 
            // txtProductGroup_Myanmar
            // 
            this.txtProductGroup_Myanmar.Enabled = false;
            this.txtProductGroup_Myanmar.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductGroup_Myanmar.Location = new System.Drawing.Point(1074, 34);
            this.txtProductGroup_Myanmar.Name = "txtProductGroup_Myanmar";
            this.txtProductGroup_Myanmar.Size = new System.Drawing.Size(180, 34);
            this.txtProductGroup_Myanmar.TabIndex = 55;
            // 
            // txtProductType_Myanmar
            // 
            this.txtProductType_Myanmar.Enabled = false;
            this.txtProductType_Myanmar.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType_Myanmar.Location = new System.Drawing.Point(888, 33);
            this.txtProductType_Myanmar.Name = "txtProductType_Myanmar";
            this.txtProductType_Myanmar.Size = new System.Drawing.Size(180, 34);
            this.txtProductType_Myanmar.TabIndex = 53;
            // 
            // txtProductName_Myanmar
            // 
            this.txtProductName_Myanmar.Enabled = false;
            this.txtProductName_Myanmar.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName_Myanmar.Location = new System.Drawing.Point(702, 34);
            this.txtProductName_Myanmar.Name = "txtProductName_Myanmar";
            this.txtProductName_Myanmar.Size = new System.Drawing.Size(180, 34);
            this.txtProductName_Myanmar.TabIndex = 52;
            // 
            // txtProductGroup_English
            // 
            this.txtProductGroup_English.Enabled = false;
            this.txtProductGroup_English.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductGroup_English.Location = new System.Drawing.Point(516, 34);
            this.txtProductGroup_English.Name = "txtProductGroup_English";
            this.txtProductGroup_English.Size = new System.Drawing.Size(180, 32);
            this.txtProductGroup_English.TabIndex = 51;
            // 
            // txtProductType_English
            // 
            this.txtProductType_English.Enabled = false;
            this.txtProductType_English.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType_English.Location = new System.Drawing.Point(330, 34);
            this.txtProductType_English.Name = "txtProductType_English";
            this.txtProductType_English.Size = new System.Drawing.Size(180, 32);
            this.txtProductType_English.TabIndex = 50;
            // 
            // txtProductName_English
            // 
            this.txtProductName_English.Enabled = false;
            this.txtProductName_English.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName_English.Location = new System.Drawing.Point(144, 34);
            this.txtProductName_English.Name = "txtProductName_English";
            this.txtProductName_English.Size = new System.Drawing.Size(180, 32);
            this.txtProductName_English.TabIndex = 49;
            // 
            // lblProductGroup_Myanmar
            // 
            this.lblProductGroup_Myanmar.AutoSize = true;
            this.lblProductGroup_Myanmar.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductGroup_Myanmar.Location = new System.Drawing.Point(1069, 9);
            this.lblProductGroup_Myanmar.Name = "lblProductGroup_Myanmar";
            this.lblProductGroup_Myanmar.Size = new System.Drawing.Size(88, 25);
            this.lblProductGroup_Myanmar.TabIndex = 48;
            this.lblProductGroup_Myanmar.Text = "ပစၥည္း အုပ္စု";
            // 
            // lblProductType_Myanmar
            // 
            this.lblProductType_Myanmar.AutoSize = true;
            this.lblProductType_Myanmar.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType_Myanmar.Location = new System.Drawing.Point(883, 6);
            this.lblProductType_Myanmar.Name = "lblProductType_Myanmar";
            this.lblProductType_Myanmar.Size = new System.Drawing.Size(120, 25);
            this.lblProductType_Myanmar.TabIndex = 47;
            this.lblProductType_Myanmar.Text = "ပစၥည္း အမ်ိုးအစား";
            // 
            // lblProductName_Myanmar
            // 
            this.lblProductName_Myanmar.AutoSize = true;
            this.lblProductName_Myanmar.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName_Myanmar.Location = new System.Drawing.Point(697, 9);
            this.lblProductName_Myanmar.Name = "lblProductName_Myanmar";
            this.lblProductName_Myanmar.Size = new System.Drawing.Size(95, 25);
            this.lblProductName_Myanmar.TabIndex = 46;
            this.lblProductName_Myanmar.Text = "ပစၥည္း အမည္";
            // 
            // lblProductGroup_English
            // 
            this.lblProductGroup_English.AutoSize = true;
            this.lblProductGroup_English.Location = new System.Drawing.Point(513, 14);
            this.lblProductGroup_English.Name = "lblProductGroup_English";
            this.lblProductGroup_English.Size = new System.Drawing.Size(94, 17);
            this.lblProductGroup_English.TabIndex = 45;
            this.lblProductGroup_English.Text = "Product Group";
            // 
            // lblProductType_English
            // 
            this.lblProductType_English.AutoSize = true;
            this.lblProductType_English.Location = new System.Drawing.Point(327, 14);
            this.lblProductType_English.Name = "lblProductType_English";
            this.lblProductType_English.Size = new System.Drawing.Size(87, 17);
            this.lblProductType_English.TabIndex = 44;
            this.lblProductType_English.Text = "Product Type";
            // 
            // lblProductName_English
            // 
            this.lblProductName_English.AutoSize = true;
            this.lblProductName_English.Location = new System.Drawing.Point(149, 14);
            this.lblProductName_English.Name = "lblProductName_English";
            this.lblProductName_English.Size = new System.Drawing.Size(94, 17);
            this.lblProductName_English.TabIndex = 43;
            this.lblProductName_English.Text = "Product Name";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(10, 245);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(79, 19);
            this.lblSupplierID.TabIndex = 42;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.Location = new System.Drawing.Point(10, 267);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(150, 39);
            this.txtSupplierID.TabIndex = 3;
            this.txtSupplierID.Text = "0000";
            this.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSupplierID.TextChanged += new System.EventHandler(this.txtSupplierID_TextChanged);
            // 
            // tabControlNeedToPurchase
            // 
            this.tabControlNeedToPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNeedToPurchase.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlNeedToPurchase.Controls.Add(this.tpCurrentPurchase);
            this.tabControlNeedToPurchase.Controls.Add(this.tpDailyPurchase);
            this.tabControlNeedToPurchase.Controls.Add(this.tpMonthlyPurchase);
            this.tabControlNeedToPurchase.Controls.Add(this.tpNeedToPurchase);
            this.tabControlNeedToPurchase.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlNeedToPurchase.Location = new System.Drawing.Point(168, 146);
            this.tabControlNeedToPurchase.Name = "tabControlNeedToPurchase";
            this.tabControlNeedToPurchase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlNeedToPurchase.RightToLeftLayout = true;
            this.tabControlNeedToPurchase.SelectedIndex = 0;
            this.tabControlNeedToPurchase.Size = new System.Drawing.Size(1088, 302);
            this.tabControlNeedToPurchase.TabIndex = 35;
            this.tabControlNeedToPurchase.TabStop = false;
            // 
            // tpCurrentPurchase
            // 
            this.tpCurrentPurchase.BackColor = System.Drawing.Color.White;
            this.tpCurrentPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCurrentPurchase.Controls.Add(this.btnRestart);
            this.tpCurrentPurchase.Controls.Add(this.txtCurrentPurchaseAmount);
            this.tpCurrentPurchase.Controls.Add(this.dgvCurrentPurchase);
            this.tpCurrentPurchase.Location = new System.Drawing.Point(4, 29);
            this.tpCurrentPurchase.Name = "tpCurrentPurchase";
            this.tpCurrentPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpCurrentPurchase.Size = new System.Drawing.Size(1080, 269);
            this.tpCurrentPurchase.TabIndex = 2;
            this.tpCurrentPurchase.Text = "Current Purchase";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Gold;
            this.btnRestart.Location = new System.Drawing.Point(506, 90);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(64, 27);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.TabStop = false;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtCurrentPurchaseAmount
            // 
            this.txtCurrentPurchaseAmount.BackColor = System.Drawing.Color.White;
            this.txtCurrentPurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPurchaseAmount.Enabled = false;
            this.txtCurrentPurchaseAmount.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPurchaseAmount.Location = new System.Drawing.Point(506, 123);
            this.txtCurrentPurchaseAmount.Name = "txtCurrentPurchaseAmount";
            this.txtCurrentPurchaseAmount.ReadOnly = true;
            this.txtCurrentPurchaseAmount.Size = new System.Drawing.Size(200, 56);
            this.txtCurrentPurchaseAmount.TabIndex = 7;
            this.txtCurrentPurchaseAmount.Text = "0";
            this.txtCurrentPurchaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCurrentPurchase
            // 
            this.dgvCurrentPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCurrentPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentPurchase.Location = new System.Drawing.Point(0, 0);
            this.dgvCurrentPurchase.Name = "dgvCurrentPurchase";
            this.dgvCurrentPurchase.Size = new System.Drawing.Size(1076, 265);
            this.dgvCurrentPurchase.TabIndex = 0;
            this.dgvCurrentPurchase.TabStop = false;
            // 
            // tpDailyPurchase
            // 
            this.tpDailyPurchase.BackColor = System.Drawing.Color.White;
            this.tpDailyPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpDailyPurchase.Controls.Add(this.txtDailyPurchaseAmount);
            this.tpDailyPurchase.Controls.Add(this.pbLockDailyPurchase);
            this.tpDailyPurchase.Controls.Add(this.dgvDailyPurchase);
            this.tpDailyPurchase.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDailyPurchase.Location = new System.Drawing.Point(4, 29);
            this.tpDailyPurchase.Name = "tpDailyPurchase";
            this.tpDailyPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tpDailyPurchase.Size = new System.Drawing.Size(1080, 269);
            this.tpDailyPurchase.TabIndex = 1;
            this.tpDailyPurchase.Text = "Daily Purchase";
            // 
            // txtDailyPurchaseAmount
            // 
            this.txtDailyPurchaseAmount.BackColor = System.Drawing.Color.White;
            this.txtDailyPurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDailyPurchaseAmount.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyPurchaseAmount.Location = new System.Drawing.Point(506, 90);
            this.txtDailyPurchaseAmount.Name = "txtDailyPurchaseAmount";
            this.txtDailyPurchaseAmount.Size = new System.Drawing.Size(200, 56);
            this.txtDailyPurchaseAmount.TabIndex = 2;
            this.txtDailyPurchaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDailyPurchaseAmount.Visible = false;
            // 
            // pbLockDailyPurchase
            // 
            this.pbLockDailyPurchase.Image = global::GeneralShop.Properties.Resources.Lock;
            this.pbLockDailyPurchase.Location = new System.Drawing.Point(6, 6);
            this.pbLockDailyPurchase.Name = "pbLockDailyPurchase";
            this.pbLockDailyPurchase.Size = new System.Drawing.Size(202, 252);
            this.pbLockDailyPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLockDailyPurchase.TabIndex = 1;
            this.pbLockDailyPurchase.TabStop = false;
            this.pbLockDailyPurchase.Click += new System.EventHandler(this.pbLockDailyPurchase_Click);
            // 
            // dgvDailyPurchase
            // 
            this.dgvDailyPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDailyPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailyPurchase.Location = new System.Drawing.Point(3, 3);
            this.dgvDailyPurchase.Name = "dgvDailyPurchase";
            this.dgvDailyPurchase.ReadOnly = true;
            this.dgvDailyPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDailyPurchase.Size = new System.Drawing.Size(1070, 259);
            this.dgvDailyPurchase.TabIndex = 0;
            this.dgvDailyPurchase.Visible = false;
            // 
            // tpMonthlyPurchase
            // 
            this.tpMonthlyPurchase.BackColor = System.Drawing.Color.White;
            this.tpMonthlyPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpMonthlyPurchase.Controls.Add(this.txtMonthlyPurchaseAmount);
            this.tpMonthlyPurchase.Controls.Add(this.pbLockMonthlyPurchase);
            this.tpMonthlyPurchase.Controls.Add(this.dgvMonthlyPurchase);
            this.tpMonthlyPurchase.Location = new System.Drawing.Point(4, 29);
            this.tpMonthlyPurchase.Name = "tpMonthlyPurchase";
            this.tpMonthlyPurchase.Size = new System.Drawing.Size(1080, 269);
            this.tpMonthlyPurchase.TabIndex = 3;
            this.tpMonthlyPurchase.Text = "Monthly Purchase";
            // 
            // txtMonthlyPurchaseAmount
            // 
            this.txtMonthlyPurchaseAmount.BackColor = System.Drawing.Color.White;
            this.txtMonthlyPurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonthlyPurchaseAmount.Enabled = false;
            this.txtMonthlyPurchaseAmount.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyPurchaseAmount.Location = new System.Drawing.Point(506, 90);
            this.txtMonthlyPurchaseAmount.Name = "txtMonthlyPurchaseAmount";
            this.txtMonthlyPurchaseAmount.Size = new System.Drawing.Size(200, 56);
            this.txtMonthlyPurchaseAmount.TabIndex = 2;
            this.txtMonthlyPurchaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonthlyPurchaseAmount.Visible = false;
            // 
            // pbLockMonthlyPurchase
            // 
            this.pbLockMonthlyPurchase.Image = global::GeneralShop.Properties.Resources.Lock;
            this.pbLockMonthlyPurchase.Location = new System.Drawing.Point(3, 3);
            this.pbLockMonthlyPurchase.Name = "pbLockMonthlyPurchase";
            this.pbLockMonthlyPurchase.Size = new System.Drawing.Size(202, 252);
            this.pbLockMonthlyPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLockMonthlyPurchase.TabIndex = 1;
            this.pbLockMonthlyPurchase.TabStop = false;
            this.pbLockMonthlyPurchase.Click += new System.EventHandler(this.pbLockMonthlyPurchase_Click);
            // 
            // dgvMonthlyPurchase
            // 
            this.dgvMonthlyPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMonthlyPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonthlyPurchase.Location = new System.Drawing.Point(0, 0);
            this.dgvMonthlyPurchase.Name = "dgvMonthlyPurchase";
            this.dgvMonthlyPurchase.ReadOnly = true;
            this.dgvMonthlyPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMonthlyPurchase.Size = new System.Drawing.Size(1076, 265);
            this.dgvMonthlyPurchase.TabIndex = 0;
            this.dgvMonthlyPurchase.TabStop = false;
            this.dgvMonthlyPurchase.Visible = false;
            // 
            // tpNeedToPurchase
            // 
            this.tpNeedToPurchase.BackColor = System.Drawing.Color.White;
            this.tpNeedToPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpNeedToPurchase.Controls.Add(this.pbLockNeedToPurchase);
            this.tpNeedToPurchase.Controls.Add(this.dgvNeedToPurchase);
            this.tpNeedToPurchase.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNeedToPurchase.Location = new System.Drawing.Point(4, 29);
            this.tpNeedToPurchase.Name = "tpNeedToPurchase";
            this.tpNeedToPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tpNeedToPurchase.Size = new System.Drawing.Size(1080, 269);
            this.tpNeedToPurchase.TabIndex = 0;
            this.tpNeedToPurchase.Text = "Need To Purchase";
            // 
            // pbLockNeedToPurchase
            // 
            this.pbLockNeedToPurchase.Image = global::GeneralShop.Properties.Resources.Lock;
            this.pbLockNeedToPurchase.Location = new System.Drawing.Point(6, 6);
            this.pbLockNeedToPurchase.Name = "pbLockNeedToPurchase";
            this.pbLockNeedToPurchase.Size = new System.Drawing.Size(202, 252);
            this.pbLockNeedToPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLockNeedToPurchase.TabIndex = 35;
            this.pbLockNeedToPurchase.TabStop = false;
            this.pbLockNeedToPurchase.Click += new System.EventHandler(this.pbLockNeedToPurchase_Click);
            // 
            // dgvNeedToPurchase
            // 
            this.dgvNeedToPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNeedToPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNeedToPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeedToPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNeedToPurchase.Location = new System.Drawing.Point(3, 3);
            this.dgvNeedToPurchase.Name = "dgvNeedToPurchase";
            this.dgvNeedToPurchase.ReadOnly = true;
            this.dgvNeedToPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNeedToPurchase.Size = new System.Drawing.Size(1070, 259);
            this.dgvNeedToPurchase.TabIndex = 34;
            this.dgvNeedToPurchase.TabStop = false;
            this.dgvNeedToPurchase.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.BackgroundImage = global::GeneralShop.Properties.Resources.Purchase;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(10, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 120);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "PURCHASE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(10, 188);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(150, 39);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(12, 110);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(150, 39);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(10, 34);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductID.Size = new System.Drawing.Size(128, 39);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(10, 166);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 19);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(10, 88);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(60, 19);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(7, 11);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(70, 17);
            this.lblProductId.TabIndex = 17;
            this.lblProductId.Text = "ProductID";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PURCHASE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControlNeedToPurchase.ResumeLayout(false);
            this.tpCurrentPurchase.ResumeLayout(false);
            this.tpCurrentPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPurchase)).EndInit();
            this.tpDailyPurchase.ResumeLayout(false);
            this.tpDailyPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockDailyPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyPurchase)).EndInit();
            this.tpMonthlyPurchase.ResumeLayout(false);
            this.tpMonthlyPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockMonthlyPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyPurchase)).EndInit();
            this.tpNeedToPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLockNeedToPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeedToPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TabControl tabControlNeedToPurchase;
        private System.Windows.Forms.TabPage tpDailyPurchase;
        private System.Windows.Forms.TabPage tpNeedToPurchase;
        private System.Windows.Forms.DataGridView dgvNeedToPurchase;
        private System.Windows.Forms.DataGridView dgvDailyPurchase;
        private System.Windows.Forms.TabPage tpCurrentPurchase;
        private System.Windows.Forms.DataGridView dgvCurrentPurchase;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtCurrentPurchaseAmount;
        private System.Windows.Forms.TabPage tpMonthlyPurchase;
        private System.Windows.Forms.DataGridView dgvMonthlyPurchase;
        private System.Windows.Forms.PictureBox pbLockMonthlyPurchase;
        private System.Windows.Forms.TextBox txtMonthlyPurchaseAmount;
        private System.Windows.Forms.PictureBox pbLockDailyPurchase;
        private System.Windows.Forms.TextBox txtDailyPurchaseAmount;
        private System.Windows.Forms.PictureBox pbLockNeedToPurchase;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblProductGroup_Myanmar;
        private System.Windows.Forms.Label lblProductType_Myanmar;
        private System.Windows.Forms.Label lblProductName_Myanmar;
        private System.Windows.Forms.Label lblProductGroup_English;
        private System.Windows.Forms.Label lblProductType_English;
        private System.Windows.Forms.Label lblProductName_English;
        private System.Windows.Forms.TextBox txtProductType_Myanmar;
        private System.Windows.Forms.TextBox txtProductName_Myanmar;
        private System.Windows.Forms.TextBox txtProductGroup_English;
        private System.Windows.Forms.TextBox txtProductType_English;
        private System.Windows.Forms.TextBox txtProductName_English;
        private System.Windows.Forms.TextBox txtProductGroup_Myanmar;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblSearchByType;
        private System.Windows.Forms.Label lblSearchByGroup;
        private System.Windows.Forms.ComboBox cboSearchByName;
        private System.Windows.Forms.ComboBox cboSearchByType;
        private System.Windows.Forms.ComboBox cboSearchByGroup;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnLogout;
    }
}