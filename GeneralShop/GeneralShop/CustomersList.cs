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
    public partial class CustomersList : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        public CustomersList()
        {
            InitializeComponent();
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {
            string language = "English";
            CustomersTable(language);
        }

        public void CustomersTable(string language)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT CustomerID, Name_English, Gender_English, Address_English, Name_Myanmar, Gender_Myanmar, Address_Myanmar FROM Customers";
                command.CommandType = CommandType.Text;
                //
                DataTable customers = new DataTable();
                customers.Columns.Add("CustomerID");
                customers.Columns.Add("Name");
                customers.Columns.Add("Gender");
                customers.Columns.Add("Address");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = customers.NewRow();
                    row["CustomerID"] = reader["CustomerID"];
                    if (language == "English")
                    {
                        row["Name"] = reader["Name_English"];
                        row["Gender"] = reader["Gender_English"];
                        row["Address"] = reader["Address_English"];
                    }
                    else if (language == "Myanmar")
                    {
                        row["Name"] = reader["Name_Myanmar"];
                        row["Gender"] = reader["Gender_Myanmar"];
                        row["Address"] = reader["Address_Myanmar"];
                    }
                    customers.Rows.Add(row);
                }
                reader.Close();
                dgvCustomersList.DataSource = customers;
                dgvCustomersList.Font = new Font("Zawgyi-One", 11f);
                dgvCustomersList.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
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

        private void myanmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string language = myanmarToolStripMenuItem.Text;
            CustomersTable(language);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string language = englishToolStripMenuItem.Text;
            CustomersTable(language);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CustomersRegistration registration = new CustomersRegistration();
            registration.Show();
        }
    }
}
