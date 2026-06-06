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
using KWC.BCS.Validations;


namespace PETSHOP.Transactions
{
    public partial class Payment : Form
    {
        DbManager dbm = DbManager.Instance;
        public Payment()
        {
            InitializeComponent();
 
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            #region
            lblVN.DataBindings.Add(new Binding("Text",dbm.bsVendors, "VendorName", true));
            lblVT.DataBindings.Add(new Binding("Text", dbm.bsVendorTypes, "VendorTypeName", true));
            lblOrderID.DataBindings.Add(new Binding("Text", dbm.bsOrders, "OrderID", true));
            lblNT.DataBindings.Add(new Binding("Text", dbm.bsOrders, "NetTotal", true));
            lblDue.DataBindings.Add(new Binding("Text", dbm.bsOrders, "Due", true));
            //lblNT.SetCurrencyFormat();
            //lblDue.SetCurrencyFormat();
            #endregion

            cbPayments.DataSource = dbm.bsModes;
            cbPayments.DisplayMember = "ModeName";
            cbPayments.ValueMember = "ModeID";

            txtPaymentID.DataBindings.Add(new Binding("Text", dbm.bsPayments, "PaymentID", true));
            dtPayment.DataBindings.Add(new Binding("value", dbm.bsPayments, "PaymentDate", true));
            cbPayments.DataBindings.Add(new Binding("Selectedvalue", dbm.bsPayments, "ModeID", true));
            txtAmount.DataBindings.Add(new Binding("Text", dbm.bsPayments, "Amount", true));
            txtDescription.DataBindings.Add(new Binding("Text", dbm.bsPayments, "Description", true));

            DgvPayments.DataSource = dbm.bsPayments;
            DgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvPayments.AllowUserToAddRows = false;

            crudPayment.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Payments";
                c.PrimaryKey = "PaymentID";
                c.PrimaryKeyTextBox = txtPaymentID;
                c.AddPrimaryKey = true;
            });
        }

    
   

        private void crudPayment_UserAdd_1(object sender, EventArgs e)
        {
            dtPayment.Value = DateTime.Now.Date;
            cbPayments.SelectedValue = 1;
            var rowOrder = dbm.GetCurrentRow(dbm.bsOrders);
            txtAmount.Text = rowOrder["Due"].ToString();
        }

        private void crudPayment_ValidateControls_1(object sender, EventArgs e)
        {
            var amount = txtAmount.Text;
            try
            {
                ValidateThe.Parameter(nameof(amount), amount).IsNumber();
                var rowOrder = dbm.bsOrders.CurrentRow();
                int dueAmount = rowOrder["Due"].ToIntAmount();
                int userAmount = txtAmount.Text.ToIntAmount();
                if (userAmount > dueAmount)
                {

                    crudPayment.ValidData = false;
                    MessageBox.Show("Cannot Save Amount > Due", "Save ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    crudPayment.ValidData = true;
                }
            }
            catch (Exception ex)
            {
                crudPayment.ValidData = false;
                MessageBox.Show(ex.Message, "ERROR - Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
    }
}
