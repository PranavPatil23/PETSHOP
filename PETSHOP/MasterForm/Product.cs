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
namespace PETSHOP
{
    public partial class Product : Form
    {
        DbManager dbm = DbManager.Instance;
        public Product()
        {
            InitializeComponent();
            dbm.crCategorySubCategory();
            dbm.crSubCategoryProduct();

        }

        private void Product_Load(object sender, EventArgs e)
        {
            cbCompany.DataSource = dbm.bsCompany;
            cbCompany.DisplayMember = "CompanyName";
            cbCompany.ValueMember = "CompanyID";

            cbCategory.DataSource = dbm.bsCategory;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            cbSubCategory.DataSource = dbm.bsSubCategory;
            cbSubCategory.DisplayMember = "SubCategoryName";
            cbSubCategory.ValueMember = "SubCategoryID";

            txtProductID.DataBindings.Add(new Binding("Text", dbm.bsProduct, "ProductID", true));
            txtProductName.DataBindings.Add(new Binding("Text", dbm.bsProduct, "ProductName", true));
            txtQuantity.DataBindings.Add(new Binding("Text", dbm.bsProduct, "Quantity", true));
            txtMargin.DataBindings.Add(new Binding("Text", dbm.bsProduct, "Margin", true));
            txtUP.DataBindings.Add(new Binding("Text", dbm.bsProduct, "UnitPrice", true));
            txtReorderlevel.DataBindings.Add(new Binding("Text", dbm.bsProduct, "ReorderLevel", true));
            dtMFG.DataBindings.Add(new Binding("value", dbm.bsProduct, "MfgDate", true));
            dtEXP.DataBindings.Add(new Binding("value", dbm.bsProduct, "ExpDate", true));
            cbCompany.DataBindings.Add(new Binding("selectedvalue", dbm.bsProduct, "CompanyID", true));



            DgvProduct.DataSource = dbm.bsProduct;
            DgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvProduct.AllowUserToAddRows = false;

            crudControl1.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Product";
                c.PrimaryKey = "ProductID";
                c.PrimaryKeyTextBox = txtProductID;
                c.AddPrimaryKey = true;
            });


            cbCategory_SelectedIndexChanged(null, null);

        }
       


        private void crudControl1_UserAdd(object sender, EventArgs e)
        {
            cbCategory.SelectedValue = 1;
        }

        private void crudControl1_UserAdd_1(object sender, EventArgs e)
        {
           
        }

        private void crudControl1_UserSave(object sender, EventArgs e)
        {
            var rowCategory = dbm.bsCategory.CurrentRow();
            var rowCompany = dbm.bsCompany.CurrentRow();
            var rowSubCategory = dbm.bsSubCategory.CurrentRow();
            var rowProduct = dbm.bsProduct.CurrentRow();
            rowProduct["ProductName"] = $@"{rowCompany["CompanyName"]}-{rowCategory["CategoryName"]}-{rowSubCategory["SubCategoryName"]}-{txtProductName.Text}";
            dbm.SaveTable("Product", "ProductName");
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            var selectedCategoryId = cbCategory.SelectedValue;

            if (selectedCategoryId.ToInt() == 2)
            {
                
                lblMFG.Visible = true;
                lblEXP.Visible = true;
                dtMFG.Visible = true;
                dtEXP.Visible = true;
            }
            else if (selectedCategoryId.ToInt() == 1)
            {
               
                lblMFG.Visible = false;
                lblEXP.Visible = false;
                dtMFG.Visible = false;
                dtEXP.Visible = false;
            }

           
        }
    }
}
