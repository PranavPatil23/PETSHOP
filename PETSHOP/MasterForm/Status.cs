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
    public partial class Status : Form
    {
        DbManager dbm = DbManager.Instance;
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {

            txtStatusID.DataBindings.Add(new Binding("Text", dbm.bsStatus, "StatusID", true));
            txtStatusName.DataBindings.Add(new Binding("Text", dbm.bsStatus, "StatusName", true));

            DgvStatus.DataSource = dbm.bsStatus;
            DgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvStatus.AllowUserToAddRows = false;

            crudStatus.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Status";
                c.PrimaryKey = "StatusID";
                c.PrimaryKeyTextBox = txtStatusID;
                c.AddPrimaryKey = true;
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
