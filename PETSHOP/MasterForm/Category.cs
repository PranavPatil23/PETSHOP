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
    public partial class Category : Form
    {
        DbManager dbm = DbManager.Instance;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            txtCategoryID.DataBindings.Add(new Binding("Text", dbm.bsCategory, "CategoryID", true));
            txtCategoryName.DataBindings.Add(new Binding("Text", dbm.bsCategory, "CategoryName", true));

            DgvCategory.DataSource = dbm.bsCategory;
            DgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvCategory.AllowUserToAddRows = false;

            crudCategory.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Category";
                c.PrimaryKey = "CategoryID";
                c.PrimaryKeyTextBox = txtCategoryID;
                c.AddPrimaryKey = true;
            });
        }
    }
}
