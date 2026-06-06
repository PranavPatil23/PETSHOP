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
    public partial class Modes : Form
    {
        DbManager dbm = DbManager.Instance;
        public Modes()
        {
            InitializeComponent();
        }

        private void Modes_Load(object sender, EventArgs e)
        {
           

            txtModeID.DataBindings.Add(new Binding("Text", dbm.bsModes, "ModeID", true));
            txtModeName.DataBindings.Add(new Binding("Text", dbm.bsModes, "ModeName", true));

            dataGridView1.DataSource = dbm.bsModes;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;

            crudControl1.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Modes";
                c.PrimaryKey = "ModeID";
                c.PrimaryKeyTextBox = txtModeID;
                c.AddPrimaryKey = true;
            });
        }
    }
}
