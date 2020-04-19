namespace GeneralShop
{
    partial class CreditorsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditorsDetail));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myanmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.lblCurrentCreditDate = new System.Windows.Forms.Label();
            this.lblLastCreditDate = new System.Windows.Forms.Label();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.lblCurrentCredit = new System.Windows.Forms.Label();
            this.lblLastCredit = new System.Windows.Forms.Label();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.txtCurrentCredit = new System.Windows.Forms.TextBox();
            this.txtLastCredit = new System.Windows.Forms.TextBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.tcCreditItems = new System.Windows.Forms.TabControl();
            this.tpCurrentCreditItems = new System.Windows.Forms.TabPage();
            this.dgvCurrentCreditItems = new System.Windows.Forms.DataGridView();
            this.tpLastCreditItems = new System.Windows.Forms.TabPage();
            this.dgvLastCreditItems = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.tcCreditItems.SuspendLayout();
            this.tpCurrentCreditItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentCreditItems)).BeginInit();
            this.tpLastCreditItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastCreditItems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Save";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.myanmarToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // myanmarToolStripMenuItem
            // 
            this.myanmarToolStripMenuItem.Name = "myanmarToolStripMenuItem";
            this.myanmarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.myanmarToolStripMenuItem.Text = "Myanmar";
            // 
            // panelTop
            // 
            this.panelTop.AutoScroll = true;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.lblLanguage);
            this.panelTop.Controls.Add(this.cboLanguage);
            this.panelTop.Controls.Add(this.lblAddress);
            this.panelTop.Controls.Add(this.lblGender);
            this.panelTop.Controls.Add(this.lblName);
            this.panelTop.Controls.Add(this.lblCustomerID);
            this.panelTop.Controls.Add(this.txtAddress);
            this.panelTop.Controls.Add(this.txtGender);
            this.panelTop.Controls.Add(this.txtName);
            this.panelTop.Controls.Add(this.txtCustomerID);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1180, 85);
            this.panelTop.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLanguage.Location = new System.Drawing.Point(980, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(75, 25);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "Language";
            // 
            // cboLanguage
            // 
            this.cboLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Myanmar"});
            this.cboLanguage.Location = new System.Drawing.Point(1055, 0);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(121, 33);
            this.cboLanguage.TabIndex = 9;
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(486, 12);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 25);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(380, 12);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 25);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(124, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(18, 12);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(91, 25);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(491, 45);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 32);
            this.txtAddress.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(385, 45);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 32);
            this.txtGender.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(129, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 32);
            this.txtName.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(23, 45);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 32);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.AutoScroll = true;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 509);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1180, 50);
            this.panelBottom.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.Gold;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeft.Controls.Add(this.btnRevoke);
            this.panelLeft.Controls.Add(this.lblCurrentCreditDate);
            this.panelLeft.Controls.Add(this.lblLastCreditDate);
            this.panelLeft.Controls.Add(this.lblTotalCredit);
            this.panelLeft.Controls.Add(this.lblCurrentCredit);
            this.panelLeft.Controls.Add(this.lblLastCredit);
            this.panelLeft.Controls.Add(this.txtTotalCredit);
            this.panelLeft.Controls.Add(this.txtCurrentCredit);
            this.panelLeft.Controls.Add(this.txtLastCredit);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 109);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(177, 400);
            this.panelLeft.TabIndex = 3;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevoke.BackColor = System.Drawing.Color.Orange;
            this.btnRevoke.Location = new System.Drawing.Point(0, 307);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(173, 89);
            this.btnRevoke.TabIndex = 8;
            this.btnRevoke.Text = "REVOKE";
            this.btnRevoke.UseVisualStyleBackColor = false;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // lblCurrentCreditDate
            // 
            this.lblCurrentCreditDate.AutoSize = true;
            this.lblCurrentCreditDate.Location = new System.Drawing.Point(8, 132);
            this.lblCurrentCreditDate.Name = "lblCurrentCreditDate";
            this.lblCurrentCreditDate.Size = new System.Drawing.Size(150, 25);
            this.lblCurrentCreditDate.TabIndex = 7;
            this.lblCurrentCreditDate.Text = "(Current Credit Date)";
            // 
            // lblLastCreditDate
            // 
            this.lblLastCreditDate.AutoSize = true;
            this.lblLastCreditDate.Location = new System.Drawing.Point(8, 46);
            this.lblLastCreditDate.Name = "lblLastCreditDate";
            this.lblLastCreditDate.Size = new System.Drawing.Size(129, 25);
            this.lblLastCreditDate.TabIndex = 6;
            this.lblLastCreditDate.Text = "(Last Credit Date)";
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Location = new System.Drawing.Point(8, 207);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(87, 25);
            this.lblTotalCredit.TabIndex = 5;
            this.lblTotalCredit.Text = "Total Credit";
            // 
            // lblCurrentCredit
            // 
            this.lblCurrentCredit.AutoSize = true;
            this.lblCurrentCredit.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCredit.Location = new System.Drawing.Point(8, 107);
            this.lblCurrentCredit.Name = "lblCurrentCredit";
            this.lblCurrentCredit.Size = new System.Drawing.Size(102, 25);
            this.lblCurrentCredit.TabIndex = 4;
            this.lblCurrentCredit.Text = "Current Credit";
            // 
            // lblLastCredit
            // 
            this.lblLastCredit.AutoSize = true;
            this.lblLastCredit.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCredit.Location = new System.Drawing.Point(8, 15);
            this.lblLastCredit.Name = "lblLastCredit";
            this.lblLastCredit.Size = new System.Drawing.Size(81, 25);
            this.lblLastCredit.TabIndex = 3;
            this.lblLastCredit.Text = "Last Credit";
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Enabled = false;
            this.txtTotalCredit.Location = new System.Drawing.Point(13, 235);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCredit.Size = new System.Drawing.Size(150, 32);
            this.txtTotalCredit.TabIndex = 2;
            this.txtTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentCredit
            // 
            this.txtCurrentCredit.Enabled = false;
            this.txtCurrentCredit.Location = new System.Drawing.Point(13, 161);
            this.txtCurrentCredit.Name = "txtCurrentCredit";
            this.txtCurrentCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrentCredit.Size = new System.Drawing.Size(150, 32);
            this.txtCurrentCredit.TabIndex = 1;
            this.txtCurrentCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastCredit
            // 
            this.txtLastCredit.Enabled = false;
            this.txtLastCredit.Location = new System.Drawing.Point(13, 74);
            this.txtLastCredit.Name = "txtLastCredit";
            this.txtLastCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastCredit.Size = new System.Drawing.Size(150, 32);
            this.txtLastCredit.TabIndex = 0;
            this.txtLastCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBody.Controls.Add(this.pbLock);
            this.panelBody.Controls.Add(this.tcCreditItems);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(177, 109);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1003, 400);
            this.panelBody.TabIndex = 4;
            // 
            // pbLock
            // 
            this.pbLock.BackColor = System.Drawing.Color.Gold;
            this.pbLock.BackgroundImage = global::GeneralShop.Properties.Resources.Creditors;
            this.pbLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLock.Location = new System.Drawing.Point(-2, -2);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(120, 110);
            this.pbLock.TabIndex = 1;
            this.pbLock.TabStop = false;
            this.pbLock.Click += new System.EventHandler(this.pbLock_Click);
            // 
            // tcCreditItems
            // 
            this.tcCreditItems.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcCreditItems.Controls.Add(this.tpCurrentCreditItems);
            this.tcCreditItems.Controls.Add(this.tpLastCreditItems);
            this.tcCreditItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCreditItems.Location = new System.Drawing.Point(0, 0);
            this.tcCreditItems.Name = "tcCreditItems";
            this.tcCreditItems.SelectedIndex = 0;
            this.tcCreditItems.Size = new System.Drawing.Size(999, 396);
            this.tcCreditItems.TabIndex = 0;
            this.tcCreditItems.TabStop = false;
            this.tcCreditItems.Visible = false;
            // 
            // tpCurrentCreditItems
            // 
            this.tpCurrentCreditItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCurrentCreditItems.Controls.Add(this.dgvCurrentCreditItems);
            this.tpCurrentCreditItems.Location = new System.Drawing.Point(4, 37);
            this.tpCurrentCreditItems.Name = "tpCurrentCreditItems";
            this.tpCurrentCreditItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpCurrentCreditItems.Size = new System.Drawing.Size(991, 355);
            this.tpCurrentCreditItems.TabIndex = 0;
            this.tpCurrentCreditItems.Text = "Current Credit Items";
            this.tpCurrentCreditItems.UseVisualStyleBackColor = true;
            // 
            // dgvCurrentCreditItems
            // 
            this.dgvCurrentCreditItems.AllowUserToOrderColumns = true;
            this.dgvCurrentCreditItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentCreditItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCurrentCreditItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentCreditItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentCreditItems.Location = new System.Drawing.Point(3, 3);
            this.dgvCurrentCreditItems.Name = "dgvCurrentCreditItems";
            this.dgvCurrentCreditItems.ReadOnly = true;
            this.dgvCurrentCreditItems.Size = new System.Drawing.Size(981, 345);
            this.dgvCurrentCreditItems.TabIndex = 0;
            // 
            // tpLastCreditItems
            // 
            this.tpLastCreditItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpLastCreditItems.Controls.Add(this.dgvLastCreditItems);
            this.tpLastCreditItems.Location = new System.Drawing.Point(4, 37);
            this.tpLastCreditItems.Name = "tpLastCreditItems";
            this.tpLastCreditItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpLastCreditItems.Size = new System.Drawing.Size(991, 355);
            this.tpLastCreditItems.TabIndex = 1;
            this.tpLastCreditItems.Text = "Last Credit Items";
            this.tpLastCreditItems.UseVisualStyleBackColor = true;
            // 
            // dgvLastCreditItems
            // 
            this.dgvLastCreditItems.AllowUserToOrderColumns = true;
            this.dgvLastCreditItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLastCreditItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLastCreditItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastCreditItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLastCreditItems.Location = new System.Drawing.Point(3, 3);
            this.dgvLastCreditItems.Name = "dgvLastCreditItems";
            this.dgvLastCreditItems.ReadOnly = true;
            this.dgvLastCreditItems.Size = new System.Drawing.Size(981, 345);
            this.dgvLastCreditItems.TabIndex = 0;
            // 
            // CreditorsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1180, 559);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "CreditorsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditors Detail";
            this.Load += new System.EventHandler(this.CreditDetail_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.tcCreditItems.ResumeLayout(false);
            this.tpCurrentCreditItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentCreditItems)).EndInit();
            this.tpLastCreditItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastCreditItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblTotalCredit;
        private System.Windows.Forms.Label lblCurrentCredit;
        private System.Windows.Forms.Label lblLastCredit;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtCurrentCredit;
        private System.Windows.Forms.TextBox txtLastCredit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myanmarToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentCreditDate;
        private System.Windows.Forms.Label lblLastCreditDate;
        private System.Windows.Forms.TabControl tcCreditItems;
        private System.Windows.Forms.TabPage tpCurrentCreditItems;
        private System.Windows.Forms.DataGridView dgvCurrentCreditItems;
        private System.Windows.Forms.TabPage tpLastCreditItems;
        private System.Windows.Forms.DataGridView dgvLastCreditItems;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnRevoke;
    }
}