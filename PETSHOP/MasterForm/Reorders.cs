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
    public partial class Reorders : Form
    {
        DbManager dbm = DbManager.Instance;
        public Reorders()
        {
            InitializeComponent();
        }

        private void Reorders_Load(object sender, EventArgs e)
        {

            DgvReorders.DataSource = dbm.bsReorders;
            DgvReorders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvReorders.AllowUserToAddRows = false;
        }
    }
}
