using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KWC.BCS.Controls.Extensions;

namespace PETSHOP.Transactions
{
    public partial class UpdateStock : Form
    {
        DbManager dbm = DbManager.Instance;
        DbManager dbmStock = new DbManager();
        

        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            btUpdate.DataBindings.Add(new Binding("Visible", dbm.bsOrders, "UpdateStock", true));
            dgvODP.DataSource = dbm.bsOrderDetails;
            dgvODP.AutoSize();
            //dgvOrderDetails.AddComboColumn("Material", dbmStock.bsMaterials, "MaterialName", "MaterialID");
            dgvODP.ReorderColumns(new[] { "OrderID", "ProductID", "Quantity", "UnitPrice" });
            dgvPCS.DataSource = dbmStock.bsProduct;
            dgvPCS.AutoSize();
            //dgvCurrentStock.AddComboColumn("Material", dbmStock.bsMaterials, "MaterialName", "MaterialID");
            dgvPCS.ReorderColumns(new[] { "ProductID", "Quantity", "UnitPrice" });

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dbm.bsOrderDetails.Count > 0)
            {
                var rowOrders = dbm.GetCurrentRow(dbm.bsOrders);
                var dueAmount = rowOrders["Due"].ToIntAmount();
                if (dueAmount > 0)
                {
                    MessageBox.Show($@"Cannot Update Stock - Due Rs. {rowOrders["Due"]}", "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var rowVendorType = dbm.GetCurrentRow(dbm.bsVendorTypes);
                    var rowOrderDetails = dbm.GetCurrentRow(dbm.bsOrderDetails);
                    var rowStock = dbmStock.GetCurrentRow(dbm.bsProduct);

                   // var rowProductSave = dbm.GetCurrentRow(dbm.bsProduct);

                    var vendorTypeID = rowVendorType["VendorTypeID"].ToInt();
                    string msg = "";
                    var updateStock = false;


                    for (int i = 0; i < dbm.bsOrderDetails.Count; i++)
                    {
                        // Process Each OrderDetail Row
                        dbm.bsOrderDetails.Position = i;
                        rowOrderDetails = dbm.GetCurrentRow(dbm.bsOrderDetails);
                        var orderProductID = rowOrderDetails["ProductID"].ToInt();
                        // Process Related Material Row
                        rowStock = dbmStock.GetRow(dbmStock.bsProduct, "ProductID", orderProductID);
                        msg = $@"Quantity - OrderDetails {rowOrderDetails["Quantity"]} : Stock {rowStock["Quantity"]} ";
                        MessageBox.Show(msg, @"Update Stock - Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Toaster.ShowWarning(this, msg);
                        var orderQuantity = rowOrderDetails["Quantity"].ToInt();
                        var orderUnitPrice = rowOrderDetails["UnitPrice"].ToInt();
                        var stockQuantity = rowStock["Quantity"].ToInt();
                        var stockUnitPrice = rowStock["UnitPrice"].ToInt();
                        switch (vendorTypeID)
                        {
                            // Customer
                            case 1:
                                if (stockQuantity - orderQuantity > 0)
                                {
                                    rowStock["Quantity"] = (int)(stockQuantity - orderQuantity);
                                    updateStock = true;
                                }
                                else
                                {
                                    updateStock = false;
                                    msg = $@"Insufficient stock of {rowStock["ProductName"]}Quantity Cannot Update";
                                    MessageBox.Show(msg, @"Update Stock - Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                            // Supplier
                            case 2:
                                if (orderUnitPrice > stockUnitPrice)
                                {
                                    rowStock["UnitPrice"] = orderUnitPrice;
                                    msg = $@"{rowStock["ProductName"]} price is updated from Rs. {stockUnitPrice} to Rs. {orderUnitPrice}";
                                    MessageBox.Show(msg, @"Update Stock - Unit Price",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information); updateStock = true;
                                }
                                rowStock["Quantity"] = (int)(stockQuantity + orderQuantity);
                                updateStock = true;
                                break;
                        }
                    }
                    if (updateStock == true)
                    {
                        dbmStock.SaveTable("Product", "Quantity");
                        rowOrders["UpdateStock"] = false;
                        rowOrders["StatusID"] = 2; // Completed
                        dbm.SaveTable("Orders", "UpdateStock, StatusID");
                        
                        dbm.bsProduct.ResetBindings(false);
                    }

                }
            }
            else
            {
                MessageBox.Show(@"Cannot Update Stock", @"Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    


