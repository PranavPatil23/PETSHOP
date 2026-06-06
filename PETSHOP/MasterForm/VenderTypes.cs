using KWC.BCS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KWC.BCS.Controls.Extensions;

namespace PETSHOP
{
    public partial class VenderTypes : Form
    {
        DbManager dbm = DbManager.Instance;
        public VenderTypes()
        {
            InitializeComponent();
        }

        private void VenderTypes_Load(object sender, EventArgs e)
        {
            txtVendortypeID.DataBindings.Add(new Binding("Text", dbm.bsVendorTypes, "VendorTypeID", true));
            txtVendortypeName.DataBindings.Add(new Binding("Text", dbm.bsVendorTypes, "VendorTypeName", true));

            DgvVendorType.DataSource = dbm.bsVendorTypes;
            DgvVendorType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvVendorType.AllowUserToAddRows = false;

            crudVendorType.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "VendorTypes";
                c.PrimaryKey = "VendorTypeID";
                c.PrimaryKeyTextBox = txtVendortypeID;
                c.AddPrimaryKey = true;
            });
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }   

      
    }

