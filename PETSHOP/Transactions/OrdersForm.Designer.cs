namespace PETSHOP.Transactions
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.lblvname = new System.Windows.Forms.Label();
            this.cbVendorsOrders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVlists = new System.Windows.Forms.TabControl();
            this.tabVendorList = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.dgvOrdersForms = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btInvoice = new System.Windows.Forms.Button();
            this.btUpdateStock = new System.Windows.Forms.Button();
            this.btPayment = new System.Windows.Forms.Button();
            this.btOrderDetails = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.crudOrders = new KWC.BCS.Controls.CrudControl();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.GR1Vendortype = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtOrders = new System.Windows.Forms.DateTimePicker();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblStatusID = new System.Windows.Forms.Label();
            this.cbStstusID = new System.Windows.Forms.ComboBox();
            this.chkUpdateStock = new System.Windows.Forms.CheckBox();
            this.GR2Vendortype = new System.Windows.Forms.GroupBox();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.newDataSet = new PETSHOP.NewDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabVlists.SuspendLayout();
            this.tabVendorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.GR1Vendortype.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GR2Vendortype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 654);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightYellow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightYellow;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lblvname);
            this.splitContainer1.Panel1.Controls.Add(this.cbVendorsOrders);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightYellow;
            this.splitContainer1.Panel2.Controls.Add(this.tabVlists);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 654);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblvname
            // 
            this.lblvname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblvname.AutoSize = true;
            this.lblvname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvname.Location = new System.Drawing.Point(409, 24);
            this.lblvname.Name = "lblvname";
            this.lblvname.Size = new System.Drawing.Size(64, 25);
            this.lblvname.TabIndex = 1;
            this.lblvname.Text = "label2";
            // 
            // cbVendorsOrders
            // 
            this.cbVendorsOrders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbVendorsOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendorsOrders.FormattingEnabled = true;
            this.cbVendorsOrders.Location = new System.Drawing.Point(155, 24);
            this.cbVendorsOrders.Name = "cbVendorsOrders";
            this.cbVendorsOrders.Size = new System.Drawing.Size(213, 33);
            this.cbVendorsOrders.TabIndex = 1;
            this.cbVendorsOrders.SelectedIndexChanged += new System.EventHandler(this.cbVendorsOrders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders of";
            // 
            // tabVlists
            // 
            this.tabVlists.Controls.Add(this.tabVendorList);
            this.tabVlists.Controls.Add(this.tabOrders);
            this.tabVlists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVlists.Location = new System.Drawing.Point(0, 0);
            this.tabVlists.Name = "tabVlists";
            this.tabVlists.Padding = new System.Drawing.Point(0, 0);
            this.tabVlists.SelectedIndex = 0;
            this.tabVlists.Size = new System.Drawing.Size(1012, 576);
            this.tabVlists.TabIndex = 0;
            // 
            // tabVendorList
            // 
            this.tabVendorList.BackColor = System.Drawing.Color.White;
            this.tabVendorList.Controls.Add(this.splitContainer6);
            this.tabVendorList.Location = new System.Drawing.Point(4, 34);
            this.tabVendorList.Name = "tabVendorList";
            this.tabVendorList.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendorList.Size = new System.Drawing.Size(1004, 538);
            this.tabVendorList.TabIndex = 0;
            this.tabVendorList.Text = "VLIst";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.Color.LightYellow;
            this.splitContainer6.Size = new System.Drawing.Size(998, 532);
            this.splitContainer6.SplitterDistance = 477;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.dgvOrdersForms);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.chart1);
            this.splitContainer7.Size = new System.Drawing.Size(998, 477);
            this.splitContainer7.SplitterDistance = 491;
            this.splitContainer7.TabIndex = 0;
            // 
            // dgvOrdersForms
            // 
            this.dgvOrdersForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersForms.Location = new System.Drawing.Point(0, 0);
            this.dgvOrdersForms.Name = "dgvOrdersForms";
            this.dgvOrdersForms.RowTemplate.Height = 28;
            this.dgvOrdersForms.Size = new System.Drawing.Size(491, 477);
            this.dgvOrdersForms.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(503, 477);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.White;
            this.tabOrders.Controls.Add(this.splitContainer2);
            this.tabOrders.Location = new System.Drawing.Point(4, 34);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(1004, 538);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightYellow;
            this.splitContainer2.Size = new System.Drawing.Size(998, 532);
            this.splitContainer2.SplitterDistance = 471;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel1.Controls.Add(this.btInvoice);
            this.splitContainer3.Panel1.Controls.Add(this.btUpdateStock);
            this.splitContainer3.Panel1.Controls.Add(this.btPayment);
            this.splitContainer3.Panel1.Controls.Add(this.btOrderDetails);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(998, 471);
            this.splitContainer3.SplitterDistance = 157;
            this.splitContainer3.TabIndex = 1;
            // 
            // btInvoice
            // 
            this.btInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btInvoice.Image")));
            this.btInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInvoice.Location = new System.Drawing.Point(-1, 240);
            this.btInvoice.Name = "btInvoice";
            this.btInvoice.Size = new System.Drawing.Size(155, 39);
            this.btInvoice.TabIndex = 3;
            this.btInvoice.Text = "Invoice";
            this.btInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInvoice.UseVisualStyleBackColor = true;
            this.btInvoice.Click += new System.EventHandler(this.btInvoice_Click);
            // 
            // btUpdateStock
            // 
            this.btUpdateStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateStock.Image = ((System.Drawing.Image)(resources.GetObject("btUpdateStock.Image")));
            this.btUpdateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpdateStock.Location = new System.Drawing.Point(2, 159);
            this.btUpdateStock.Name = "btUpdateStock";
            this.btUpdateStock.Size = new System.Drawing.Size(152, 39);
            this.btUpdateStock.TabIndex = 2;
            this.btUpdateStock.Text = "Update Stock";
            this.btUpdateStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpdateStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUpdateStock.UseVisualStyleBackColor = true;
            this.btUpdateStock.Click += new System.EventHandler(this.btUpdateStock_Click);
            // 
            // btPayment
            // 
            this.btPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayment.Image = ((System.Drawing.Image)(resources.GetObject("btPayment.Image")));
            this.btPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPayment.Location = new System.Drawing.Point(2, 89);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(152, 39);
            this.btPayment.TabIndex = 1;
            this.btPayment.Text = "Payment";
            this.btPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPayment.UseVisualStyleBackColor = true;
            this.btPayment.Click += new System.EventHandler(this.btPayment_Click_1);
            // 
            // btOrderDetails
            // 
            this.btOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderDetails.Image = ((System.Drawing.Image)(resources.GetObject("btOrderDetails.Image")));
            this.btOrderDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btOrderDetails.Location = new System.Drawing.Point(2, 28);
            this.btOrderDetails.Name = "btOrderDetails";
            this.btOrderDetails.Size = new System.Drawing.Size(152, 39);
            this.btOrderDetails.TabIndex = 0;
            this.btOrderDetails.Text = "Order Details";
            this.btOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOrderDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrderDetails.UseVisualStyleBackColor = true;
            this.btOrderDetails.Click += new System.EventHandler(this.btOrderDetails_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.crudOrders);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(837, 471);
            this.splitContainer4.SplitterDistance = 44;
            this.splitContainer4.TabIndex = 0;
            // 
            // crudOrders
            // 
            this.crudOrders.BackColor = System.Drawing.Color.LightCyan;
            this.crudOrders.BindingSource = null;
            this.crudOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudOrders.Location = new System.Drawing.Point(0, 0);
            this.crudOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crudOrders.Name = "crudOrders";
            this.crudOrders.PrimaryKeyTextBox = null;
            this.crudOrders.Size = new System.Drawing.Size(837, 44);
            this.crudOrders.TabIndex = 2;
            this.crudOrders.UserAdd += new System.EventHandler(this.crudOrders_UserAdd_1);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.GR1Vendortype);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.GR2Vendortype);
            this.splitContainer5.Size = new System.Drawing.Size(837, 423);
            this.splitContainer5.SplitterDistance = 194;
            this.splitContainer5.TabIndex = 0;
            // 
            // GR1Vendortype
            // 
            this.GR1Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR1Vendortype.Controls.Add(this.tableLayoutPanel1);
            this.GR1Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR1Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR1Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR1Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR1Vendortype.Name = "GR1Vendortype";
            this.GR1Vendortype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR1Vendortype.Size = new System.Drawing.Size(837, 194);
            this.GR1Vendortype.TabIndex = 1;
            this.GR1Vendortype.TabStop = false;
            this.GR1Vendortype.Text = "Data Entry";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dtOrders, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOrderID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbStstusID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkUpdateStock, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtOrders
            // 
            this.dtOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtOrders.Location = new System.Drawing.Point(129, 46);
            this.dtOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtOrders.Name = "dtOrders";
            this.dtOrders.Size = new System.Drawing.Size(390, 31);
            this.dtOrders.TabIndex = 1;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(30, 9);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(91, 23);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "OrderID:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(4, 50);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(117, 23);
            this.lblOrderDate.TabIndex = 1;
            this.lblOrderDate.Text = "OrderDate:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(129, 5);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(390, 31);
            this.txtOrderID.TabIndex = 2;
            // 
            // lblStatusID
            // 
            this.lblStatusID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusID.Location = new System.Drawing.Point(29, 91);
            this.lblStatusID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(92, 23);
            this.lblStatusID.TabIndex = 4;
            this.lblStatusID.Text = "StatusID:";
            // 
            // cbStstusID
            // 
            this.cbStstusID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStstusID.FormattingEnabled = true;
            this.cbStstusID.Location = new System.Drawing.Point(129, 87);
            this.cbStstusID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStstusID.Name = "cbStstusID";
            this.cbStstusID.Size = new System.Drawing.Size(390, 31);
            this.cbStstusID.TabIndex = 8;
            // 
            // chkUpdateStock
            // 
            this.chkUpdateStock.AutoSize = true;
            this.chkUpdateStock.Location = new System.Drawing.Point(128, 126);
            this.chkUpdateStock.Name = "chkUpdateStock";
            this.chkUpdateStock.Size = new System.Drawing.Size(178, 27);
            this.chkUpdateStock.TabIndex = 9;
            this.chkUpdateStock.Text = "Update Stock?";
            this.chkUpdateStock.UseVisualStyleBackColor = true;
            // 
            // GR2Vendortype
            // 
            this.GR2Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR2Vendortype.Controls.Add(this.DgvOrders);
            this.GR2Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR2Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR2Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR2Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Name = "GR2Vendortype";
            this.GR2Vendortype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Size = new System.Drawing.Size(837, 225);
            this.GR2Vendortype.TabIndex = 1;
            this.GR2Vendortype.TabStop = false;
            this.GR2Vendortype.Text = "Data";
            // 
            // DgvOrders
            // 
            this.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOrders.Location = new System.Drawing.Point(4, 29);
            this.DgvOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.Size = new System.Drawing.Size(829, 191);
            this.DgvOrders.TabIndex = 2;
            // 
            // newDataSet
            // 
            this.newDataSet.DataSetName = "NewDataSet";
            this.newDataSet.Locale = new System.Globalization.CultureInfo("");
            this.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.newDataSet;
            // 
            // OrdersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabVlists.ResumeLayout(false);
            this.tabVendorList.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.GR1Vendortype.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GR2Vendortype.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbVendorsOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabVlists;
        private System.Windows.Forms.TabPage tabVendorList;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btInvoice;
        private System.Windows.Forms.Button btUpdateStock;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Button btOrderDetails;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private KWC.BCS.Controls.CrudControl crudOrders;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox GR1Vendortype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtOrders;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.ComboBox cbStstusID;
        private System.Windows.Forms.CheckBox chkUpdateStock;
        private System.Windows.Forms.GroupBox GR2Vendortype;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.DataGridView dgvOrdersForms;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private NewDataSet newDataSet;
    }
}