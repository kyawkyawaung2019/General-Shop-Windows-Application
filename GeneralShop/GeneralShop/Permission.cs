using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GeneralShop
{
    public partial class Permission : Form
    {
         string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        private string name = string.Empty;
        //
        public Permission(string name)
        {
            InitializeComponent();
            //
            this.name = name;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = null;
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                //
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT StaffID, Name_English, Occupation_English, Name_Myanmar, Occupation_Myanmar FROM Staff WHERE UserName=@username AND Password=@password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //
                command.CommandType = CommandType.Text;
                //
                OleDbDataReader reader = command.ExecuteReader();
                string staffID = string.Empty;
                string name_English = string.Empty;
                string occupation_English = string.Empty;
                string name_Myanmar = string.Empty;
                string occupation_Myanmar = string.Empty;
                //
                while (reader.Read())
                {
                    staffID = reader["StaffID"].ToString();
                    name_English = reader["Name_English"].ToString();
                    occupation_English = reader["Occupation_English"].ToString();
                    name_Myanmar = reader["Name_Myanmar"].ToString();
                    occupation_Myanmar = reader["Occupation_Myanmar"].ToString();
                }
                reader.Close();
                //
                if (staffID != string.Empty)
                {
                    if (name == "pbSale" || name == "lblSale")
                    {
                        Sale sale = new Sale(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        sale.Show();
                    }
                    else if (name == "pbPurchase" || name == "lblPurchase")
                    {
                        Purchase purchase = new Purchase(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        purchase.Show();
                    }
                    else if (name == "pbReport" || name == "lblReport")
                    {
                        Report report = new Report(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        report.Show();
                    }
                    else if (name == "pbStock" || name == "lblStock")
                    {
                        Stock stock = new Stock(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        stock.Show();
                    }
                    else if (name == "pbCustomers" || name == "lblCustomers")
                    {
                        Customers customers = new Customers(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        customers.Show();
                    }
                    else if (name == "pbSuppliers" || name == "lblSuppliers")
                    {
                        Suppliers suppliers = new Suppliers(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        suppliers.Show();
                    }
                    else if (name == "pbCreditors" || name == "lblCreditors")
                    {
                        Creditors creditors = new Creditors(staffID, name_English, occupation_English, name_Myanmar, occupation_Myanmar);
                        creditors.Show();
                    }
                    //
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Either Username or Password is Incorrent!\nPlease try again!", "Error");
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty)
            {
                string password = txtPassword.Text;
                //
                OleDbConnection connection = null;
                try
                {
                    connection = new OleDbConnection(connectionString);
                    connection.Open();
                    //
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Staff WHERE Password=@password";
                    command.Parameters.AddWithValue("@password", password);
                    command.CommandType = CommandType.Text;
                    //
                    int count = (int)command.ExecuteScalar();
                    //
                    if (count > 0)
                    {
                        txtPassword.Enabled = false;
                        btnPermission.Visible = true;
                        btnPermission.Focus();
                    }
                    else
                    {
                        btnPermission.Visible = false;
                    }
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
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty)
            {
                string username = txtUsername.Text;
                //
                OleDbConnection connection = null;
                try
                {
                    connection = new OleDbConnection(connectionString);
                    connection.Open();
                    //
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Staff WHERE UserName=@username";
                    command.Parameters.AddWithValue("@username", username);
                    command.CommandType = CommandType.Text;
                    //
                    int count = (int)command.ExecuteScalar();
                    //
                    if (count > 0)
                    {
                        txtUsername.Enabled = false;
                        lblPassword.Visible = true;
                        txtPassword.Visible = true;
                        txtPassword.Focus();
                    }
                    else
                    {
                        lblPassword.Visible = false;
                        txtPassword.Visible = false;
                    }
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
        }
    }
}
