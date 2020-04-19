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
    public partial class Sale : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        DataTable currentSellingTable;
        //
        private string staffID = string.Empty;
        private string name_English = string.Empty;
        private string occupation_English = string.Empty;
        private string name_Myanmar = string.Empty;
        private string occupation_Myanmar = string.Empty;

        public Sale(string staffID, string name_English, string occupation_English, string name_Myanmar, string occupation_Myanmar)
        {
            InitializeComponent();
            //
            this.staffID = staffID;
            this.name_English = name_English;
            this.occupation_English = occupation_English;
            this.name_Myanmar = name_Myanmar;
            this.occupation_Myanmar = occupation_Myanmar;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = name_English;
            //
            cboLanguage.SelectedIndex = 0;
            //
            txtCustomerID.Text = "0000";
            //
            cboProductGroup.SelectedIndex = 0;
            cboProductType.SelectedIndex = 0;
            cboProductName.SelectedIndex = 0;
            //
            ProductGroupSearchList(cboProductGroup);
            ProductTypeSearchList(cboProductGroup, cboProductType);
            ProductNameSearchList(cboProductGroup, cboProductType, cboProductName);
            //
            txtCustomerID.Focus();
            //
            currentSellingTable = new DataTable();
            currentSellingTable.Columns.Add("ProductID");
            currentSellingTable.Columns.Add("ProductName");
            currentSellingTable.Columns.Add("ProductType");
            currentSellingTable.Columns.Add("Quantity");
            currentSellingTable.Columns.Add("Rate");
            currentSellingTable.Columns.Add("Amount");
            currentSellingTable.Columns.Add("Discount");
            currentSellingTable.Columns.Add("Total");
            currentSellingTable.Columns.Add("CustomerID");
        }

        #region External Function

        public void UpdateDataStockTable(string productId, int quantity)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"UPDATE Stock SET Quantity=Quantity - @quantity, LastUpdate=@lastUpdate WHERE ProductID=@productId";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString());
                command.Parameters.AddWithValue("@productId", productId);
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

        public void InsertDataSaleTable(string productId, int quantity, int rate, int amount, int discount, int price, string customerID, string staffID, DateTime saleDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Sale(ProductID, Quantity, Rate, Amount, Discount, Price, CustomerID, StaffID, Sale_Date) VALUES(@productId, @quantity, @rate, @amount, @discount, @price, @customerID, @staffID, @saleDate)";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@rate", rate);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@discount", discount);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@customerID", customerID);
                command.Parameters.AddWithValue("@staffID", staffID);
                command.Parameters.AddWithValue("@saleDate", saleDate);
                command.ExecuteNonQuery();
                //
                UpdateDataStockTable(productId, quantity);
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
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID";
                }

                else if (group != "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group";
                    command.Parameters.AddWithValue("@group", group);
                }

                else if (group == "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductType_Myanmar=@type";
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group == "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductName_Myanmar=@name";
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group != "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductType_Myanmar=@type";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group != "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductName_Myanmar=@name";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group == "ALL" && type != "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductType_Myanmar=@type AND ProductName_Myanmar=@name";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                else
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductType_Myanmar=@type AND ProductName_Myanmar=@name";
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

        private void TodaySellingItemsTable()
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string saleDate = DateTime.Now.ToString("dd/MMM/yy") + "%";
                if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID AS ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, ProductType_Myanmar AS ProductType_Myanmar, SUM(Sale.Quantity) AS Quantity, SUM(Sale.Price) AS Price FROM Product, Sale WHERE Product.ProductID=Sale.ProductID AND Sale.Sale_Date LIKE '" + saleDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar) ORDER BY Price";
                }
                else if (cboLanguage.SelectedItem.ToString() == "English")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, ProductType_English AS ProductType_English, SUM(Sale.Quantity) AS Quantity, SUM(Sale.Price) AS Price FROM Product, Sale WHERE Product.ProductID=Sale.ProductID AND Sale.Sale_Date LIKE '" + saleDate + "' GROUP BY Product.ProductID, Product.ProductName_English, Product.ProductType_English) ORDER BY Price";
                }
                command.CommandType = CommandType.Text;
                //
                DataTable todaySellingItems = new DataTable();
                todaySellingItems.Columns.Add("ProductID");
                todaySellingItems.Columns.Add("ProductName");
                todaySellingItems.Columns.Add("ProductType");
                todaySellingItems.Columns.Add("Quantity");
                todaySellingItems.Columns.Add("Price");
                //
                int price = 0;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = todaySellingItems.NewRow();
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
                    //row["Amount"] = reader["Amount"];
                    //row["Discount"] = reader["Discount"];
                    row["Price"] = reader["Price"];
                    //row["CustomerID"] = reader["CustomerID"];
                    todaySellingItems.Rows.Add(row);
                    //
                    price += Convert.ToInt32(reader["Price"]);
                }
                reader.Close();
                //
                txtTodaySellingAmount.Text = Convert.ToString(price);
                //
                dgvTodaySellingItems.DataSource = todaySellingItems;
                dgvTodaySellingItems.Font = new Font("Zawgyi-One", 11f);
                dgvTodaySellingItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
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

        private void CurrentSellingItemsTable()
        {
            string customerID = txtCustomerID.Text;
            string productID = txtProductID.Text;
            string productName = txtProductName.Text;
            string productType = txtProductType.Text;
            string quantity = txtQuantity.Text;
            string rate = txtRate.Text;
            string amount = txtAmount.Text;
            string discount = txtDiscount.Text;
            string total = txtTotal.Text;
            //
            DataRow row = currentSellingTable.NewRow();
            row["ProductID"] = productID;
            row["ProductName"] = productName;
            row["ProductType"] = productType;
            row["Quantity"] = quantity;
            row["Rate"] = rate;
            row["Amount"] = amount;
            row["Discount"] = discount;
            row["Total"] = total;
            row["CustomerID"] = customerID;
            currentSellingTable.Rows.Add(row);
            //        
            int sellingAmount = Convert.ToInt32(txtCurrentSellingAmount.Text) + Convert.ToInt32(txtTotal.Text);
            txtCurrentSellingAmount.Text = Convert.ToString(sellingAmount);
            //
            int repayAmount = Convert.ToInt32(txtCurrentSellingAmount.Text) - Convert.ToInt32(txtCustomerPay.Text);
            txtRepay.Text = Convert.ToString(repayAmount);
            //
            dgvCurrentSellingItems.DataSource = currentSellingTable;
            dgvCurrentSellingItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvCurrentSellingItems.Font = new Font("Zawgyi-one", 11F);
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

        #endregion

        #region Cash Sale

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != string.Empty && txtProductID.Text != string.Empty && txtProductName.Text != string.Empty && txtQuantity.Text != string.Empty && txtDiscount.Text != string.Empty)
            {
                string productID = txtProductID.Text.ToUpper();
                int quantity = Convert.ToInt32(txtQuantity.Text);
                int rate = Convert.ToInt32(txtRate.Text);
                int amount = Convert.ToInt32(txtAmount.Text);
                int discount = Convert.ToInt32(txtDiscount.Text);
                int price = Convert.ToInt32(txtTotal.Text);
                string customerID = txtCustomerID.Text;
                DateTime saleDate = DateTime.Parse(DateTime.Now.ToString());
                //
                DialogResult result = MessageBox.Show("Inserted data into Sale table!\n*******" + "\nProductID\t: " + productID + "\nQuantity\t\t: " + quantity + "\nRate\t\t: " + rate + "\nAmount\t\t: " + amount + "\nDiscount\t\t: " + discount + "\nPrice\t\t: " + price, "CONFIRM", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    InsertDataSaleTable(productID, quantity, rate, amount, discount, price, customerID, staffID, saleDate);
                    //
                    CurrentSellingItemsTable();
                    //
                    TodaySellingItemsTable();
                    //
                    txtCustomerID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Try & Correct", "Message");
                }
                txtProductID.Text = string.Empty;
                txtQuantity.Text = "0";
                txtRate.Text = "0";
                txtAmount.Text = "0";
                txtDiscount.Text = "0";
                txtTotal.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Insert Data!", "Message");
            }
            txtProductID.Focus();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            string productId = txtProductID.Text;
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Stock.Quantity AS AvailableQuantity, Stock.Rate AS Rate FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND Product.ProductID=@productId";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@productId", productId);
                //
                string productName_English = string.Empty;
                string productType_English = string.Empty;
                string productGroup_English = string.Empty;
                string productName_Myanmar = string.Empty;
                string productType_Myanmar = string.Empty;
                string productGroup_Myanmar = string.Empty;
                string availableQuantity = string.Empty;
                string rate = string.Empty;
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productName_English = reader["ProductName_English"].ToString();
                    productType_English = reader["ProductType_English"].ToString();
                    productGroup_English = reader["ProductGroup_English"].ToString();
                    productName_Myanmar = reader["ProductName_Myanmar"].ToString();
                    productType_Myanmar = reader["ProductType_Myanmar"].ToString();
                    productGroup_Myanmar = reader["ProductGroup_Myanmar"].ToString();
                    availableQuantity = reader["AvailableQuantity"].ToString();
                    rate = reader["Rate"].ToString();
                }
                reader.Close();
                //
                if (cboLanguage.SelectedItem.ToString() == "English")
                {
                    txtProductName.Text = productName_English;
                    txtProductType.Text = productType_English;
                    txtProductGroup.Text = productGroup_English;
                }
                else if (cboLanguage.SelectedItem.ToString() == "Myanmar")
                {
                    txtProductName.Text = productName_Myanmar;
                    txtProductType.Text = productType_Myanmar;
                    txtProductGroup.Text = productGroup_Myanmar;
                }
                txtAvailableQuantity.Text = availableQuantity;
                txtRate.Text = rate;
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != string.Empty && txtRate.Text != string.Empty)
            {
                int amount = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtRate.Text);
                txtAmount.Text = Convert.ToString(amount);
                //
                txtTotal.Text = Convert.ToString(amount);
            }
            else
            {
                txtQuantity.Text = "0";
                txtTotal.Text = "0";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != string.Empty && txtDiscount.Text != string.Empty)
            {
                int price = Convert.ToInt32(txtAmount.Text) - Convert.ToInt32(txtDiscount.Text);
                txtTotal.Text = Convert.ToString(price);
            }
            else
            {
                txtTotal.Text = txtAmount.Text;
                txtDiscount.Text = "0";
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text == string.Empty)
            {
                txtRate.Text = "0";
            }
        }

        private void txtAvailableQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtAvailableQuantity.Text == string.Empty)
            {
                txtAvailableQuantity.Text = "0";
            }
            //
            if(Convert.ToInt32(txtAvailableQuantity.Text) <= 0)
            {
                txtAvailableQuantity.BackColor = Color.Red;
            }
            else
            {
                txtAvailableQuantity.BackColor = Color.White;
            }
        }

        private void txtProductName_English_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty)
            {
                txtQuantity.Text = "0";
                txtDiscount.Text = "0";
            }
        }

        private void pbLockTodaySellingItems_Click(object sender, EventArgs e)
        {
            dgvTodaySellingItems.Visible = true;
            txtTodaySellingAmount.Visible = true;
            //
            pbLockTodaySellingItems.Visible = false;
            //
            TodaySellingItemsTable();
        }

        private void txtCustomerPay_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentSellingAmount.Text != string.Empty && txtCustomerPay.Text != string.Empty)
            {
                if (Convert.ToInt32(txtCurrentSellingAmount.Text) <= Convert.ToInt32(txtCustomerPay.Text))
                {
                    lblRepay.Text = "Repay";
                    txtRepay.BackColor = Color.White;
                    //
                    int repay = Convert.ToInt32(txtCustomerPay.Text) - Convert.ToInt32(txtCurrentSellingAmount.Text);
                    txtRepay.Text = Convert.ToString(repay);
                }
                else
                {
                    lblRepay.Text = "Credit";
                    txtRepay.BackColor = Color.Orange;
                    //
                    int repay = Convert.ToInt32(txtCurrentSellingAmount.Text) - Convert.ToInt32(txtCustomerPay.Text);
                    txtRepay.Text = Convert.ToString(repay);
                }
            }
            else
            {
                txtRepay.Text = "0";
            }
            if (txtRepay.BackColor == Color.Orange || txtLastCredit.BackColor == Color.Orange)
            {
                btnCashSale.Visible = false;
                btnCashSale.TabStop = false;
                btnCreditSale.Visible = true;
                btnCreditSale.TabStop = true;
            }
            else
            {
                btnCashSale.Visible = true;
                btnCashSale.TabStop = true;
                btnCreditSale.Visible = false;
                btnCreditSale.TabStop = false;
            }
        }

        private void btnCashSale_Click(object sender, EventArgs e)
        {
            currentSellingTable.Clear();
            txtCurrentSellingAmount.Text = "0";
            txtCustomerPay.Text = "0";
            txtRepay.Text = "0";
            txtCustomerID.Clear();
            //
            txtCustomerID.Enabled = true;
            txtCustomerID.Focus();
        }

        #endregion

        #region Product & Location 

        private void pbLockProductList_Click(object sender, EventArgs e)
        {
            panelProductList.Visible = true;
            gbSearchByProduct.Visible = true;
            gbSearchByLocation.Visible = true;
            dgvProductList.Visible = true;
            pbLockProductList.Visible = false;
            //
            if (cboProductGroup.SelectedIndex > -1 && cboProductType.SelectedIndex > -1 && cboProductName.SelectedIndex > -1)
            {
                string group = cboProductGroup.SelectedItem.ToString();
                string type = cboProductType.SelectedItem.ToString();
                string name = cboProductName.SelectedItem.ToString();
                ProductListTable(group, type, name);
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

        #endregion

        #region MenuStrip Functions
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        #endregion

        #region Error Handle for textBox can only access number type

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void txtCQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void txtCDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.Date.ToLongDateString();
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //
            TodaySellingItemsTable();
            //
            if (cboLanguage.SelectedItem.ToString() == "Myanmar")
            {
                lblStaffName.Text = name_Myanmar;
                //
                lblProductID.Text = "ကုဒ္နံပါတ္";
                lblName.Text = "အမည္";
                lblType.Text = "အမ်ိဳးအစား";
                lblGroup.Text = "အုပ္စု";
                //
                lblAvailableQuantity.Text = "ရႏုိင္ေသာအေရအတြက္";
                lblRate.Text = "ေစ်းနႈန္း";
                lblQuantity.Text = "အေရအတြက္";
                lblAmount.Text = "ေငြပမာဏ";
                lblDiscount.Text = " ေလွ်ာ့ေပးေငြ ";
                lblPrice.Text = "က်သင့္ေငြ";
                //
                lblTotalAmount.Text = "စုစုေပါင္းက်သင့္ေငြ";
                lblCustomerPay.Text = "ဝယ္သူေပးေငြ";
                lblRepay.Text = "ျပန္အမ္းေငြ";
                //
                lblCustomerID.Text = "ဝယ္ယူသူနံပါတ္";
                lblCustomerName.Text = "ဝယ္ယူသူအမည္";
                lblGender.Text = "က်ား/မ";
                lblAddress.Text = "ေနရပ္လိပ္စာ";
                //
                btnCashSale.Text = "ေငြလက္ငင္း\nေရာင္းျခင္း";
                btnCreditSale.Text = "အေၾကြး\nေရာင္းျခင္း";
            }
            else if(cboLanguage.SelectedItem.ToString() == "English")
            {
                lblStaffName.Text = name_English;
                //
                lblProductID.Text = "Product ID";
                lblName.Text = "Product Name";
                lblType.Text = "Product Type";
                lblGroup.Text = "Product Group";
                //
                lblAvailableQuantity.Text = "Available Quantity";
                lblRate.Text = "Rate";
                lblQuantity.Text = "Quantity";
                lblAmount.Text = "Amount";
                lblDiscount.Text = "Discount";
                lblPrice.Text = "Price";
                //
                lblTotalAmount.Text = "Total Amount";
                lblCustomerPay.Text = "Customer Pay";
                lblRepay.Text = "Repay";
                //
                lblCustomerID.Text = "CustomerID";
                lblCustomerName.Text = "Customer Name";
                lblGender.Text = "Gender";
                lblAddress.Text = "Address";
                //
                btnCashSale.Text = "Cash Sale";
                btnCreditSale.Text = "Credit Sale";
            }
        }

        private void btnCustomersList_Click(object sender, EventArgs e)
        {
            CustomersList customersList = new CustomersList();
            customersList.Show();
        }

        private void LastCreditDate(int lastCredit, DateTime lastCreditDate)
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
                command.CommandText = @"SELECT  TotalCredit, CreditDate FROM Creditors WHERE CustomerID=@customerId";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@productId", customerId);
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lastCredit = Convert.ToInt32(reader["TotalCredit"]);
                    lastCreditDate = Convert.ToDateTime(reader["CreditDate"].ToString());
                }
                reader.Close();
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

        private void btnCreditSale_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerID.Text;
            int currentCredit = 0;
            if (txtRepay.BackColor == Color.Orange)
            {
                currentCredit = Convert.ToInt32(txtRepay.Text);
            }
            else
            {
                currentCredit = 0;
            }
            DateTime currentCreditDate = Convert.ToDateTime(DateTime.Now.ToString());
            int lastCredit = Convert.ToInt32(txtLastCredit.Text);
            DateTime lastCreditDate = Convert.ToDateTime(lblLastCreditDate.Text);
            //
            int creditAmount = currentCredit + lastCredit;
            UpdateDataCreditorsTable(customerId, Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtCustomerPay.Text), creditAmount, currentCreditDate);
            //
            CreditorsDetail creditDetail = new CreditorsDetail(customerId, lastCredit, lastCreditDate, currentCredit, currentCreditDate);
            creditDetail.Show();
            //
            currentSellingTable.Clear();
            txtCurrentSellingAmount.Text = "0";
            txtCustomerPay.Text = "0";
            txtRepay.Text = "0";
            txtCustomerID.Enabled = true;
            txtCustomerID.Clear();
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
                command.CommandText = @"SELECT Customers.CustomerID, Customers.Name_English AS Name_E, Customers.Gender_English AS Gender_E, Customers.Address_English AS Address_E, Customers.Name_Myanmar AS Name_M, Customers.Gender_Myanmar AS Gender_M, Customers.Address_Myanmar AS Address_M, Creditors.CreditAmount AS CreditAmount, Creditors.CreditDate AS CreditDate FROM Customers, Creditors WHERE Customers.CustomerID=Creditors.CustomerID AND Customers.CustomerID=@customerId ORDER BY Customers.CustomerID";
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
                DateTime creditDate = DateTime.Now;
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
                    //
                    creditAmount = Convert.ToInt32(reader["CreditAmount"]);
                    creditDate = Convert.ToDateTime(reader["CreditDate"].ToString());
                }
                reader.Close();
                //
                if (cboLanguage.SelectedItem.ToString() == "English")
                {
                    txtCustomerName.Text = name_E;
                    txtGender.Text = gender_E;
                    txtAddress.Text = address_E;
                }
                if(cboLanguage.SelectedItem.ToString() == "Myanmar")
                {
                    txtCustomerName.Text = name_M;
                    txtGender.Text = gender_M;
                    txtAddress.Text = address_M;
                }
                lblLastCreditDate.Text = creditDate.ToLongDateString();
                txtLastCredit.Text = creditAmount.ToString();
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

        private void txtCustomerPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void txtLastCredit_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtLastCredit.Text) > 0)
            {
                txtLastCredit.BackColor = Color.Orange;
                btnCashSale.Visible = false;
                btnCashSale.TabStop = false;
                btnCreditSale.Visible = true;
                btnCreditSale.TabStop = true;
            }
            else
            {
                txtLastCredit.BackColor = Color.White;
                btnCashSale.Visible = true;
                btnCashSale.TabStop = true;
                btnCreditSale.Visible = false;
                btnCreditSale.TabStop = false;
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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == string.Empty)
            {
                txtProductID.Enabled = false;
                txtQuantity.Enabled = false;
                txtDiscount.Enabled = false;
                txtCustomerPay.Enabled = false;
                btnCashSale.Enabled = false;
                btnCreditSale.Enabled = false;
            }
            else
            {
                txtProductID.Enabled = true;
                txtQuantity.Enabled = true;
                txtDiscount.Enabled = true;
                txtCustomerPay.Enabled = true;
                btnCashSale.Enabled = true;
                btnCreditSale.Enabled = true;
            }
        }
    }
}
