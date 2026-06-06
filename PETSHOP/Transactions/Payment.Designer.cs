namespace PETSHOP.Transactions
{
    partial class Payment
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDues = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblNT = new System.Windows.Forms.Label();
            this.lblVT = new System.Windows.Forms.Label();
            this.lblVN = new System.Windows.Forms.Label();
            this.lblPaymentOF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.crudPayment = new KWC.BCS.Controls.CrudControl();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GR1Vendortype = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtPayment = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblModeID = new System.Windows.Forms.Label();
            this.cbPayments = new System.Windows.Forms.ComboBox();
            this.GR2Vendortype = new System.Windows.Forms.GroupBox();
            this.DgvPayments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.GR1Vendortype.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GR2Vendortype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPayments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 640);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDues);
            this.groupBox1.Controls.Add(this.lblDue);
            this.groupBox1.Controls.Add(this.lblNetTotal);
            this.groupBox1.Controls.Add(this.lblNT);
            this.groupBox1.Controls.Add(this.lblVT);
            this.groupBox1.Controls.Add(this.lblVN);
            this.groupBox1.Controls.Add(this.lblPaymentOF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // lblDues
            // 
            this.lblDues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDues.AutoSize = true;
            this.lblDues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDues.Location = new System.Drawing.Point(543, 55);
            this.lblDues.Name = "lblDues";
            this.lblDues.Size = new System.Drawing.Size(54, 25);
            this.lblDues.TabIndex = 8;
            this.lblDues.Text = "Due:";
            // 
            // lblDue
            // 
            this.lblDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblDue.Location = new System.Drawing.Point(603, 55);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(48, 25);
            this.lblDue.TabIndex = 6;
            this.lblDue.Text = "Due";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.Location = new System.Drawing.Point(343, 55);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(92, 25);
            this.lblNetTotal.TabIndex = 7;
            this.lblNetTotal.Text = "NetTotal:";
            // 
            // lblNT
            // 
            this.lblNT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNT.AutoSize = true;
            this.lblNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNT.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblNT.Location = new System.Drawing.Point(440, 55);
            this.lblNT.Name = "lblNT";
            this.lblNT.Size = new System.Drawing.Size(86, 25);
            this.lblNT.TabIndex = 5;
            this.lblNT.Text = "NetTotal";
            // 
            // lblVT
            // 
            this.lblVT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVT.AutoSize = true;
            this.lblVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVT.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblVT.Location = new System.Drawing.Point(220, 30);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(126, 25);
            this.lblVT.TabIndex = 4;
            this.lblVT.Text = "Vendor Type";
            // 
            // lblVN
            // 
            this.lblVN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVN.AutoSize = true;
            this.lblVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVN.ForeColor = System.Drawing.Color.Blue;
            this.lblVN.Location = new System.Drawing.Point(355, 30);
            this.lblVN.Name = "lblVN";
            this.lblVN.Size = new System.Drawing.Size(133, 25);
            this.lblVN.TabIndex = 3;
            this.lblVN.Text = "Vendor Name";
            // 
            // lblPaymentOF
            // 
            this.lblPaymentOF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaymentOF.AutoSize = true;
            this.lblPaymentOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentOF.Location = new System.Drawing.Point(98, 30);
            this.lblPaymentOF.Name = "lblPaymentOF";
            this.lblPaymentOF.Size = new System.Drawing.Size(116, 25);
            this.lblPaymentOF.TabIndex = 2;
            this.lblPaymentOF.Text = "Payment of:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "OrderID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblOrderID.Location = new System.Drawing.Point(229, 55);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(87, 25);
            this.lblOrderID.TabIndex = 9;
            this.lblOrderID.Text = "OrderID:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitContainer2.Size = new System.Drawing.Size(1046, 548);
            this.splitContainer2.SplitterDistance = 485;
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
            this.splitContainer3.Panel1.Controls.Add(this.crudPayment);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1046, 485);
            this.splitContainer3.SplitterDistance = 75;
            this.splitContainer3.TabIndex = 0;
            // 
            // crudPayment
            // 
            this.crudPayment.BackColor = System.Drawing.Color.LightCyan;
            this.crudPayment.BindingSource = null;
            this.crudPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudPayment.Location = new System.Drawing.Point(0, 0);
            this.crudPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crudPayment.Name = "crudPayment";
            this.crudPayment.PrimaryKeyTextBox = null;
            this.crudPayment.Size = new System.Drawing.Size(75, 485);
            this.crudPayment.TabIndex = 1;
            this.crudPayment.ValidateControls += new System.EventHandler(this.crudPayment_ValidateControls_1);
            this.crudPayment.UserAdd += new System.EventHandler(this.crudPayment_UserAdd_1);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.GR1Vendortype);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.GR2Vendortype);
            this.splitContainer4.Size = new System.Drawing.Size(967, 485);
            this.splitContainer4.SplitterDistance = 372;
            this.splitContainer4.TabIndex = 0;
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
            this.GR1Vendortype.Size = new System.Drawing.Size(372, 485);
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
            this.tableLayoutPanel1.Controls.Add(this.dtPayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPaymentID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblModeID, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbPayments, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtPayment
            // 
            this.dtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPayment.Location = new System.Drawing.Point(160, 46);
            this.dtPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Size = new System.Drawing.Size(192, 31);
            this.dtPayment.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(27, 91);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(160, 87);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 31);
            this.txtDescription.TabIndex = 11;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(30, 9);
            this.lblPaymentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(122, 23);
            this.lblPaymentID.TabIndex = 0;
            this.lblPaymentID.Text = "PaymentID:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(4, 50);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(148, 23);
            this.lblPaymentDate.TabIndex = 1;
            this.lblPaymentDate.Text = "PaymentDate:";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.Location = new System.Drawing.Point(160, 5);
            this.txtPaymentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(192, 31);
            this.txtPaymentID.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(59, 132);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(93, 23);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(160, 128);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(192, 31);
            this.txtAmount.TabIndex = 8;
            // 
            // lblModeID
            // 
            this.lblModeID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModeID.AutoSize = true;
            this.lblModeID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeID.Location = new System.Drawing.Point(79, 171);
            this.lblModeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeID.Name = "lblModeID";
            this.lblModeID.Size = new System.Drawing.Size(73, 23);
            this.lblModeID.TabIndex = 5;
            this.lblModeID.Text = "Mode:";
            // 
            // cbPayments
            // 
            this.cbPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPayments.FormattingEnabled = true;
            this.cbPayments.Location = new System.Drawing.Point(159, 167);
            this.cbPayments.Name = "cbPayments";
            this.cbPayments.Size = new System.Drawing.Size(194, 31);
            this.cbPayments.TabIndex = 12;
            // 
            // GR2Vendortype
            // 
            this.GR2Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR2Vendortype.Controls.Add(this.DgvPayments);
            this.GR2Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR2Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR2Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR2Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Name = "GR2Vendortype";
            this.GR2Vendortype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Size = new System.Drawing.Size(591, 485);
            this.GR2Vendortype.TabIndex = 1;
            this.GR2Vendortype.TabStop = false;
            this.GR2Vendortype.Text = "Data";
            // 
            // DgvPayments
            // 
            this.DgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPayments.Location = new System.Drawing.Point(4, 29);
            this.DgvPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvPayments.Name = "DgvPayments";
            this.DgvPayments.Size = new System.Drawing.Size(583, 451);
            this.DgvPayments.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 640);
            this.panel1.TabIndex = 10;
            // 
            // Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            this.GR1Vendortype.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GR2Vendortype.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPayments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDues;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblNT;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.Label lblVN;
        private System.Windows.Forms.Label lblPaymentOF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderID;
        private KWC.BCS.Controls.CrudControl crudPayment;
        private System.Windows.Forms.GroupBox GR1Vendortype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtPayment;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblModeID;
        private System.Windows.Forms.ComboBox cbPayments;
        private System.Windows.Forms.GroupBox GR2Vendortype;
        private System.Windows.Forms.DataGridView DgvPayments;
        private System.Windows.Forms.Panel panel1;
    }
}