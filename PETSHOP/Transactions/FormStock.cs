using System;
using System.Windows.Forms;
using KWC.BCS.Controls.Extensions;

namespace PETSHOP.Transactions
{
    public partial class FormStock : Form
    {
        DbManager dbm = DbManager.Instance;
        DbManager dbmStock = new DbManager();

        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            btnUpdate.DataBindings.Add(new Binding("Visible", dbm.bsOrders, "UpdateStock", true));

            dgvOrderDetails.DataSource = dbm.bsOrderDetails;
            dgvOrderDetails.AutoSize();
            //dgvOrderDetails.AddComboColumn("Material", dbmStock.bsMaterials, "MaterialName", "MaterialID");
            dgvOrderDetails.ReorderColumns(new[] { "OrderID", "ProductID", "Quantity", "UnitPrice" });

            dgvCurrentStock.DataSource = dbmStock.bsProduct;
            dgvCurrentStock.AutoSize();
            //dgvCurrentStock.AddComboColumn("Material", dbmStock.bsMaterials, "MaterialName", "MaterialID");
            dgvCurrentStock.ReorderColumns(new[] { "ProductID", "Quantity", "UnitPrice" });
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (dbm.bsOrderDetails.Count > 0)
            {
                var rowOrders = dbm.GetCurrentRow(dbm.bsOrders);
                int dueAmount = rowOrders["Due"].ToIntAmount();

                if (dueAmount > 0)
                {
                    MessageBox.Show($@"Cannot Update Stock - Due Rs. {rowOrders["Due"]}", "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var rowVendorType = dbm.GetCurrentRow(dbm.bsVendorTypes);
                    var rowOrderDetails = dbm.GetCurrentRow(dbm.bsOrderDetails);
                    var rowMaterials = dbmStock.GetCurrentRow(dbm.bsProduct);

                    int vendorTypeID = rowVendorType["VendorTypeID"].ToInt();
                    string msg = "";

                    for (int i = 0; i < dbm.bsOrderDetails.Count; i++)
                    {
                        // Process Each OrderDetail Row
                        dbm.bsOrderDetails.Position = i;
                        rowOrderDetails = dbm.GetCurrentRow(dbm.bsOrderDetails);

                        int orderMaterialID = rowOrderDetails["ProductID"].ToInt();

                        // Process Related Material Row
                        rowMaterials = dbmStock.GetRow(dbmStock.bsProduct, "ProductID", orderMaterialID);

                        msg = $@"Quantity - OrderDetails {rowOrderDetails["Quantity"]} : Stock {rowMaterials["Quantity"]} ";
                        MessageBox.Show(msg, "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Toaster.ShowWarning(this, msg);

                        int orderQuantity = rowOrderDetails["Quantity"].ToInt();
                        int materialQuantity = rowMaterials["Quantity"].ToInt();

                        
                        switch (vendorTypeID)
                        {
                            // Customer
                            case 1:
                                rowMaterials["Quantity"] = materialQuantity - orderQuantity;
                                break;

                            // Suppler
                            case 2:
                                rowMaterials["Quantity"] = materialQuantity + orderQuantity;
                                break;
                        }
                    }
                    //dbm.SaveTable("Product", "Quantity");

                    //rowOrders["UpdateStock"] = false;
                    //rowOrders["StatusID"] = 2; // Completed
                    //dbm.SaveTable("Orders", "UpdateStock, StatusID");
                }
            }
            else
            {
                MessageBox.Show("Cannot Update Stock", "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
