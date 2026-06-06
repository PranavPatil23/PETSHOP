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
    public partial class Login : Form
    {
        DbManager dbm = DbManager.Instance;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUN.SetWatermark("Enter User Name");
            txtPAS.SetWatermark("Enter Password");
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            var userName = txtUN.Text.Trim();
            var userPassword = txtPAS.Text.Trim();
            dbm.bsUsers.Filter = $"UserName='{userName}' AND Password = '{userPassword}'";

            if (dbm.bsUsers.Count > 0)


            {
                MessageBox.Show("Login Successful");
                this.Hide();
                var MDIform = new MDIform();
                MDIform.ShowDialog();
                this.Close();
                
            }
            else
            {

                MessageBox.Show("Login Error !!!");
                dbm.bsUsers.RemoveFilter();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtUN.Text = String.Empty;
            txtPAS.Text = String.Empty;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtPAS.UseSystemPasswordChar = false;
            }
            else
            {
                txtPAS.UseSystemPasswordChar = true;
            }
        }

     
    }
}

