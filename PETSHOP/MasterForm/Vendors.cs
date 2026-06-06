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
    public partial class Vendors : Form
    {

        DbManager dbm = DbManager.Instance;
        public Vendors()
        {
            
            InitializeComponent();
            dbm.crVendors();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {

            cbVendorTypes.DataSource = dbm.bsVendorTypes;
            cbVendorTypes.DisplayMember = "VendorTypeName";
            cbVendorTypes.ValueMember = "VendorTypeID";

            txtVendorID.DataBindings.Add(new Binding("Text", dbm.bsVendors, "VendorID", true));
            txtVendorName.DataBindings.Add(new Binding("Text", dbm.bsVendors, "VendorName", true));
            txtAddress.DataBindings.Add(new Binding("Text", dbm.bsVendors, "Address", true));
            txtContactNo.DataBindings.Add(new Binding("Text", dbm.bsVendors, "Phone", true));
          // cbVendorTypes.DataBindings.Add(new Binding("selectedvalue", dbm.bsVendors, "VendorTypeID", true));
          

            DgvVendors.DataSource = dbm.bsVendors;
            DgvVendors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvVendors.AllowUserToAddRows = false;
            crudVendors.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Vendors";
                c.PrimaryKey = "VendorID";
                c.PrimaryKeyTextBox = txtVendorID;
                c.AddPrimaryKey = true;
            });
        }

     
        private void cbVendorTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crudVendors_UserAdd(object sender, EventArgs e)
        {
            cbVendorTypes.SelectedValue = 1;
        }

        private void GR2Vendortype_Enter(object sender, EventArgs e)
        {

        }
    }
}
