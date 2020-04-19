using System;

namespace GeneralShop
{
    partial class CustomersRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersRegistration));
            this.gbCustomerRegistration = new System.Windows.Forms.GroupBox();
            this.cboGender_M = new System.Windows.Forms.ComboBox();
            this.cboGender_E = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbCustomerID = new System.Windows.Forms.ListBox();
            this.lblAddress_M = new System.Windows.Forms.Label();
            this.lblGender_M = new System.Windows.Forms.Label();
            this.lblName_M = new System.Windows.Forms.Label();
            this.txtAddress_M = new System.Windows.Forms.TextBox();
            this.txtName_M = new System.Windows.Forms.TextBox();
            this.lblGender_E = new System.Windows.Forms.Label();
            this.lblAddress_E = new System.Windows.Forms.Label();
            this.lblName_E = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtAddress_E = new System.Windows.Forms.TextBox();
            this.txtName_E = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.gbCustomerRegistration.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerRegistration
            // 
            this.gbCustomerRegistration.BackColor = System.Drawing.Color.Silver;
            this.gbCustomerRegistration.Controls.Add(this.cboGender_M);
            this.gbCustomerRegistration.Controls.Add(this.cboGender_E);
            this.gbCustomerRegistration.Controls.Add(this.btnRegister);
            this.gbCustomerRegistration.Controls.Add(this.lbCustomerID);
            this.gbCustomerRegistration.Controls.Add(this.lblAddress_M);
            this.gbCustomerRegistration.Controls.Add(this.lblGender_M);
            this.gbCustomerRegistration.Controls.Add(this.lblName_M);
            this.gbCustomerRegistration.Controls.Add(this.txtAddress_M);
            this.gbCustomerRegistration.Controls.Add(this.txtName_M);
            this.gbCustomerRegistration.Controls.Add(this.lblGender_E);
            this.gbCustomerRegistration.Controls.Add(this.lblAddress_E);
            this.gbCustomerRegistration.Controls.Add(this.lblName_E);
            this.gbCustomerRegistration.Controls.Add(this.lblCustomerID);
            this.gbCustomerRegistration.Controls.Add(this.txtAddress_E);
            this.gbCustomerRegistration.Controls.Add(this.txtName_E);
            this.gbCustomerRegistration.Controls.Add(this.txtCustomerID);
            this.gbCustomerRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCustomerRegistration.Location = new System.Drawing.Point(0, 24);
            this.gbCustomerRegistration.Name = "gbCustomerRegistration";
            this.gbCustomerRegistration.Size = new System.Drawing.Size(984, 287);
            this.gbCustomerRegistration.TabIndex = 0;
            this.gbCustomerRegistration.TabStop = false;
            this.gbCustomerRegistration.Text = "Customer Registration";
            // 
            // cboGender_M
            // 
            this.cboGender_M.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender_M.Enabled = false;
            this.cboGender_M.FormattingEnabled = true;
            this.cboGender_M.Items.AddRange(new object[] {
            "က်ား",
            "မ"});
            this.cboGender_M.Location = new System.Drawing.Point(364, 173);
            this.cboGender_M.Name = "cboGender_M";
            this.cboGender_M.Size = new System.Drawing.Size(121, 33);
            this.cboGender_M.TabIndex = 5;
            // 
            // cboGender_E
            // 
            this.cboGender_E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender_E.Enabled = false;
            this.cboGender_E.FormattingEnabled = true;
            this.cboGender_E.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender_E.Location = new System.Drawing.Point(364, 65);
            this.cboGender_E.Name = "cboGender_E";
            this.cboGender_E.Size = new System.Drawing.Size(121, 33);
            this.cboGender_E.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Gold;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegister.Location = new System.Drawing.Point(781, 28);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 256);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.FormattingEnabled = true;
            this.lbCustomerID.ItemHeight = 25;
            this.lbCustomerID.Location = new System.Drawing.Point(12, 103);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(88, 179);
            this.lbCustomerID.TabIndex = 14;
            this.lbCustomerID.TabStop = false;
            // 
            // lblAddress_M
            // 
            this.lblAddress_M.AutoSize = true;
            this.lblAddress_M.Location = new System.Drawing.Point(487, 140);
            this.lblAddress_M.Name = "lblAddress_M";
            this.lblAddress_M.Size = new System.Drawing.Size(89, 25);
            this.lblAddress_M.TabIndex = 13;
            this.lblAddress_M.Text = "ေနရပ္လိပ္စာ";
            // 
            // lblGender_M
            // 
            this.lblGender_M.AutoSize = true;
            this.lblGender_M.Location = new System.Drawing.Point(359, 140);
            this.lblGender_M.Name = "lblGender_M";
            this.lblGender_M.Size = new System.Drawing.Size(56, 25);
            this.lblGender_M.TabIndex = 12;
            this.lblGender_M.Text = "က်ား/မ";
            // 
            // lblName_M
            // 
            this.lblName_M.AutoSize = true;
            this.lblName_M.Location = new System.Drawing.Point(106, 140);
            this.lblName_M.Name = "lblName_M";
            this.lblName_M.Size = new System.Drawing.Size(52, 25);
            this.lblName_M.TabIndex = 11;
            this.lblName_M.Text = "အမည္";
            // 
            // txtAddress_M
            // 
            this.txtAddress_M.Enabled = false;
            this.txtAddress_M.Location = new System.Drawing.Point(492, 173);
            this.txtAddress_M.Name = "txtAddress_M";
            this.txtAddress_M.Size = new System.Drawing.Size(250, 32);
            this.txtAddress_M.TabIndex = 6;
            // 
            // txtName_M
            // 
            this.txtName_M.Enabled = false;
            this.txtName_M.Location = new System.Drawing.Point(108, 173);
            this.txtName_M.Name = "txtName_M";
            this.txtName_M.Size = new System.Drawing.Size(250, 32);
            this.txtName_M.TabIndex = 4;
            // 
            // lblGender_E
            // 
            this.lblGender_E.AutoSize = true;
            this.lblGender_E.Location = new System.Drawing.Point(359, 37);
            this.lblGender_E.Name = "lblGender_E";
            this.lblGender_E.Size = new System.Drawing.Size(59, 25);
            this.lblGender_E.TabIndex = 7;
            this.lblGender_E.Text = "Gender";
            // 
            // lblAddress_E
            // 
            this.lblAddress_E.AutoSize = true;
            this.lblAddress_E.Location = new System.Drawing.Point(487, 37);
            this.lblAddress_E.Name = "lblAddress_E";
            this.lblAddress_E.Size = new System.Drawing.Size(64, 25);
            this.lblAddress_E.TabIndex = 5;
            this.lblAddress_E.Text = "Address";
            // 
            // lblName_E
            // 
            this.lblName_E.AutoSize = true;
            this.lblName_E.Location = new System.Drawing.Point(103, 37);
            this.lblName_E.Name = "lblName_E";
            this.lblName_E.Size = new System.Drawing.Size(51, 25);
            this.lblName_E.TabIndex = 4;
            this.lblName_E.Text = "Name";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 37);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(91, 25);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtAddress_E
            // 
            this.txtAddress_E.Enabled = false;
            this.txtAddress_E.Location = new System.Drawing.Point(492, 65);
            this.txtAddress_E.Name = "txtAddress_E";
            this.txtAddress_E.Size = new System.Drawing.Size(250, 32);
            this.txtAddress_E.TabIndex = 3;
            // 
            // txtName_E
            // 
            this.txtName_E.Enabled = false;
            this.txtName_E.Location = new System.Drawing.Point(108, 65);
            this.txtName_E.Name = "txtName_E";
            this.txtName_E.Size = new System.Drawing.Size(250, 32);
            this.txtName_E.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(12, 65);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(91, 32);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 313);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(984, 50);
            this.panelBottom.TabIndex = 3;
            // 
            // CustomersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 363);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.gbCustomerRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegistration";
            this.Load += new System.EventHandler(this.CustomersRegistration_Load);
            this.gbCustomerRegistration.ResumeLayout(false);
            this.gbCustomerRegistration.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerRegistration;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAddress_E;
        private System.Windows.Forms.TextBox txtName_E;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblAddress_E;
        private System.Windows.Forms.Label lblName_E;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblGender_E;
        private System.Windows.Forms.Label lblAddress_M;
        private System.Windows.Forms.Label lblGender_M;
        private System.Windows.Forms.Label lblName_M;
        private System.Windows.Forms.TextBox txtAddress_M;
        private System.Windows.Forms.TextBox txtName_M;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cboGender_M;
        private System.Windows.Forms.ComboBox cboGender_E;
        private System.Windows.Forms.ListBox lbCustomerID;
    }
}