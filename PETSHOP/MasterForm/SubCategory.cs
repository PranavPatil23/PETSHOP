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
    public partial class SubCategory : Form
    {
        DbManager dbm = DbManager.Instance;
        public SubCategory()
        {
            InitializeComponent();

             dbm.crCategorySubCategory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            cbCategroy.DataSource = dbm.bsCategory;
            cbCategroy.DisplayMember = "CategoryName";
            cbCategroy.ValueMember = "CategoryID";

           // cbCategroy.DataBindings.Add(new Binding("selectedvalue", dbm.bsSubCategory, "CategoryID", true));

            txtSCID.DataBindings.Add(new Binding("Text", dbm.bsSubCategory, "SubCategoryID", true));
            txtSCN.DataBindings.Add(new Binding("Text", dbm.bsSubCategory, "SubCategoryName", true));
        

            DgvSC.DataSource = dbm.bsSubCategory;
            DgvSC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvSC.AllowUserToAddRows = false;

            crudSC.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "SubCategory";
                c.PrimaryKey = "SubCategoryID";
                c.PrimaryKeyTextBox = txtSCID;
                c.AddPrimaryKey = true;
            });

        }
    }
}
