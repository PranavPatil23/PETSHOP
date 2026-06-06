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
    public partial class Users : Form
    {
        DbManager dbm = DbManager.Instance;
        public Users()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            txtUID.DataBindings.Add(new Binding("Text", dbm.bsUsers, "UserID", true));
            txtUName.DataBindings.Add(new Binding("Text", dbm.bsUsers, "UserName", true));
            txtPassword.DataBindings.Add(new Binding("Text", dbm.bsUsers, "Password", true));

            DgvUsers.DataSource = dbm.bsUsers;
            DgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvUsers.AllowUserToAddRows = false;

            crudUsers.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Users";
                c.PrimaryKey = "UserID";
                c.PrimaryKeyTextBox = txtUID;
                c.AddPrimaryKey = true;
            });
        }
        
    }
}
