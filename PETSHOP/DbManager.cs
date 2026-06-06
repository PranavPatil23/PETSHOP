using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWC.BCS.DAL;
using System.Windows.Forms;

namespace PETSHOP
{
    class DbManager : DbAccess
    {
        #region Constuctor

        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PetShopdb;Integrated Security=True";

        public DbManager() : base(connectionString)
        {
            InitializeAdapters();
        }

        private static readonly Lazy<DbManager> lazy = new Lazy<DbManager>(() => new DbManager());
        public static DbManager Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        #region Adapter and Binding Sources

        public BindingSource bsUsers;
        public BindingSource bsCategory;
        public BindingSource bsProduct;
        public BindingSource bsVendorTypes;
        public BindingSource bsVendors; 
        public BindingSource bsOrders;
        public BindingSource bsOrderDetails;
        public BindingSource bsPayments;
        public BindingSource bsStatus;
        public BindingSource bsModes;
        public BindingSource bsSubCategory;
        public BindingSource bsCompany;
        public BindingSource bsReorders;

        private void InitializeAdapters()
        {
            bsUsers = CreateDataAdapterFor("Users");
            bsCategory = CreateDataAdapterFor("Category");
            bsProduct = CreateDataAdapterFor("Product");
            bsVendorTypes = CreateDataAdapterFor("VendorTypes");
            bsVendors = CreateDataAdapterFor("Vendors");
            bsOrders = CreateDataAdapterFor("Orders");
            bsOrderDetails = CreateDataAdapterFor("OrderDetails");
            bsPayments = CreateDataAdapterFor("Payments");
            bsStatus = CreateDataAdapterFor("Status");
            bsModes = CreateDataAdapterFor("Modes");
            bsSubCategory = CreateDataAdapterFor("SubCategory");
            bsReorders = CreateDataAdapterFor("Reorders");
            bsCompany = CreateDataAdapterFor("Company");
        }

        #endregion

        #region Relations

        public void crVendors()
        {
            bsVendors = CreateRelationFor("VendorTypes", "Vendors", "VendorTypeID");
        }
        public void crCompanyProduct()
        {
            bsVendors = CreateRelationFor("Product", "OrderDetails", "CompanyID");
        }
        public void crCategorySubCategory()
        {
            bsSubCategory = CreateRelationFor("Category", "SubCategory", "CategoryID");

        }

        public void crSubCategoryProduct()
        {
            bsProduct = CreateRelationFor("SubCategory", "Product", "SubCategoryID");
        }
      

        public void crVendorOrders()
        {
            bsOrders = CreateRelationFor("Vendors", "Orders", "VendorID");
           
        }
       
        public void crOrderDetails()
        {
            bsOrderDetails = CreateRelationFor("Orders", "OrderDetails", "OrderID");
        }

        public void crOrderPayments()
        {
            bsPayments = CreateRelationFor("Orders", "Payments", "OrderID");
        }

        #endregion
    }
}
