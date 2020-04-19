using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralShop
{
    public partial class CreditorsDetail : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        string customerId = null;
        int lastCredit = 0;
        DateTime lastCreditDate;
        int currentCredit = 0;
        DateTime currentCreditDate;
        public CreditorsDetail(string customerId, int lastCredit, DateTime lastCreditDate, int currentCredit, DateTime currentCreditDate)
        {
            InitializeComponent();
            //
            this.customerId = customerId;
            this.lastCredit = lastCredit;
            this.lastCreditDate = lastCreditDate;
            this.currentCredit = currentCredit;
            this.currentCreditDate = currentCreditDate;
        }

        private void CreditDetail_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = customerId;
            lblLastCreditDate.Text = lastCreditDate.ToString("dd/MMM/yyyy");
            txtLastCredit.Text = Convert.ToString(lastCredit);
            lblCurrentCreditDate.Text = currentCreditDate.ToString("dd/MMM/yyyy");
            txtCurrentCredit.Text = Convert.ToString(currentCredit);
            //
            int totalCredit = Convert.ToInt32(txtLastCredit.Text) + Convert.ToInt32(txtCurrentCredit.Text);
            txtTotalCredit.Text = Convert.ToString(totalCredit);
            //
            cboLanguage.SelectedIndex = 0;
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            //
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT CustomerID, Name_English AS Name_E, Gender_English AS Gender_E, Address_English AS Address_E, Name_Myanmar AS Name_M, Gender_Myanmar AS Gender_M, Address_Myanmar AS Address_M FROM Customers WHERE CustomerID=@customerId ORDER BY CustomerID";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@customerId", customerId);
                //
                string name_E = string.Empty;
                string gender_E = string.Empty;
                string address_E = string.Empty;
                string name_M = string.Empty;
                string gender_M = string.Empty;
                string address_M = string.Empty;
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name_E = reader["Name_E"].ToString();
                    gender_E = reader["Gender_E"].ToString();
                    address_E = reader["Address_E"].ToString();
                    name_M = reader["Name_M"].ToString();
                    gender_M = reader["gender_M"].ToString();
                    address_M = reader["address_M"].ToString();
                }
                reader.Close();
                //
                txtName.Text = name_E;
                txtGender.Text = gender_E;
                txtAddress.Text = address_E;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LastCreditItemsTable(string customerId, DateTime lastCreditDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string saleDate = lastCreditDate.ToString("dd/MMM/yy") + "%";
                if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Sale.Quantity AS Quantity, Sale.Rate AS Rate, Sale.Discount AS Discount, Sale.Price AS Price, Sale.CustomerID AS CustomerID, Sale.Sale_Date AS Sale_Date FROM Product, Sale WHERE Product.ProductID=Sale.ProductID AND Sale.CustomerID = @customerId AND Sale.Sale_Date LIKE '" + saleDate + "'  ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@customerId", customerId);
                }
                else if (cboLanguage.SelectedItem.ToString() == "English")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Sale.Quantity AS Quantity, Sale.Rate AS Rate, Sale.Discount AS Discount, Sale.Price AS Price, Sale.CustomerID AS CustomerID, Sale.Sale_Date AS Sale_Date FROM Product, Sale WHERE Product.ProductID=Sale.ProductID AND Sale.CustomerID = @customerId AND Sale.Sale_Date LIKE '" + saleDate + "' ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@customerId", customerId);
                }
                command.CommandType = CommandType.Text;
                //
                DataTable currentCreditItems = new DataTable();
                currentCreditItems.Columns.Add("ProductID");
                currentCreditItems.Columns.Add("ProductName");
                currentCreditItems.Columns.Add("ProductType");
                currentCreditItems.Columns.Add("Quantity");
                currentCreditItems.Columns.Add("Rate");
                currentCreditItems.Columns.Add("Discount");
                currentCreditItems.Columns.Add("Price");
                currentCreditItems.Columns.Add("Sale_Date");
                //
                int price = 0;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = currentCreditItems.NewRow();
                    row["ProductID"] = reader["ProductID"];
                    if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                    {
                        row["ProductName"] = reader["ProductName_Myanmar"];
                        row["ProductType"] = reader["ProductType_Myanmar"];
                    }
                    else if (cboLanguage.SelectedItem.ToString() == "English")
                    {
                        row["ProductName"] = reader["ProductName_English"];
                        row["ProductType"] = reader["ProductType_English"];
                    }
                    row["Quantity"] = reader["Quantity"];
                    row["Rate"] = reader["Rate"];
                    row["Discount"] = reader["Discount"];
                    row["Price"] = reader["Price"];
                    row["Sale_Date"] = reader["Sale_Date"];
                    currentCreditItems.Rows.Add(row);
                    //
                    price += Convert.ToInt32(reader["Price"]);
                }
                reader.Close();
                //
                dgvLastCreditItems.DataSource = currentCreditItems;
                dgvLastCreditItems.Font = new Font("Zawgyi-One", 11f);
                dgvLastCreditItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void CurrentCreditItemsTable(string customerId, DateTime currentCreditDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string saleDate = currentCreditDate.ToString("dd/MMM/yy") + "%";
                if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Sale.Quantity AS Quantity, Sale.Rate AS Rate, Sale.Discount AS Discount, Sale.Price AS Price, Sale.CustomerID AS CustomerID, Sale.Sale_Date AS Sale_Date FROM Product, Sale WHERE Product.ProductID=Sale.ProductID AND Sale.CustomerID = @customerId AND Sale.Sale_Date LIKE '" + saleDate + "'  ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@customerId", customerId);
                }
                else if (cboLanguage.SelectedItem.ToString() == "English")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Sale.Quantity AS Quantity, Sale.Rate AS Rate, Sale.Discount AS Discount, Sale.Price AS Price, Sale.CustomerID AS CustomerID, Sale.Sale_Date AS Sale_Date FROM Product, Sale WHERE Product.ProductID=Sale.ProductID AND Sale.CustomerID = @customerId AND Sale.Sale_Date LIKE '" + saleDate + "' ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@customerId", customerId);
                }
                command.CommandType = CommandType.Text;
                //
                DataTable currentCreditItems = new DataTable();
                currentCreditItems.Columns.Add("ProductID");
                currentCreditItems.Columns.Add("ProductName");
                currentCreditItems.Columns.Add("ProductType");
                currentCreditItems.Columns.Add("Quantity");
                currentCreditItems.Columns.Add("Rate");
                currentCreditItems.Columns.Add("Discount");
                currentCreditItems.Columns.Add("Price");
                currentCreditItems.Columns.Add("Sale_Date");
                //
                int price = 0;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = currentCreditItems.NewRow();
                    row["ProductID"] = reader["ProductID"];
                    if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                    {
                        row["ProductName"] = reader["ProductName_Myanmar"];
                        row["ProductType"] = reader["ProductType_Myanmar"];
                    }
                    else if (cboLanguage.SelectedItem.ToString() == "English")
                    {
                        row["ProductName"] = reader["ProductName_English"];
                        row["ProductType"] = reader["ProductType_English"];
                    }
                    row["Quantity"] = reader["Quantity"];
                    row["Rate"] = reader["Rate"];
                    row["Discount"] = reader["Discount"];
                    row["Price"] = reader["Price"];
                    row["Sale_Date"] = reader["Sale_Date"];
                    currentCreditItems.Rows.Add(row);
                    //
                    price += Convert.ToInt32(reader["Price"]);
                }
                reader.Close();
                //
                dgvCurrentCreditItems.DataSource = currentCreditItems;
                dgvCurrentCreditItems.Font = new Font("Zawgyi-One", 11f);
                dgvCurrentCreditItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

       private void pbLock_Click(object sender, EventArgs e)
        {
            
            string customerId = txtCustomerID.Text;
            DateTime lastCreditDate = Convert.ToDateTime(lblLastCreditDate.Text);
            LastCreditItemsTable(customerId, lastCreditDate);
            //
            DateTime currentCreditDate = Convert.ToDateTime(lblCurrentCreditDate.Text);
            CurrentCreditItemsTable(customerId, currentCreditDate);
            //
            tcCreditItems.Visible = true;
            //
            pbLock.Visible = false;
            
        }

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerId = txtCustomerID.Text;
            DateTime lastCreditDate = Convert.ToDateTime(lblLastCreditDate.Text);
            LastCreditItemsTable(customerId, lastCreditDate);
            //
            DateTime currentCreditDate = Convert.ToDateTime(lblCurrentCreditDate.Text);
            CurrentCreditItemsTable(customerId, currentCreditDate);
            //
            if (cboLanguage.SelectedItem.ToString() == "Myanmar")
            {
                lblName.Text = "အမည္";
                lblGender.Text = "က်ား၊မ";
            }
            else if (cboLanguage.SelectedItem.ToString() == "English")
            {
                lblName.Text = "Name";
                lblGender.Text = "Gender";
                lblAddress.Text = "Address";
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            CreditorsRevoke cr = new CreditorsRevoke(txtCustomerID.Text);
            cr.Show();
            //
            this.Close();
        }
    }
}
