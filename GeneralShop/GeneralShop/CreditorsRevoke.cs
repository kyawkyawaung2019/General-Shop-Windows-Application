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
    public partial class CreditorsRevoke : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        string customerId = null;
        //
        public CreditorsRevoke(string customerId)
        {
            InitializeComponent();
            //
            this.customerId = customerId;
        }

        private void CreditorsRevoke_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = customerId;
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            CreditorsTable(txtCustomerID.Text);
        }

        public void CreditorsTable(string customerId)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT Customers.CustomerID AS CustomerID, Customers.Name_English AS Name_E, Customers.Gender_English AS Gender_E, Customers.Address_English AS Address_E, Customers.Name_Myanmar AS Name_M, Customers.Gender_Myanmar AS Gender_M, Customers.Address_Myanmar AS Address_M, Creditors.CreditAmount AS CreditAmount, Creditors.CreditDate AS CreditDate FROM Customers, Creditors WHERE Customers.CustomerID=Creditors.CustomerID AND Customers.CustomerID=@customerId ORDER BY Customers.CustomerID";
                //command.CommandText = @"SELECT Customers.CustomerID AS CustomerID, Customers.Name_English AS Name_E, Customers.Gender_English AS Gender_E, Customers.Address_English AS Address_E, Customers.Name_Myanmar AS Name_M, Customers.Gender_Myanmar AS Gender_M, Customers.Address_Myanmar AS Address_M, Creditors.CreditAmount AS CreditAmount, Creditors.CreditDate AS CreditDate FROM Customers, Creditors WHERE Customers.CustomerID=Creditors.CustomerID AND Customers.CustomerID=@customerId ORDER BY Customers.CustomerID";

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
                int creditAmount = 0;
                DateTime creditDate = Convert.ToDateTime(DateTime.Now.ToString());
                //
                lbCustomerID.Items.Clear();
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbCustomerID.Items.Add(reader["CustomerID"].ToString());
                    //
                    name_E = reader["Name_E"].ToString();
                    gender_E = reader["Gender_E"].ToString();
                    address_E = reader["Address_E"].ToString() ;
                    //
                    name_M = reader["Name_M"].ToString();
                    gender_M = reader["Gender_M"].ToString();
                    address_M = reader["Address_M"].ToString();
                    //
                    creditAmount = Convert.ToInt32(reader["CreditAmount"].ToString());
                    creditDate = Convert.ToDateTime(reader["CreditDate"]);
                }
                reader.Close();
                //
                txtName.Text = name_E;
                txtGender.Text = gender_E;
                txtAddress.Text = address_E;
                //
                txtName_M.Text = name_M;
                txtGender_M.Text = gender_M;
                txtAddress_M.Text = address_M;
                txtTotalCredit.Text = Convert.ToString(creditAmount);
                lblCreditDate.Text = "(" + creditDate.ToString("dd/MMM/yyyy") + ")";
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

        private void txtRevokeAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtRevokeAmount.Text != string.Empty)
            {
                int totalCredit = Convert.ToInt32(txtTotalCredit.Text);
                int revokeAmount = Convert.ToInt32(txtRevokeAmount.Text);
                int credit = totalCredit - revokeAmount;
                txtCredit.Text = Convert.ToString(credit);
            }
            else
            {
                txtCredit.Text = txtTotalCredit.Text;
            }
            //
            if (txtRevokeAmount.Text != string.Empty)
            {
                btnRevoke.Enabled = true;
            }
            else
            {
                btnRevoke.Enabled = false;
            }
        }

        public void UpdateDataCreditorsTable(string customerId, int amount, int payment, int creditAmount, DateTime creditDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"UPDATE Creditors SET Amount=@amount, Payment=@payment, CreditAmount=@creditAmount, CreditDate=@creditDate WHERE CustomerID=@customerId";
                command.CommandType = CommandType.Text;
                //
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@Payment", payment);
                command.Parameters.AddWithValue("@totalCredit", creditAmount);
                command.Parameters.AddWithValue("@creditDate", creditDate);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.ExecuteNonQuery();
                //
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

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerID.Text;
            int amount = 0;
            int payment = 0;
            int creditAmount = Convert.ToInt32(txtCredit.Text);
            DateTime creditDate = Convert.ToDateTime(DateTime.Now.ToString());
            //
            UpdateDataCreditorsTable(customerId, amount, payment, creditAmount, creditDate);
            //
            MessageBox.Show("OK");
            //
            txtCustomerID.Text = string.Empty;
            txtRevokeAmount.Text = string.Empty;
            txtCustomerID.Focus();
        }

        private void txtRevokeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                txtRevokeAmount.Enabled = true;
            }
            else
            {
                txtRevokeAmount.Enabled = false;
            }
        }

        private void txtTotalCredit_TextChanged(object sender, EventArgs e)
        {
            txtCredit.Text = txtTotalCredit.Text;
        }
    }
}
