using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KWC.BCS.Reports;
using KWC.BCS.Controls.Extensions;
using PETSHOP.Transactions;
using PETSHOP.MasterForm;

namespace PETSHOP
{
    public partial class MDIform : Form
    {
        DbManager dbm = DbManager.Instance;
        private int childFormNumber = 0;

        public MDIform()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new VenderTypes();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Vendors();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Product();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

     

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new OrdersForm();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void MDIform_Load(object sender, EventArgs e)
        {
            int id = 1;

            var Product = dbm.bsProduct.CurrentRow();

            for(int R=0;R<dbm.bsReorders.Count;R++)
            {
                dbm.bsReorders.Position = R;
                dbm.bsReorders.RemoveCurrent();
                
            }
            dbm.SaveTable("Reorders","Reorder Table Cleared");

            for (int i = 0; i < dbm.bsProduct.Count; i++)
            {
                dbm.bsProduct.Position = i;
                Product = dbm.bsProduct.CurrentRow();

                int quantity = Product["Quantity"].ToInt();
                int reorderLevel = Product["ReorderLevel"].ToInt();

                if (quantity < reorderLevel)
                {
                    string productName = Product["ProductName"].ToString();

                    
              
                    dbm.bsReorders.AddNew();
                    var rowReorder = dbm.bsReorders.CurrentRow();
                    rowReorder["ReorderID"] = id;
                    rowReorder["ProductName"] = Product["ProductName"].ToString();
                    rowReorder["Quantity"] = quantity;
                    rowReorder["ReorderLevel"] = reorderLevel;
                    dbm.bsReorders.EndEdit();

                    id = id + 1;

                   // MessageBox.Show($"Product {productName} has a quantity below its reorder level (Current Quantity -{quantity} /ReorderLevel- {reorderLevel}) Order the Product");
                }


            }

            dbm.SaveTable("Reorders", "Quantity, Reorder Level");
            // MessageBox.Show("Check Reorderlevel");
            var frm = new Reorders();
            frm.MdiParent = this;
            frm.Show();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Category();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

      

      

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Status();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void modesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Modes();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpt = new RdlcReport(@"Report\rptProduct");
            rpt.AddDataSource("Product", dbm.bsProduct);
            rpt.Show();
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpt = new RdlcReport(@"Report\rptVendors");
            rpt.AddDataSource("Vendors", dbm.bsVendors);
            rpt.Show();
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpt = new RdlcReport(@"Report\rptPayments");
            rpt.AddDataSource("Payments", dbm.bsPayments);
            rpt.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Users();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var rpt = new RdlcReport(@"Report\rptOrderDetails");
            var rowOrderDetails = dbm.GetCurrentRow(dbm.bsOrderDetails);
            rpt.AddDataSource("OrderDetails", dbm.bsOrderDetails);
            //rpt.AddParameter(rowOrderDetails, new[] {  "Rate","LineTotal" });
            rpt.Show();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new SubCategory();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var Form = new Company();
            Form.MdiParent = this;
            Form.Text = "Window " + childFormNumber++;
            Form.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowOrders = dbm.GetCurrentRow(dbm.bsOrders);
            var rpt = new RdlcReport(@"Report\rptOrders");
            rpt.AddDataSource("Orders", dbm.bsOrders);
          //  rpt.AddParameter(rowOrders, new[] { "OrderTotal", "SGST", "CGST", "NetTotal" });
            rpt.Show();

        }
    }
}
