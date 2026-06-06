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
    public partial class LoginPage : Form
    {
        DbManager dbm = DbManager.Instance;
        public LoginPage()
        {
            InitializeComponent();
        }



        private void LoginPage_Load(object sender, EventArgs e)
        //{
        //    txtUserN.SetWatermark("Enter User Name");
        //    txtPas.SetWatermark("Enter Password");
        }

    private void button1_Click(object sender, EventArgs e)
    {
        var userName = txtUserN.Text.Trim();
        var userPassword = txtPas.Text.Trim();
        dbm.bsUsers.Filter = $"UserName='{userName}' AND Password = '{userPassword}'";

        if (dbm.bsUsers.Count > 0)


        {
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

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

        if (checkBox1.Checked)
        {
            txtPas.UseSystemPasswordChar = false;
        }
        else
        {
            txtPas.UseSystemPasswordChar = true;
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        txtUserN.Text = String.Empty;
        txtPas.Text = String.Empty;
    }


}
}
