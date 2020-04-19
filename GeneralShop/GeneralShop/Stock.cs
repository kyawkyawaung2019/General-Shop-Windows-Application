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
    public partial class Stock : Form
    {
        //Global Variables
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        private string staffID = string.Empty;
        private string name_English = string.Empty;
        private string occupation_English = string.Empty;
        private string name_Myanmar = string.Empty;
        private string occupation_Myanmar = string.Empty;
        //
        public Stock(string staffID, string name_English, string occupation_English, string name_Myanmar, string occupation_Myanmar)
        {
            InitializeComponent();
            //
            this.staffID = staffID;
            this.name_English = name_English;
            this.occupation_English = occupation_English;
            this.name_Myanmar = name_Myanmar;
            this.occupation_Myanmar = occupation_Myanmar;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = name_English;
            //
            cboLanguage.SelectedIndex = 0;
            //
            cboProductGroup.SelectedIndex = 0;
            cboProductType.SelectedIndex = 0;
            cboProductName.SelectedIndex = 0;
            //
            ProductGroupSearchList(cboProductGroup);
            ProductTypeSearchList(cboProductGroup, cboProductType);
            ProductNameSearchList(cboProductGroup, cboProductType, cboProductName);
            //
            txtProductID.Focus();
        }

        #region MenuStrip Functions

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        public void ProductListTable(string group, string type, string name)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (group == "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID ORDER BY Product.ProductID";
                }

                else if (group != "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                }

                else if (group == "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductType_Myanmar=@type ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group == "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductName_Myanmar=@name ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group != "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductType_Myanmar=@type ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group != "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductName_Myanmar=@name ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group == "ALL" && type != "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductType_Myanmar=@type AND ProductName_Myanmar=@name ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                else
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductType_Myanmar=@type AND ProductName_Myanmar=@name ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                command.CommandType = CommandType.Text;
                //
                DataTable product = new DataTable();
                product.Columns.Add("ProductID");
                product.Columns.Add("ProductName_English");
                product.Columns.Add("ProductType_English");
                product.Columns.Add("ProductGroup_English");
                /*
                product.Columns.Add("ProductName_Myanmar");
                product.Columns.Add("ProductType_Myanmar");
                product.Columns.Add("ProductGroup_Myanmar");
                */
                product.Columns.Add("LocationID");
                product.Columns.Add("Rate");
                product.Columns.Add("Quantity");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = product.NewRow();
                    row["ProductID"] = reader["ProductID"];
                    if (cboLanguage.SelectedItem.ToString() == "English")
                    {
                        row["ProductName_English"] = reader["ProductName_English"];
                        row["ProductType_English"] = reader["ProductType_English"];
                        row["ProductGroup_English"] = reader["ProductGroup_English"];
                    }
                    else if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                    {
                        row["ProductName_English"] = reader["ProductName_Myanmar"];
                        row["ProductType_English"] = reader["ProductType_Myanmar"];
                        row["ProductGroup_English"] = reader["ProductGroup_Myanmar"];
                    }
                    row["LocationID"] = reader["LocationID"];
                    row["Rate"] = reader["Rate"];
                    row["Quantity"] = reader["Quantity"];
                    product.Rows.Add(row);
                }
                reader.Close();
                dgvProductList.DataSource = product;
                dgvProductList.Font = new Font("Zawgyi-One", 11f);
                dgvProductList.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
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

        private void ProductNameSearchList(ComboBox cboGroup, ComboBox cboType, ComboBox cboName)
        {
            cboName.Items.Clear();
            cboName.Items.Add("ALL");
            cboName.SelectedIndex = 0;
            //
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (cboGroup.SelectedItem.ToString() == "ALL" && cboType.SelectedItem.ToString() == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductName_Myanmar AS ProductName_Myanmar FROM Product GROUP BY ProductName_Myanmar) ORDER BY ProductName_Myanmar";
                }
                else if (cboGroup.SelectedItem.ToString() != "ALL" && cboType.SelectedItem.ToString() == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductName_Myanmar AS ProductName_Myanmar FROM Product WHERE Product.ProductGroup_Myanmar=@cbogroup GROUP BY ProductName_Myanmar) ORDER BY ProductName_Myanmar";
                    command.Parameters.AddWithValue("@cboGroup", cboGroup.SelectedItem.ToString());
                }
                else if (cboGroup.SelectedItem.ToString() == "ALL" && cboType.SelectedItem.ToString() != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductName_Myanmar AS ProductName_Myanmar FROM Product WHERE Product.ProductType_Myanmar=@cboType GROUP BY ProductName_Myanmar) ORDER BY ProductName_Myanmar";
                    command.Parameters.AddWithValue("@cboType", cboType.SelectedItem.ToString());
                }
                else
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductName_Myanmar AS ProductName_Myanmar FROM Product WHERE Product.ProductGroup_Myanmar=@cboGroup AND Product.ProductType_Myanmar=@cboType GROUP BY ProductName_Myanmar) ORDER BY ProductName_Myanmar";
                    command.Parameters.AddWithValue("@cboGroup", cboGroup.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@cboType", cboType.SelectedItem.ToString());
                }
                command.CommandType = CommandType.Text;
                //
                DataTable product = new DataTable();
                product.Columns.Add("ProductName_Myanmar");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = product.NewRow();
                    row["ProductName_Myanmar"] = reader["ProductName_Myanmar"];
                    product.Rows.Add(row);
                }
                reader.Close();
                //
                foreach (DataRow row in product.Rows)
                {
                    if (cboName.Name.ToString() == "cboProductName")
                    {
                        cboProductName.Items.Add(row[0].ToString());
                    }
                    else
                    {
                        //cboSearchByProductName.Items.Add(row[0].ToString());
                    }
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

        private void ProductTypeSearchList(ComboBox cboGroup, ComboBox cboType)
        {
            cboType.Items.Clear();
            cboType.Items.Add("ALL");
            cboType.SelectedIndex = 0;
            //
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (cboGroup.SelectedItem.ToString() == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductType_Myanmar AS ProductType_Myanmar FROM Product GROUP BY ProductType_Myanmar) ORDER BY ProductType_Myanmar";
                }
                else
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductType_Myanmar AS ProductType_Myanmar FROM Product WHERE Product.ProductGroup_Myanmar=@cboGroup GROUP BY ProductType_Myanmar) ORDER BY ProductType_Myanmar";
                    command.Parameters.AddWithValue("@cboGroup", cboGroup.SelectedItem.ToString());
                }
                command.CommandType = CommandType.Text;
                //
                DataTable product = new DataTable();
                product.Columns.Add("ProductType_Myanmar");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = product.NewRow();
                    row["ProductType_Myanmar"] = reader["ProductType_Myanmar"];
                    product.Rows.Add(row);
                }
                reader.Close();
                //
                foreach (DataRow row in product.Rows)
                {
                    if (cboType.Name.ToString() == "cboProductType")
                    {
                        cboProductType.Items.Add(row[0].ToString());
                    }
                    else
                    {
                        //cboSearchByProductType.Items.Add(row[0].ToString());
                    }
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

        private void ProductGroupSearchList(ComboBox cboGroup)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM (SELECT Product.ProductGroup_Myanmar AS ProductGroup_Myanmar FROM Product GROUP BY ProductGroup_Myanmar) ORDER BY ProductGroup_Myanmar";
                command.CommandType = CommandType.Text;
                //
                DataTable product = new DataTable();
                product.Columns.Add("ProductGroup_Myanmar");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = product.NewRow();
                    row["ProductGroup_Myanmar"] = reader["ProductGroup_Myanmar"];
                    product.Rows.Add(row);
                }
                reader.Close();
                //
                foreach (DataRow row in product.Rows)
                {
                    if (cboGroup.Name.ToString() == "cboProductGroup")
                    {
                        cboProductGroup.Items.Add(row[0].ToString());
                    }
                    else
                    {
                        //cboSearchByProductGroup.Items.Add(row[0].ToString());
                    }
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

        private void cboProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
            {
                string group = cboProductGroup.SelectedItem.ToString();
                string type = cboProductType.SelectedItem.ToString();
                string name = cboProductName.SelectedItem.ToString();
                //
                ProductListTable(group, type, name);
                //
                ProductTypeSearchList(cboProductGroup, cboProductType);
                ProductNameSearchList(cboProductGroup, cboProductType, cboProductName);
            }
        }

        private void cboProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
            {
                string group = cboProductGroup.SelectedItem.ToString();
                string type = cboProductType.SelectedItem.ToString();
                string name = cboProductName.SelectedItem.ToString();
                //
                ProductListTable(group, type, name);
                //
                ProductNameSearchList(cboProductGroup, cboProductType, cboProductName);
            }
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
            {
                string group = cboProductGroup.SelectedItem.ToString();
                string type = cboProductType.SelectedItem.ToString();
                string name = cboProductName.SelectedItem.ToString();
                //
                ProductListTable(group, type, name);
            }
        }

        private void pbLock_Click(object sender, EventArgs e)
        {
            if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
            {
                lblName.Visible = true;
                cboProductName.Visible = true;
                lblType.Visible = true;
                cboProductType.Visible = true;
                lblGroup.Visible = true;
                cboProductGroup.Visible = true;
                dgvProductList.Visible = true;
                pbLock.Visible = false;
                //
                string group = cboProductGroup.SelectedItem.ToString();
                string type = cboProductType.SelectedItem.ToString();
                string name = cboProductName.SelectedItem.ToString();
                ProductListTable(group, type, name);
            }
        }

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
            {
                string group = cboProductGroup.SelectedItem.ToString();
                string type = cboProductType.SelectedItem.ToString();
                string name = cboProductName.SelectedItem.ToString();
                ProductListTable(group, type, name);
            }
        }

        public void InsertDataProductTable(string productId, string productName_E, string productType_E, string productGroup_E, string productName_M, string productType_M, string productGroup_M, string locationId)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //
                command.CommandText = @"INSERT INTO Product(ProductID, ProductName_English, ProductType_English, ProductGroup_English, ProductName_Myanmar, ProductType_Myanmar, ProductGroup_Myanmar, LocationID) VALUES(@productId, @productNameE, @productTypeE, @productGroupE, @productNameM, @productTypeM, @productGroupM, @locationId)";
                //
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@productNameE", productName_E);
                command.Parameters.AddWithValue("@productTypeE", productType_E);
                command.Parameters.AddWithValue("@productGroupE", productGroup_E);
                command.Parameters.AddWithValue("@productNameM", productName_M);
                command.Parameters.AddWithValue("@productTypeM", productType_M);
                command.Parameters.AddWithValue("@productGroupM", productGroup_M);
                command.Parameters.AddWithValue("@locationId", locationId);
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

        public void InsertDataStockTable(string productId, int quantity,int rate, DateTime lastUpdate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //
                command.CommandText = @"INSERT INTO Stock(ProductID, Quantity, Rate, LastUpdate) VALUES(@productId, @quantity, @rate, @lastUpdate)";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@rate", rate);
                command.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                command.ExecuteNonQuery();
                //
                MessageBox.Show("Successfully!", "OK");
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != string.Empty && txtProductName_E.Text != string.Empty && txtProductType_E.Text != string.Empty && txtProductGroup_E.Text != string.Empty && txtProductName_M.Text != string.Empty && txtProductType_M.Text != string.Empty && txtProductGroup_M.Text != string.Empty && txtLocationID.Text != string.Empty && txtRate.Text != string.Empty)
            {
                string productId = txtProductID.Text.ToString();
                string productNameE = txtProductName_E.Text.ToString();
                string productTypeE = txtProductType_E.Text.ToString();
                string productGroupE = txtProductGroup_E.Text.ToString();
                string productNameM = txtProductName_M.Text.ToString();
                string productTypeM = txtProductType_M.Text.ToString();
                string productGroupM = txtProductGroup_M.Text.ToString();
                string locationId = txtLocationID.Text.ToString();
                //
                int quantity = 0;
                int rate = Convert.ToInt32(txtRate.Text);
                DateTime dt = Convert.ToDateTime(DateTime.Now.ToString());
                //
                InsertDataProductTable(productId, productNameE, productTypeE, productGroupE, productNameM, productTypeM, productGroupM, locationId);
                InsertDataStockTable(productId, quantity, rate, dt);
                //
                txtProductID.Text = string.Empty;
                txtProductName_E.Text = string.Empty;
                txtProductType_E.Text = string.Empty;
                txtProductGroup_E.Text = string.Empty;
                txtProductName_M.Text = string.Empty;
                txtProductType_M.Text = string.Empty;
                txtProductGroup_M.Text = string.Empty;
                txtRate.Text = string.Empty;
                //
                if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
                {
                    string group = cboProductGroup.SelectedItem.ToString();
                    string type = cboProductType.SelectedItem.ToString();
                    string name = cboProductName.SelectedItem.ToString();
                    ProductListTable(group, type, name);
                }
            }
            else
            {
                MessageBox.Show("Error!\n Registration has been disabled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtProductID.Focus();
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
