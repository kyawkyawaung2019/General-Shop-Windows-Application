namespace GeneralShop
{
    partial class CreditorsRevoke
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.gbRevoke = new System.Windows.Forms.GroupBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblCreditDate = new System.Windows.Forms.Label();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.lblRevokeAmount = new System.Windows.Forms.Label();
            this.txtRevokeAmount = new System.Windows.Forms.TextBox();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.lblAddress_M = new System.Windows.Forms.Label();
            this.lblGender_M = new System.Windows.Forms.Label();
            this.lblName_M = new System.Windows.Forms.Label();
            this.txtAddress_M = new System.Windows.Forms.TextBox();
            this.txtGender_M = new System.Windows.Forms.TextBox();
            this.txtName_M = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.ListBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.gbRevoke.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.gbRevoke);
            this.panelTop.Controls.Add(this.lblAddress_M);
            this.panelTop.Controls.Add(this.lblGender_M);
            this.panelTop.Controls.Add(this.lblName_M);
            this.panelTop.Controls.Add(this.txtAddress_M);
            this.panelTop.Controls.Add(this.txtGender_M);
            this.panelTop.Controls.Add(this.txtName_M);
            this.panelTop.Controls.Add(this.lblAddress);
            this.panelTop.Controls.Add(this.lblGender);
            this.panelTop.Controls.Add(this.lblName);
            this.panelTop.Controls.Add(this.txtAddress);
            this.panelTop.Controls.Add(this.txtName);
            this.panelTop.Controls.Add(this.txtGender);
            this.panelTop.Controls.Add(this.lbCustomerID);
            this.panelTop.Controls.Add(this.lblCustomerID);
            this.panelTop.Controls.Add(this.txtCustomerID);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 363);
            this.panelTop.TabIndex = 0;
            // 
            // gbRevoke
            // 
            this.gbRevoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRevoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbRevoke.Controls.Add(this.txtCredit);
            this.gbRevoke.Controls.Add(this.lblCreditDate);
            this.gbRevoke.Controls.Add(this.btnRevoke);
            this.gbRevoke.Controls.Add(this.lblRevokeAmount);
            this.gbRevoke.Controls.Add(this.txtRevokeAmount);
            this.gbRevoke.Controls.Add(this.lblTotalCredit);
            this.gbRevoke.Controls.Add(this.txtTotalCredit);
            this.gbRevoke.Location = new System.Drawing.Point(750, 23);
            this.gbRevoke.Name = "gbRevoke";
            this.gbRevoke.Size = new System.Drawing.Size(220, 270);
            this.gbRevoke.TabIndex = 15;
            this.gbRevoke.TabStop = false;
            this.gbRevoke.Text = "Creditors Revoke";
            // 
            // txtCredit
            // 
            this.txtCredit.Enabled = false;
            this.txtCredit.Location = new System.Drawing.Point(128, 144);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCredit.Size = new System.Drawing.Size(86, 32);
            this.txtCredit.TabIndex = 6;
            this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreditDate
            // 
            this.lblCreditDate.AutoSize = true;
            this.lblCreditDate.Location = new System.Drawing.Point(99, 42);
            this.lblCreditDate.Name = "lblCreditDate";
            this.lblCreditDate.Size = new System.Drawing.Size(97, 25);
            this.lblCreditDate.TabIndex = 5;
            this.lblCreditDate.Text = "(Credit Date)";
            // 
            // btnRevoke
            // 
            this.btnRevoke.BackColor = System.Drawing.Color.Gold;
            this.btnRevoke.Enabled = false;
            this.btnRevoke.Location = new System.Drawing.Point(6, 182);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(208, 82);
            this.btnRevoke.TabIndex = 4;
            this.btnRevoke.Text = "REVOKE";
            this.btnRevoke.UseVisualStyleBackColor = false;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // lblRevokeAmount
            // 
            this.lblRevokeAmount.AutoSize = true;
            this.lblRevokeAmount.Location = new System.Drawing.Point(6, 116);
            this.lblRevokeAmount.Name = "lblRevokeAmount";
            this.lblRevokeAmount.Size = new System.Drawing.Size(116, 25);
            this.lblRevokeAmount.TabIndex = 3;
            this.lblRevokeAmount.Text = "Revoke Amount";
            // 
            // txtRevokeAmount
            // 
            this.txtRevokeAmount.Enabled = false;
            this.txtRevokeAmount.Location = new System.Drawing.Point(6, 144);
            this.txtRevokeAmount.Name = "txtRevokeAmount";
            this.txtRevokeAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRevokeAmount.Size = new System.Drawing.Size(116, 32);
            this.txtRevokeAmount.TabIndex = 2;
            this.txtRevokeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRevokeAmount.TextChanged += new System.EventHandler(this.txtRevokeAmount_TextChanged);
            this.txtRevokeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRevokeAmount_KeyPress);
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Location = new System.Drawing.Point(6, 42);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(87, 25);
            this.lblTotalCredit.TabIndex = 1;
            this.lblTotalCredit.Text = "Total Credit";
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Enabled = false;
            this.txtTotalCredit.Location = new System.Drawing.Point(6, 70);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCredit.Size = new System.Drawing.Size(208, 32);
            this.txtTotalCredit.TabIndex = 0;
            this.txtTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalCredit.TextChanged += new System.EventHandler(this.txtTotalCredit_TextChanged);
            // 
            // lblAddress_M
            // 
            this.lblAddress_M.AutoSize = true;
            this.lblAddress_M.Location = new System.Drawing.Point(489, 124);
            this.lblAddress_M.Name = "lblAddress_M";
            this.lblAddress_M.Size = new System.Drawing.Size(89, 25);
            this.lblAddress_M.TabIndex = 14;
            this.lblAddress_M.Text = "ေနရပ္လိပ္စာ";
            // 
            // lblGender_M
            // 
            this.lblGender_M.AutoSize = true;
            this.lblGender_M.Location = new System.Drawing.Point(383, 124);
            this.lblGender_M.Name = "lblGender_M";
            this.lblGender_M.Size = new System.Drawing.Size(56, 25);
            this.lblGender_M.TabIndex = 13;
            this.lblGender_M.Text = "က်ား/မ";
            // 
            // lblName_M
            // 
            this.lblName_M.AutoSize = true;
            this.lblName_M.Location = new System.Drawing.Point(127, 124);
            this.lblName_M.Name = "lblName_M";
            this.lblName_M.Size = new System.Drawing.Size(52, 25);
            this.lblName_M.TabIndex = 12;
            this.lblName_M.Text = "အမည္";
            // 
            // txtAddress_M
            // 
            this.txtAddress_M.Enabled = false;
            this.txtAddress_M.Location = new System.Drawing.Point(494, 152);
            this.txtAddress_M.Name = "txtAddress_M";
            this.txtAddress_M.Size = new System.Drawing.Size(250, 32);
            this.txtAddress_M.TabIndex = 11;
            // 
            // txtGender_M
            // 
            this.txtGender_M.Enabled = false;
            this.txtGender_M.Location = new System.Drawing.Point(388, 152);
            this.txtGender_M.Name = "txtGender_M";
            this.txtGender_M.Size = new System.Drawing.Size(100, 32);
            this.txtGender_M.TabIndex = 10;
            // 
            // txtName_M
            // 
            this.txtName_M.Enabled = false;
            this.txtName_M.Location = new System.Drawing.Point(132, 152);
            this.txtName_M.Name = "txtName_M";
            this.txtName_M.Size = new System.Drawing.Size(250, 32);
            this.txtName_M.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(489, 23);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 25);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(383, 23);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 25);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(127, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(494, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 32);
            this.txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(132, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 32);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(388, 51);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 32);
            this.txtGender.TabIndex = 3;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.Enabled = false;
            this.lbCustomerID.FormattingEnabled = true;
            this.lbCustomerID.ItemHeight = 25;
            this.lbCustomerID.Location = new System.Drawing.Point(26, 93);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(100, 204);
            this.lbCustomerID.TabIndex = 2;
            this.lbCustomerID.TabStop = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(21, 23);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(91, 25);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(26, 51);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 32);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 313);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(984, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // CreditorsRevoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 363);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditorsRevoke";
            this.Text = "CreditorsRevoke";
            this.Load += new System.EventHandler(this.CreditorsRevoke_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.gbRevoke.ResumeLayout(false);
            this.gbRevoke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ListBox lbCustomerID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblAddress_M;
        private System.Windows.Forms.Label lblGender_M;
        private System.Windows.Forms.Label lblName_M;
        private System.Windows.Forms.TextBox txtAddress_M;
        private System.Windows.Forms.TextBox txtGender_M;
        private System.Windows.Forms.TextBox txtName_M;
        private System.Windows.Forms.GroupBox gbRevoke;
        private System.Windows.Forms.Label lblTotalCredit;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtRevokeAmount;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Label lblRevokeAmount;
        private System.Windows.Forms.Label lblCreditDate;
        private System.Windows.Forms.TextBox txtCredit;
    }
}