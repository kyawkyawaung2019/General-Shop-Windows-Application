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
    public partial class CustomersRegistration : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        public CustomersRegistration()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            string customerId = txtCustomerID.Text;
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
                lbCustomerID.Items.Clear();
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbCustomerID.Items.Add(reader["CustomerID"].ToString());
                    name_E = reader["Name_E"].ToString();
                    gender_E = reader["Gender_E"].ToString();
                    address_E = reader["Address_E"].ToString();
                    name_M = reader["Name_M"].ToString();
                    gender_M = reader["gender_M"].ToString();
                    address_M = reader["address_M"].ToString();
                }
                reader.Close();
                //
                txtName_E.Text = name_E;
                if (gender_E == "Male")
                {
                    cboGender_E.SelectedIndex = 0;
                }
                else if(gender_E == "Female")
                {
                    cboGender_E.SelectedIndex = 1;
                }
                else
                {
                    cboGender_E.SelectedIndex = -1;
                }
                txtAddress_E.Text = address_E;
                //
                txtName_M.Text = name_M;
                if (gender_M == "က်ား")
                {
                    cboGender_M.SelectedIndex = 0;
                }
                else if(gender_M == "မ")
                {
                    cboGender_M.SelectedIndex = 1;
                }
                else
                {
                    cboGender_M.SelectedIndex = -1;
                }
                txtAddress_M.Text = address_M;
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
            if(lbCustomerID.Items.Count < 1 && txtCustomerID.Text != string.Empty)
            {
                btnRegister.Enabled = true;
                //
                txtName_E.Enabled = true;
                cboGender_E.Enabled = true;
                txtAddress_E.Enabled = true;
                //
                txtName_M.Enabled = true;
                cboGender_M.Enabled = true;
                txtAddress_M.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
                //
                txtName_E.Enabled = false;
                cboGender_E.Enabled = false;
                txtAddress_E.Enabled = false;
                //
                txtName_M.Enabled = false;
                cboGender_M.Enabled = false;
                txtAddress_M.Enabled = false;
            }
        }

        public void InsertDataCustomersTable(string customerId, string name_E, string gender_E, string address_E, string name_M, string gender_M, string address_M)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //
                command.CommandText = @"INSERT INTO Customers(CustomerID, Name_English, Gender_English, Address_English, Name_Myanmar, Gender_Myanmar, Address_Myanmar) VALUES(@customerId, @name_E, @gender_E, @address_E, @name_M, @gender_M, @address_M)";
                //
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@name_E", name_E);
                command.Parameters.AddWithValue("@gender_E", gender_E);
                command.Parameters.AddWithValue("@address_E", address_E);
                command.Parameters.AddWithValue("@name_M", name_M);
                command.Parameters.AddWithValue("@gender_M", gender_M);
                command.Parameters.AddWithValue("@address_M", address_M);
                command.ExecuteNonQuery();
                //
                MessageBox.Show("Registration is successfully!", "Successfully");
            }
            catch
            {
                MessageBox.Show("Something is wrong! \n Please check the data carefully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void InsertDataCreditorsTable(string customerId, DateTime creditDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //
                command.CommandText = @"INSERT INTO Creditors(CustomerID, CreditDate) VALUES(@customerId, @creditDate)";
                //
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@creditDate", creditDate);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Something is wrong! \n Please check the data carefully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void CustomersRegistration_Load(object sender, EventArgs e)
        {
            txtCustomerID.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != string.Empty && txtName_E.Text != string.Empty && cboGender_E.SelectedIndex > -1 && txtAddress_E.Text != string.Empty && txtName_M.Text != string.Empty && cboGender_M.SelectedIndex > -1 && txtAddress_M.Text != string.Empty)
            {
                string customerId = txtCustomerID.Text;
                string name_E = txtName_E.Text;
                string gender_E = cboGender_E.SelectedItem.ToString();
                string address_E = txtAddress_E.Text;
                //
                string name_M = txtName_M.Text;
                string gender_M = cboGender_M.SelectedItem.ToString();
                string address_M = txtAddress_M.Text;
                //
                DialogResult result = MessageBox.Show("CustomerID     : " + customerId + "\nName      : " + name_E + "\nGender        : " + gender_E + "\nAddress     : " + address_E, "Customer Information", MessageBoxButtons.OKCancel);
                if (result.ToString() == "OK")
                {
                    InsertDataCustomersTable(customerId, name_E, gender_E, address_E, name_M, gender_M, address_M);
                    //
                    DateTime creditDate = Convert.ToDateTime(DateTime.Now.ToString());
                    InsertDataCreditorsTable(customerId, creditDate);
                    //
                    txtCustomerID.Clear();
                    txtName_E.Clear();
                    cboGender_E.SelectedIndex = -1;
                    txtAddress_E.Clear();
                    //
                    txtName_M.Clear();
                    cboGender_M.SelectedIndex = -1;
                    txtAddress_M.Clear();
                    //
                    txtCustomerID.Focus();
                }
                else
                {
                    MessageBox.Show("Registration is unsuccessfully!", "Retry");
                }
            }
            else
            {
                MessageBox.Show("Please Insert Data", "Message");
                txtCustomerID.Focus();
            }
        }
    }
}
