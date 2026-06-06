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


namespace PETSHOP
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petdbDataSet.Product' table. You can move, or remove it, as needed.
         

            this.reportViewer1.RefreshReport();
        }

        private void newDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
