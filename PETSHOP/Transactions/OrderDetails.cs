using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KWC.BCS.Controls;
using KWC.BCS.Controls.Extensions;


namespace PETSHOP.Transactions
{
    public partial class OrderDetails : Form
    {
        DbManager dbm = DbManager.Instance;
        DbManager dbmProduct = new DbManager();
        
        public OrderDetails()
        {

            InitializeComponent();
            dbmProduct.crCategorySubCategory();
            dbmProduct.crSubCategoryProduct();
           


        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
             #region Header
            lblVT.DataBindings.Add(new Binding("Text", dbm.bsVendorTypes, "VendorTypeName", true));
            lblVN.DataBindings.Add(new Binding("Text", dbm.bsVendors, "VendorName", true));
            lblOID.DataBindings.Add(new Binding("Text", dbm.bsOrders, "OrderID", true));
         
            #endregion
            #region Product to ADD
            cbODCategory.DataSource = dbmProduct.bsCategory;
            cbODCategory.DisplayMember = "CategoryName";
            cbODCategory.ValueMember = "CategoryID";

            cbSCS.DataSource = dbmProduct.bsSubCategory;
            cbSCS.DisplayMember = "SubCategoryName";
            cbSCS.ValueMember = "SubCategoryID";

            cbODetails.DataSource = dbmProduct.bsProduct;
            cbODetails.DisplayMember = "ProductName";
            cbODetails.ValueMember = "ProductID";

            txtSelUnitPrice.DataBindings.Add(new Binding("Text", dbmProduct.bsProduct, "UnitPrice", true));
            txtSelMargin.DataBindings.Add(new Binding("Text", dbmProduct.bsProduct, "Margin", true));
           

            #endregion

            #region Order Details
            txtQuantity.DataBindings.Add(new Binding("Text", dbm.bsOrderDetails, "Quantity", true));
            lblUP.DataBindings.Add(new Binding("Text", dbm.bsOrderDetails, "UnitPrice", true, DataSourceUpdateMode.OnPropertyChanged, "", "N"));
            lblODMargin.DataBindings.Add(new Binding("Text", dbm.bsOrderDetails, "Margin", true));
            lblS.DataBindings.Add(new Binding("Text", dbmProduct.bsProduct, "Quantity", true));
            cbODetails.DataBindings.Add(new Binding("SelectedValue", dbm.bsOrderDetails, "ProductID", true));
          

            DgvOrderDetails.DataSource = dbm.bsOrderDetails;
            DgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvOrderDetails.AllowUserToAddRows = false;
          //  DgvOrderDetails.AddComboColumn("Product", dbmDgv.bsProduct, "ProductName", "ProductID");

            crudOrderDetails.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "OrderDetails";
                c.PrimaryKey = "OrderID";
                c.PrimaryKeyTextBox = txtQuantity;
                c.AddPrimaryKey = false;
            });
            #endregion
            #region Footer
            lblOrderPaid.DataBindings.Add(new Binding("Text", dbm.bsOrders, "OrderPaid", true, DataSourceUpdateMode.OnPropertyChanged, "", "N"));
            lblOrderTotal.DataBindings.Add(new Binding("Text", dbm.bsOrders, "OrderTotal", true));
            lblSGST.DataBindings.Add(new Binding("Text", dbm.bsOrders, "SGST", true, DataSourceUpdateMode.OnPropertyChanged, "", "N"));
            lblCGST.DataBindings.Add(new Binding("Text", dbm.bsOrders, "CGST", true, DataSourceUpdateMode.OnPropertyChanged, "", "N"));
            lblNetTotal.DataBindings.Add(new Binding("Text", dbm.bsOrders, "NetTotal", true, DataSourceUpdateMode.OnPropertyChanged, "", "C2"));
            #endregion
           
        }

        private void crudOrderDetails_UserAdd(object sender, EventArgs e)
        {
            var rowvt = dbm.bsVendorTypes.CurrentRow();
            var rowP = dbmProduct.bsProduct.CurrentRow();
            if (rowvt["VendorTypeID"].ToInt() == 1)
            {
                txtSelUnitPrice.Text = rowP["UnitPrice"].ToString();
                txtSelUnitPrice.Enabled = false;
            }
            if (rowvt["VendorTypeID"].ToInt() == 2)
            {
                txtSelUnitPrice.Text = "0.0"; //rowP["UnitPrice"].ToString();
                txtSelUnitPrice.Enabled = true;
                
            }
        }

        private void crudOrderDetails_UserSave_1(object sender, EventArgs e)
        {
            try
            {
                // UserSave In OrderDetails
                var rowOrderDetails = dbm.bsOrderDetails.CurrentRow();
                var rowSelMaterial = dbmProduct.bsProduct.CurrentRow();

                rowOrderDetails["UnitPrice"] = rowSelMaterial["UnitPrice"];
                rowOrderDetails["Margin"] = rowSelMaterial["Margin"];
               

                dbm.SaveTable("OrderDetails", "OrderDetails UnitPrice, Margin");
            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Duplicate Data Entry", "Product Rate - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);

            }


        }








    }
}
