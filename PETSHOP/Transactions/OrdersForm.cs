using System;
using System.Windows.Forms;
using KWC.BCS.Reports;
using KWC.BCS.Controls.Extensions;
using System.Windows.Forms.DataVisualization.Charting;


namespace PETSHOP.Transactions
{
    public partial class OrdersForm : Form
    {
        DbManager dbm = DbManager.Instance;
        public OrdersForm()
        {
            InitializeComponent();
            dbm.crVendors();
            dbm.crVendorOrders();
            dbm.crOrderDetails();
            dbm.crOrderPayments();

            dbm.AddColumn("OrderDetails", "Rate", "UnitPrice + (UnitPrice * Margin) / 100");
            dbm.AddColumn("OrderDetails", "LineTotal", "Quantity * Rate");
            // Add Computed Columns for Orders
            dbm.AddColumn("Orders", "OrderTotal", "IsNull(Sum(Child (Orders2OrderDetails).LineTotal), 0)");
            dbm.AddColumn("Orders", "SGST", "IsNull((OrderTotal * 18 ) / 100, 0)");
            dbm.AddColumn("Orders", "CGST", "IsNull((OrderTotal * 18 ) / 100, 0)");
             dbm.AddColumn("Orders", "NetTotal", "IsNull(OrderTotal + SGST + CGST, 0)");
             dbm.AddColumn("Orders", "OrderPaid", "IsNull(Sum(Child(Orders2Payments).Amount), 0.00)");
            dbm.AddColumn("Orders", "Due", "NetTotal - OrderPaid");
            dbm.AddColumn("Vendors", "NetTotal", "IsNull(Sum(Child.NetTotal), 0.00)");
            dbm.AddColumn("Vendors", "Due", "IsNull(Sum(Child.Due), 0.00)");


        }



        private void OrdersForm_Load(object sender, EventArgs e)
        {
            #region vendor Tab
            //combobox Vendors
            cbVendorsOrders.DataSource = dbm.bsVendorTypes;
            cbVendorsOrders.DisplayMember = "VendorTypeName";
            cbVendorsOrders.ValueMember = "VendorTypeId";

            dgvOrdersForms.DataSource = dbm.bsVendors;
            dgvOrdersForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrdersForms.AllowUserToAddRows = false;

            dgvOrdersForms.ReorderColumns(new[] { "VendorName", "Address", "Phone" });




            tabVlists.TabPages[0].DataBindings.Add(new Binding("Text", dbm.bsVendorTypes, "VendorTypeName", true));
            #endregion 

            #region Orders
            //Orders
            cbStstusID.DataSource = dbm.bsStatus;
            cbStstusID.DisplayMember = "StatusName";
            cbStstusID.ValueMember = "StatusID";
          
           

            txtOrderID.DataBindings.Add(new Binding("Text", dbm.bsOrders, "OrderID", true));
            dtOrders.DataBindings.Add(new Binding("value", dbm.bsOrders, "OrderDate", true));
            cbStstusID.DataBindings.Add(new Binding("selectedvalue", dbm.bsOrders, "StatusID", true));
            lblvname.DataBindings.Add(new Binding("Text", dbm.bsVendors, "VendorName", true));


            DgvOrders.DataSource = dbm.bsOrders;
            DgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvOrders.AllowUserToAddRows = false;

            DgvOrders.AddComboColumn("Order Status", dbm.bsStatus,"StatusName", "StatusID");

            crudOrders.With(c =>
            {
                c.DbAccess = dbm;
                c.TableName = "Orders";
                c.PrimaryKey = "OrderID";
                c.PrimaryKeyTextBox = txtOrderID;
                c.AddPrimaryKey = true;
            });
            //Orders end
            #endregion
            #region UpdateStock
            chkUpdateStock.DataBindings.Add(new Binding("Checked",dbm.bsOrders, "UpdateStock", true));
            btUpdateStock.DataBindings.Add(new Binding("Visible",dbm.bsOrders, "UpdateStock", true));
            #endregion

            #region Order Details and Payments
            // Customize DataGridView Columns
            DgvOrders.SetCurrencyFormat(new[] { "OrderTotal", "SGST", "CGST", "NetTotal" });
            // Customize DataGridView Columns
            DgvOrders.SetCurrencyFormat(new[] { "OrderPaid", "Due" });
            #endregion



        }
        private void Chart()
        {
            #region Chart
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Total Due Chart");
            chart1.Series.Add("NetTotal");
            chart1.Series["NetTotal"].ChartType = SeriesChartType.Column;
            chart1.DataSource = dbm.bsVendors;
            chart1.Series["NetTotal"].XValueMember = "VendorName";
            chart1.Series["NetTotal"].YValueMembers = "NetTotal";
            chart1.Series["NetTotal"].IsValueShownAsLabel = true;
            chart1.Series.Add("Due");
            chart1.Series["Due"].ChartType = SeriesChartType.Column;
            chart1.Series["Due"].XValueMember = "VendorName";
            chart1.Series["Due"].YValueMembers = "Due";
            chart1.Series["Due"].IsValueShownAsLabel = true;  
            
            #endregion
        }
       

        private void btInvoice_Click(object sender, EventArgs e)
        {
            var rowVendors = dbm.GetCurrentRow(dbm.bsVendors);
            var rowOrders = dbm.GetCurrentRow(dbm.bsOrders);
            var rowOrderDetails = dbm.GetCurrentRow(dbm.bsOrderDetails);
            var rowStatus = dbm.GetCurrentRow(dbm.bsStatus);
            var rpt = new RdlcReport(@"Report\rptInvoice");

            rpt.AddDataSource("Vendors", dbm.bsVendors);
            rpt.AddDataSource("Orders", dbm.bsOrders);
            rpt.AddDataSource("OrderDetails", dbm.bsOrderDetails);
            rpt.AddDataSource("Status", dbm.bsStatus);
            rpt.AddParameter(rowVendors, new[] { "VendorName", "Address" });
            rpt.AddParameter(rowOrders, new[] { "OrderID", "OrderDate", "OrderTotal", "SGST", "CGST", "NetTotal" });
            rpt.AddParameter(rowOrderDetails, new[] { "Rate", "LineTotal" });
            rpt.AddParameter(rowStatus, new[] { "StatusName" });
            rpt.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbm.GetReportDataSetXml(@"d:\", "PetShopDataset");
        }

        private void btOrderDetails_Click(object sender, EventArgs e)
        {
           
            var OrderDetails = new OrderDetails();
            OrderDetails.MdiParent = this.ParentForm;
            OrderDetails.Show();
        }

        private void btPayment_Click_1(object sender, EventArgs e)
        {
            
            var Payment = new Payment();
            Payment.MdiParent = this.ParentForm;
            Payment.Show();
        }

        private void btUpdateStock_Click(object sender, EventArgs e)
        {
           
            var UpdateStock = new UpdateStock();
            UpdateStock.MdiParent = this.ParentForm;
            UpdateStock.Show();
        }

        private void cbVendorsOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart();


        }

        private void crudOrders_UserAdd_1(object sender, EventArgs e)
        {
            dtOrders.Value = DateTime.Now.Date;
            cbStstusID.SelectedValue = 1;
            chkUpdateStock.Checked = true;
        }
    }




}
