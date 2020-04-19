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
    public partial class Creditors : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        private string staffID = string.Empty;
        private string name_English = string.Empty;
        private string occupation_English = string.Empty;
        private string name_Myanmar = string.Empty;
        private string occupation_Myanmar = string.Empty;
        //
        string creditorId = string.Empty;

        public Creditors(string staffID, string name_English, string occupation_English, string name_Myanmar, string occupation_Myanmar)
        {
            InitializeComponent();
            //
            this.staffID = staffID;
            this.name_English = name_English;
            this.occupation_English = occupation_English;
            this.name_Myanmar = name_Myanmar;
            this.occupation_Myanmar = occupation_Myanmar;
        }

        #region Menustrip functions

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Creditors_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = name_English;
            //
            cboLanguage.SelectedIndex = 0;
            //
            CreditorsTable(cboLanguage.SelectedItem.ToString());
        }

        private void btnCreditorsRevoke_Click(object sender, EventArgs e)
        {

            CreditorsRevoke creditorsRevoke = new CreditorsRevoke(creditorId);
            creditorsRevoke.Show();
        }

        public void CreditorsTable(string language)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT Customers.CustomerID AS CustomerID, Customers.Name_English AS Name_E, Customers.Gender_English AS Gender_E, Customers.Address_English AS Address_E, Customers.Name_Myanmar AS Name_M, Customers.Gender_Myanmar AS Gender_M, Customers.Address_Myanmar AS Address_M, Creditors.CreditAmount AS CreditAmount, Creditors.CreditDate AS CreditDate FROM Customers, Creditors WHERE Customers.CustomerID=Creditors.CustomerID AND Creditors.CreditAmount>0 ORDER BY Customers.CustomerID";
                command.CommandType = CommandType.Text;
                //
                DataTable customers = new DataTable();
                customers.Columns.Add("CustomerID");
                customers.Columns.Add("Name");
                customers.Columns.Add("Gender");
                customers.Columns.Add("Address");
                customers.Columns.Add("CreditAmount");
                customers.Columns.Add("CreditDate");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = customers.NewRow();
                    row["CustomerID"] = reader["CustomerID"];
                    if (language == "English")
                    {
                        row["Name"] = reader["Name_E"];
                        row["Gender"] = reader["Gender_E"];
                        row["Address"] = reader["Address_E"];
                        row["CreditAmount"] = reader["CreditAmount"];
                        row["CreditDate"] = reader["CreditDate"];
                    }
                    else if (language == "Myanmar")
                    {
                        row["Name"] = reader["Name_M"];
                        row["Gender"] = reader["Gender_M"];
                        row["Address"] = reader["Address_M"];
                        row["CreditAmount"] = reader["CreditAmount"];
                        row["CreditDate"] = reader["CreditDate"];
                    }
                    customers.Rows.Add(row);
                }
                reader.Close();
                dgvCreditorsList.DataSource = customers;
                dgvCreditorsList.Font = new Font("Zawgyi-One", 11f);
                dgvCreditorsList.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
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

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLanguage.SelectedItem.ToString() == "English")
            {
                lblStaffName.Text = name_English;
                btnCreditorsRevoke.Text = "Creditors Revoke";
                btnCustomerRegistration.Text = "Customer Registration";
            }
            else if (cboLanguage.SelectedItem.ToString() == "Myanmar")
            {
                lblStaffName.Text = name_Myanmar;
                btnCreditorsRevoke.Text = "အေၾကြးဆပ္ျခင္း";
                btnCustomerRegistration.Text = "ဝယ္သူ မွတ္ပံုတင္ျခင္း";
            }
            //
            CreditorsTable(cboLanguage.SelectedItem.ToString());
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            CustomersRegistration cr = new CustomersRegistration();
            cr.Show();
        }
    }
}
