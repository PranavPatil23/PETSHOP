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

namespace PETSHOP.MasterForm
{
    public partial class Company : Form
    {
        DbManager dbm = DbManager.Instance;
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            txtCompanyID.DataBindings.Add(new Binding("Text", dbm.bsCompany, "CompanyID", true));
            txtCompanyName.DataBindings.Add(new Binding("Text", dbm.bsCompany, "CompanyName", true));
         


            DgvCompany.DataSource = dbm.bsCompany;
            DgvCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvCompany.AllowUserToAddRows = false;
            crudCompany.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Company";
                c.PrimaryKey = "CompanyID";
                c.PrimaryKeyTextBox = txtCompanyID;
                c.AddPrimaryKey = true;
            });
        }
    }
}
