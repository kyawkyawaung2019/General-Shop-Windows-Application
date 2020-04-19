using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
  
        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.ToLower() == "general shop")
            {
                txtCode.Text = string.Empty;
                this.BackgroundImage = Properties.Resources.HomeBackground;
                pbHomeLock.Visible = true;
                lblTitle.Visible = true;
                //
                lblStock.Visible = true;
                lblSale.Visible = true;
                lblReport.Visible = true;
                lblPurchase.Visible = true;
                lblCreditors.Visible = true;
                lblCustomers.Visible = true;
                lblSuppliers.Visible = true;
                //
                pbSale.Visible = true;
                pbPurchase.Visible = true;
                pbReport.Visible = true;
                pbStock.Visible = true;
                pbCustomers.Visible = true;
                pbSuppliers.Visible = true;
                pbCreditors.Visible = true;
                //
                txtCode.Visible = false;
                pbHomeOpen.Visible = false;
            }
            else if(txtCode.TextLength > 12 && txtCode.Text.ToLower() != "general shop")
            {
                MessageBox.Show("PLEASE INSERT CODE!", "RETRY");
                txtCode.Text = string.Empty;
                txtCode.Focus();
            }
        }

        private void pbHomeOpen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbHomeLock_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            pbHomeLock.Visible = false;
            //
            lblStock.Visible = false;
            lblSale.Visible = false;
            lblReport.Visible = false;
            lblPurchase.Visible = false;
            lblCreditors.Visible = false;
            lblCustomers.Visible = false;
            lblSuppliers.Visible = false;
            //
            pbSale.Visible = false;
            pbPurchase.Visible = false;
            pbReport.Visible = false;
            pbStock.Visible = false;
            pbCustomers.Visible = false;
            pbSuppliers.Visible = false;
            pbCreditors.Visible = false;
            //
            txtCode.Visible = true;
            pbHomeOpen.Visible = true;
            txtCode.Focus();
        }

        private void lblSale_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblSale.Name.ToString());
            permission.Show();
        }
        
        private void pbSale_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(pbSale.Name.ToString());
            permission.Show();
        }

        private void lblPurchase_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblPurchase.Name.ToString());
            permission.Show();
        }

        private void pbPurchase_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(pbPurchase.Name.ToString());
            permission.Show();
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblReport.Name.ToString());
            permission.Show();
        }

        private void pbReport_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(pbReport.Name.ToString());
            permission.Show();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblStock.Name.ToString());
            permission.Show();
        }

        private void pbStock_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(pbStock.Name.ToString());
            permission.Show();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblCustomers.Name.ToString());
            permission.Show();
        }
        
        private void pbCustomers_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblCustomers.Name.ToString());
            permission.Show();
        }

        private void lblSuppliers_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblSuppliers.Name.ToString());
            permission.Show();
        }

        private void pbSuppliers_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblSuppliers.Name.ToString());
            permission.Show();
        }

        private void lblCreditors_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(lblCreditors.Name.ToString());
            permission.Show();
        }

        private void pbCreditors_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission(pbCreditors.Name.ToString());
            permission.Show();
        }
    }
}
