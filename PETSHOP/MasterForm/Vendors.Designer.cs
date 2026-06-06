namespace PETSHOP
{
    partial class Vendors
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
            this.cbVendorTypes = new System.Windows.Forms.ComboBox();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.crudVendors = new KWC.BCS.Controls.CrudControl();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GR1Vendortype = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVendortypeID = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblVendortypeName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.GR2Vendortype = new System.Windows.Forms.GroupBox();
            this.DgvVendors = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitContainer1.Panel1.Controls.Add(this.cbVendorTypes);
            this.splitContainer1.Panel1.Controls.Add(this.l);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 774);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbVendorTypes
            // 
            this.cbVendorTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbVendorTypes.FormattingEnabled = true;
            this.cbVendorTypes.Location = new System.Drawing.Point(162, 43);
            this.cbVendorTypes.Name = "cbVendorTypes";
            this.cbVendorTypes.Size = new System.Drawing.Size(209, 28);
            this.cbVendorTypes.TabIndex = 10;
            // 
            // l
            // 
            this.l.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.SystemColors.Window;
            this.l.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(13, 43);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(142, 23);
            this.l.TabIndex = 9;
            this.l.Text = "VendorTypes:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(457, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vendors:";
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
            this.splitContainer2.Size = new System.Drawing.Size(1137, 685);
            this.splitContainer2.SplitterDistance = 592;
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
            this.splitContainer3.Panel1.Controls.Add(this.crudVendors);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1137, 592);
            this.splitContainer3.SplitterDistance = 60;
            this.splitContainer3.TabIndex = 0;
            // 
            // crudVendors
            // 
            this.crudVendors.BackColor = System.Drawing.Color.LightCyan;
            this.crudVendors.BindingSource = null;
            this.crudVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudVendors.Location = new System.Drawing.Point(0, 0);
            this.crudVendors.Name = "crudVendors";
            this.crudVendors.PrimaryKeyTextBox = null;
            this.crudVendors.Size = new System.Drawing.Size(60, 592);
            this.crudVendors.TabIndex = 3;
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
            this.splitContainer4.Size = new System.Drawing.Size(1073, 592);
            this.splitContainer4.SplitterDistance = 442;
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
            this.GR1Vendortype.Size = new System.Drawing.Size(442, 592);
            this.GR1Vendortype.TabIndex = 3;
            this.GR1Vendortype.TabStop = false;
            this.GR1Vendortype.Text = "Data Entry";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblVendortypeID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtContactNo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVendortypeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtVendorID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVendorName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblContactNo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblVendortypeID
            // 
            this.lblVendortypeID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendortypeID.AutoSize = true;
            this.lblVendortypeID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendortypeID.Location = new System.Drawing.Point(44, 9);
            this.lblVendortypeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendortypeID.Name = "lblVendortypeID";
            this.lblVendortypeID.Size = new System.Drawing.Size(107, 23);
            this.lblVendortypeID.TabIndex = 0;
            this.lblVendortypeID.Text = "VendorID:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(159, 128);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(228, 31);
            this.txtContactNo.TabIndex = 8;
            // 
            // lblVendortypeName
            // 
            this.lblVendortypeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendortypeName.AutoSize = true;
            this.lblVendortypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendortypeName.Location = new System.Drawing.Point(4, 50);
            this.lblVendortypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendortypeName.Name = "lblVendortypeName";
            this.lblVendortypeName.Size = new System.Drawing.Size(147, 23);
            this.lblVendortypeName.TabIndex = 1;
            this.lblVendortypeName.Text = "VendorName:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(159, 87);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 31);
            this.txtAddress.TabIndex = 7;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorID.Location = new System.Drawing.Point(159, 5);
            this.txtVendorID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(228, 31);
            this.txtVendorID.TabIndex = 2;
            // 
            // txtVendorName
            // 
            this.txtVendorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.Location = new System.Drawing.Point(159, 46);
            this.txtVendorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(228, 31);
            this.txtVendorName.TabIndex = 3;
            // 
            // lblContactNo
            // 
            this.lblContactNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(74, 132);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(77, 23);
            this.lblContactNo.TabIndex = 4;
            this.lblContactNo.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(57, 91);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 23);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // GR2Vendortype
            // 
            this.GR2Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR2Vendortype.Controls.Add(this.DgvVendors);
            this.GR2Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR2Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR2Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR2Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Name = "GR2Vendortype";
            this.GR2Vendortype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Size = new System.Drawing.Size(627, 592);
            this.GR2Vendortype.TabIndex = 2;
            this.GR2Vendortype.TabStop = false;
            this.GR2Vendortype.Text = "Data";
            this.GR2Vendortype.Enter += new System.EventHandler(this.GR2Vendortype_Enter);
            // 
            // DgvVendors
            // 
            this.DgvVendors.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVendors.Location = new System.Drawing.Point(4, 29);
            this.DgvVendors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvVendors.Name = "DgvVendors";
            this.DgvVendors.Size = new System.Drawing.Size(619, 558);
            this.DgvVendors.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 774);
            this.panel1.TabIndex = 11;
            // 
            // Vendors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1137, 774);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vendors";
            this.Text = "Vendors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vendors_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox cbVendorTypes;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GR1Vendortype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVendortypeID;
        private System.Windows.Forms.Label lblVendortypeName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.GroupBox GR2Vendortype;
        private System.Windows.Forms.DataGridView DgvVendors;
        private KWC.BCS.Controls.CrudControl crudVendors;
        private System.Windows.Forms.Panel panel1;
    }
}