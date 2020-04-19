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
    public partial class Purchase : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Database\GeneralShop.mdb";
        //
        DataTable currentPurchaseTable;
        //
        private string staffID = string.Empty;
        private string name_English = string.Empty;
        private string occupation_English = string.Empty;
        private string name_Myanmar = string.Empty;
        private string occupation_Myanmar = string.Empty;
        //
        public Purchase(string staffID, string name_English, string occupation_English, string name_Myanmar, string occupation_Myanmar)
        {
            InitializeComponent();
            //
            this.staffID = staffID;
            this.name_English = name_English;
            this.occupation_English = occupation_English;
            this.name_Myanmar = name_Myanmar;
            this.occupation_Myanmar = occupation_Myanmar;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = name_English;
            //
            txtProductID.Focus();
            //
            cboSearchByGroup.SelectedIndex = 0;
            cboSearchByType.SelectedIndex = 0;
            cboSearchByName.SelectedIndex = 0;
            //

            ProductGroupSearchList(cboSearchByGroup);
            ProductTypeSearchList(cboSearchByGroup, cboSearchByType);
            ProductNameSearchList(cboSearchByGroup, cboSearchByType, cboSearchByName);
            //
            txtDate.Text = DateTime.Now.ToLongDateString();
            //
            currentPurchaseTable = new DataTable();
            currentPurchaseTable.Columns.Add("ProductID");
            currentPurchaseTable.Columns.Add("ProductName");
            currentPurchaseTable.Columns.Add("ProductType");
            currentPurchaseTable.Columns.Add("Quantity");
            currentPurchaseTable.Columns.Add("Price");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
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
                txtProductName_English.Text = productName_English;
                txtProductType_English.Text = productType_English;
                txtProductGroup_English.Text = productGroup_English;
                txtProductName_Myanmar.Text = productName_Myanmar;
                txtProductType_Myanmar.Text = productType_Myanmar;
                txtProductGroup_Myanmar.Text = productGroup_Myanmar;
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

        private void CurrentPurchaseItemsTable()
        {
            string productID = txtProductID.Text;
            string productName_Myanmar = txtProductName_Myanmar.Text;
            string productType_Myanmar = txtProductType_Myanmar.Text;
            string quantity = txtQuantity.Text;
            string price = txtPrice.Text;
            //
            //
            DataRow row = currentPurchaseTable.NewRow();
            row["ProductID"] = productID;
            row["ProductName"] = productName_Myanmar;
            row["ProductType"] = productType_Myanmar;
            row["Quantity"] = quantity;
            row["Price"] = price;
            currentPurchaseTable.Rows.Add(row);
            //        
            //
            int total = Convert.ToInt32(txtCurrentPurchaseAmount.Text) + Convert.ToInt32(txtPrice.Text);
            txtCurrentPurchaseAmount.Text = Convert.ToString(total);
            //
            dgvCurrentPurchase.DataSource = currentPurchaseTable;
            dgvCurrentPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvCurrentPurchase.Font = new Font("Zawgyi-one", 11F);
        }

        private void InsertDataPurchaseTable(string productId, int quantity, int price, string supplierID, string staffID, DateTime purchaseDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                    //
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Purchase(ProductID, Quantity, Price, SupplierID, StaffID, Purchase_Date) VALUES(@productId, @quantity, @price, @supplierID, @staffID, @purchaseDate)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@supplierID", supplierID);
                    command.Parameters.AddWithValue("@staffID", staffID);
                    command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
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

        private void UpdateDataStockTable(string productId, int quantity)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = @"UPDATE Stock SET Quantity=Quantity + @quantity, LastUpdate=@lastUpdate WHERE ProductID=@productId";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString());
                command.Parameters.AddWithValue("@productId", productId);
                command.ExecuteNonQuery();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != string.Empty && txtProductName_English.Text != string.Empty && txtQuantity.Text != string.Empty && txtPrice.Text != string.Empty && txtSupplierID.Text != string.Empty)
            {
                string productId = txtProductID.Text.ToUpper();
                int quantity = Convert.ToInt32(txtQuantity.Text);
                int price = Convert.ToInt32(txtPrice.Text);
                string supplierID = txtSupplierID.Text;
                DateTime purchaseDate = DateTime.Parse(DateTime.Now.ToString());
                //             
                DialogResult result = MessageBox.Show("That will be inserted data into Purchase table!" + "\nProductID\t: " + productId + "\nItem Name\t: " + txtProductName_Myanmar.Text + "\nType\t\t: " + txtProductType_Myanmar.Text + "\nQuantity\t\t: " + quantity + "\nPrice\t\t: " + price, "CONFIRM", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    InsertDataPurchaseTable(productId, quantity, price, supplierID, staffID, purchaseDate);
                    //
                    CurrentPurchaseItemsTable();
                }
                else
                {
                    MessageBox.Show("Try & Corrent");
                }
                //
                txtProductID.Text = null;
                txtQuantity.Text = "0";
                txtPrice.Text = "0";
                txtSupplierID.Text = "0000";
                //
                if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
                {
                    string group = cboSearchByGroup.SelectedItem.ToString();
                    string type = cboSearchByType.SelectedItem.ToString();
                    string name = cboSearchByName.SelectedItem.ToString();
                    DateTime purDate = DateTime.Parse(txtDate.Text);
                    //
                    NeedToPurchaseTable(group, type, name);
                    MonthlyPurchaseProductListTable(group, type, name, purDate);
                    DailyPurchaseProductListTable(group, type, name, purDate);
                }
            }
            else
            {
                MessageBox.Show("Please Insert Data!", "Message");
            }
            txtProductID.Focus();
        }

        private void NeedToPurchaseTable(string group, string type, string name)
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
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND Quantity<5";
                }

                else if (group != "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND Quantity<5";
                    command.Parameters.AddWithValue("@group", group);
                }

                else if (group == "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductType_Myanmar=@type AND Quantity<5";
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group == "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductName_Myanmar=@name AND Quantity<5";
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group != "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductType_Myanmar=@type AND Quantity<5";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group != "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductName_Myanmar=@name AND Quantity<5";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group == "ALL" && type != "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductType_Myanmar=@type AND ProductName_Myanmar=@name AND Quantity<5";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                else
                {
                    command.CommandText = @"SELECT Product.ProductID AS ProductID, Product.ProductName_English AS ProductName_English, Product.ProductType_English AS ProductType_English, Product.ProductGroup_English AS ProductGroup_English, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, Product.LocationID AS LocationID, Stock.Rate AS Rate, Stock.Quantity AS Quantity FROM Product, Stock WHERE Product.ProductID=Stock.ProductID AND ProductGroup_Myanmar=@group AND ProductType_Myanmar=@type AND ProductName_Myanmar=@name AND Quantity<5";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                command.CommandType = CommandType.Text;
                //
                DataTable needToPurchase = new DataTable();
                needToPurchase.Columns.Add("ProductID");
                needToPurchase.Columns.Add("ProductName_Myanmar");
                needToPurchase.Columns.Add("ProductType_Myanmar");
                needToPurchase.Columns.Add("ProductGroup_Myanmar");
                needToPurchase.Columns.Add("Quantity");
                needToPurchase.Columns.Add("LocationID");
                //
                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    DataRow row = needToPurchase.NewRow();
                    row["ProductID"] = reader["ProductID"];
                    row["ProductName_Myanmar"] = reader["ProductName_Myanmar"];
                    row["ProductType_Myanmar"] = reader["ProductType_Myanmar"];
                    row["ProductGroup_Myanmar"] = reader["ProductGroup_Myanmar"];
                    row["Quantity"] = reader["Quantity"];
                    row["LocationID"] = reader["LocationID"];
                    needToPurchase.Rows.Add(row);
                }
                reader.Close();
                dgvNeedToPurchase.DataSource = needToPurchase;
                dgvNeedToPurchase.Font = new Font("Zawgyi-One", 11F);
                dgvNeedToPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void MonthlyPurchaseProductListTable(string group, string type, string name, DateTime pDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string purchaseDate = "%%%" + pDate.ToString("MMM/yy") + "%";

                if (group == "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                }

                else if (group != "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                }

                else if (group == "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductType_Myanmar=@type AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group == "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group != "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Product.ProductType_Myanmar=type AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group != "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group == "ALL" && type != "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductType_Myanmar=@type AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                else
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Product.ProductType_Myanmar=@type AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                command.CommandType = CommandType.Text;
                //
                DataTable product = new DataTable();
                product.Columns.Add("ProductID");
                product.Columns.Add("ProductName_Myanmar");
                product.Columns.Add("ProductType_Myanmar");
                product.Columns.Add("ProductGroup_Myanmar");
                product.Columns.Add("Quantity");
                product.Columns.Add("Price");
                //
                int price = 0;
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = product.NewRow();
                    row["ProductID"] = reader["ProductID"];
                    row["ProductName_Myanmar"] = reader["ProductName_Myanmar"];
                    row["ProductType_Myanmar"] = reader["ProductType_Myanmar"];
                    row["ProductGroup_Myanmar"] = reader["ProductGroup_Myanmar"];
                    row["Quantity"] = reader["Quantity"];
                    row["Price"] = reader["Price"];
                    product.Rows.Add(row);
                    //
                    price += Convert.ToInt32(reader["Price"]);
                }
                reader.Close();
                //
                txtMonthlyPurchaseAmount.Text = Convert.ToString(price);
                //
                dgvMonthlyPurchase.DataSource = product;
                dgvMonthlyPurchase.Font = new Font("Zawgyi-One", 11f);
                dgvMonthlyPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
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

        private void DailyPurchaseProductListTable(string group, string type, string name, DateTime pDate)
        {
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                //
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string purchaseDate = pDate.ToString("dd/MMM/yy") + "%";

                if (group == "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                }

                else if (group != "ALL" && type == "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                }

                else if (group == "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductType_Myanmar=@type AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group == "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group != "ALL" && type != "ALL" && name == "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Product.ProductType_Myanmar=type AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                }

                else if (group != "ALL" && type == "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@name", name);
                }

                else if (group == "ALL" && type != "ALL" && name != "ALL")
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductType_Myanmar=@type AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                else
                {
                    command.CommandText = @"SELECT * FROM (SELECT Product.ProductID, Product.ProductName_Myanmar AS ProductName_Myanmar, Product.ProductType_Myanmar AS ProductType_Myanmar, Product.ProductGroup_Myanmar AS ProductGroup_Myanmar, SUM(Purchase.Quantity) AS Quantity, SUM(Purchase.Price) AS Price FROM Product, Purchase WHERE Product.ProductID=Purchase.ProductID AND Product.ProductGroup_Myanmar=@group AND Product.ProductType_Myanmar=@type AND Product.ProductName_Myanmar=@name AND Purchase.Purchase_Date LIKE '" + purchaseDate + "' GROUP BY Product.ProductID, Product.ProductName_Myanmar, Product.ProductType_Myanmar, Product.ProductGroup_Myanmar) ORDER BY Product.ProductID";
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", name);
                }

                command.CommandType = CommandType.Text;
                //
                DataTable product = new DataTable();
                product.Columns.Add("ProductID");
                product.Columns.Add("ProductName_Myanmar");
                product.Columns.Add("ProductType_Myanmar");
                product.Columns.Add("ProductGroup_Myanmar");
                product.Columns.Add("Quantity");
                product.Columns.Add("Price");
                //
                int price = 0;
                //
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = product.NewRow();
                    row["ProductID"] = reader["ProductID"];
                    row["ProductName_Myanmar"] = reader["ProductName_Myanmar"];
                    row["ProductType_Myanmar"] = reader["ProductType_Myanmar"];
                    row["ProductGroup_Myanmar"] = reader["ProductGroup_Myanmar"];
                    row["Quantity"] = reader["Quantity"];
                    row["Price"] = reader["Price"];
                    product.Rows.Add(row);
                    //
                    price += Convert.ToInt32(reader["Price"]);
                }
                reader.Close();
                //
                txtDailyPurchaseAmount.Text = Convert.ToString(price);
                //
                dgvDailyPurchase.DataSource = product;
                dgvDailyPurchase.Font = new Font("Zawgyi-One", 11f);
                dgvDailyPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
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
                    cboSearchByGroup.Items.Add(row[0].ToString());
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
                        cboSearchByType.Items.Add(row[0].ToString());
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
                    cboSearchByName.Items.Add(row[0].ToString());
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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            dgvCurrentPurchase.DataSource = null;
            txtCurrentPurchaseAmount.Text = "0";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
        }

        private void pbLockDailyPurchase_Click(object sender, EventArgs e)
        {
            dgvDailyPurchase.Visible = true;
            txtDailyPurchaseAmount.Visible = true;
            //
            pbLockDailyPurchase.Visible = false;
            //
            if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
            {
                string group = cboSearchByGroup.SelectedItem.ToString();
                string type = cboSearchByType.SelectedItem.ToString();
                string name = cboSearchByName.SelectedItem.ToString();
                DateTime purchaseDate = DateTime.Parse(txtDate.Text);
                //
                DailyPurchaseProductListTable(group, type, name, purchaseDate);
            }
        }

        private void pbLockMonthlyPurchase_Click(object sender, EventArgs e)
        {
            dgvMonthlyPurchase.Visible = true;
            txtMonthlyPurchaseAmount.Visible = true;
            //
            pbLockMonthlyPurchase.Visible = false;
            //
            if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
            {
                string group = cboSearchByGroup.SelectedItem.ToString();
                string type = cboSearchByType.SelectedItem.ToString();
                string name = cboSearchByName.SelectedItem.ToString();
                DateTime purchaseDate = DateTime.Parse(txtDate.Text);
                //
                MonthlyPurchaseProductListTable(group, type, name, purchaseDate);
            }
        }

        private void pbLockNeedToPurchase_Click(object sender, EventArgs e)
        {
            dgvNeedToPurchase.Visible = true;
            //
            string group = cboSearchByGroup.SelectedItem.ToString();
            string type = cboSearchByType.SelectedItem.ToString();
            string name = cboSearchByName.SelectedItem.ToString();
            //
            NeedToPurchaseTable(group, type, name);
            //
            pbLockNeedToPurchase.Visible = false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {
                txtQuantity.Text = "0";
            }
        }

        #region Error Handle for textbox can only access number type

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        #endregion

        #region Reset TextBox

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(txtPrice.Text == string.Empty)
            {
                txtPrice.Text = "0";
            }
        }

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
            if(txtSupplierID.Text == string.Empty)
            {
                txtSupplierID.Text = "S0";
            }
        }
        
        #endregion

        #region MenuStrip functions
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        #endregion

        private void cboSearchByGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
            {
                string group = cboSearchByGroup.SelectedItem.ToString();
                string type = cboSearchByType.SelectedItem.ToString();
                string name = cboSearchByName.SelectedItem.ToString();
                DateTime purchaseDate = DateTime.Parse(txtDate.Text);
                //
                NeedToPurchaseTable(group, type, name);
                MonthlyPurchaseProductListTable(group, type, name, purchaseDate);
                DailyPurchaseProductListTable(group, type, name, purchaseDate);
                //
                ProductTypeSearchList(cboSearchByGroup, cboSearchByType);
                ProductNameSearchList(cboSearchByGroup, cboSearchByType, cboSearchByName);
            }
        }

        private void cboSearchByType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
            {
                string group = cboSearchByGroup.SelectedItem.ToString();
                string type = cboSearchByType.SelectedItem.ToString();
                string name = cboSearchByName.SelectedItem.ToString();
                DateTime purchaseDate = DateTime.Parse(txtDate.Text);
                //
                NeedToPurchaseTable(group, type, name);
                MonthlyPurchaseProductListTable(group, type, name, purchaseDate);
                DailyPurchaseProductListTable(group, type, name, purchaseDate);
                //
                ProductNameSearchList(cboSearchByGroup, cboSearchByType, cboSearchByName);
            }
        }

        private void cboSearchByName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
            {
                string group = cboSearchByGroup.SelectedItem.ToString();
                string type = cboSearchByType.SelectedItem.ToString();
                string name = cboSearchByName.SelectedItem.ToString();
                DateTime purchaseDate = DateTime.Parse(txtDate.Text);
                //
                NeedToPurchaseTable(group, type, name);
                MonthlyPurchaseProductListTable(group, type, name, purchaseDate);
                DailyPurchaseProductListTable(group, type, name, purchaseDate);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (cboSearchByGroup.SelectedIndex > -1 && cboSearchByType.SelectedIndex > -1 && cboSearchByName.SelectedIndex > -1 && txtDate.Text != string.Empty)
            {
                string group = cboSearchByGroup.SelectedItem.ToString();
                string type = cboSearchByType.SelectedItem.ToString();
                string name = cboSearchByName.SelectedItem.ToString();
                DateTime purchaseDate = DateTime.Parse(txtDate.Text);
                //
                MonthlyPurchaseProductListTable(group, type, name, purchaseDate);
                DailyPurchaseProductListTable(group, type, name, purchaseDate);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

