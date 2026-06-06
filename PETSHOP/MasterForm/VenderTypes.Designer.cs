namespace PETSHOP
{
    partial class VenderTypes
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
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.crudVendorType = new KWC.BCS.Controls.CrudControl();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GR1Vendortype = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVendortypeID = new System.Windows.Forms.Label();
            this.lblVendortypeName = new System.Windows.Forms.Label();
            this.txtVendortypeID = new System.Windows.Forms.TextBox();
            this.txtVendortypeName = new System.Windows.Forms.TextBox();
            this.GR2Vendortype = new System.Windows.Forms.GroupBox();
            this.DgvVendorType = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendorType)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 703);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor Type:";
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
            this.splitContainer2.Size = new System.Drawing.Size(1143, 625);
            this.splitContainer2.SplitterDistance = 565;
            this.splitContainer2.SplitterWidth = 6;
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
            this.splitContainer3.Panel1.Controls.Add(this.crudVendorType);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1143, 565);
            this.splitContainer3.SplitterDistance = 71;
            this.splitContainer3.TabIndex = 0;
            // 
            // crudVendorType
            // 
            this.crudVendorType.BackColor = System.Drawing.Color.LightCyan;
            this.crudVendorType.BindingSource = null;
            this.crudVendorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudVendorType.Location = new System.Drawing.Point(0, 0);
            this.crudVendorType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crudVendorType.Name = "crudVendorType";
            this.crudVendorType.PrimaryKeyTextBox = null;
            this.crudVendorType.Size = new System.Drawing.Size(71, 565);
            this.crudVendorType.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.SystemColors.Control;
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
            this.splitContainer4.Size = new System.Drawing.Size(1068, 565);
            this.splitContainer4.SplitterDistance = 427;
            this.splitContainer4.SplitterWidth = 6;
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
            this.GR1Vendortype.Size = new System.Drawing.Size(427, 565);
            this.GR1Vendortype.TabIndex = 1;
            this.GR1Vendortype.TabStop = false;
            this.GR1Vendortype.Text = "Data Entry";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblVendortypeID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVendortypeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVendortypeID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVendortypeName, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 531);
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
            this.lblVendortypeID.Size = new System.Drawing.Size(151, 23);
            this.lblVendortypeID.TabIndex = 0;
            this.lblVendortypeID.Text = "VendortypeID:";
            // 
            // lblVendortypeName
            // 
            this.lblVendortypeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendortypeName.AutoSize = true;
            this.lblVendortypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendortypeName.Location = new System.Drawing.Point(4, 50);
            this.lblVendortypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendortypeName.Name = "lblVendortypeName";
            this.lblVendortypeName.Size = new System.Drawing.Size(191, 23);
            this.lblVendortypeName.TabIndex = 1;
            this.lblVendortypeName.Text = "VendortypeName:";
            // 
            // txtVendortypeID
            // 
            this.txtVendortypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendortypeID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendortypeID.Location = new System.Drawing.Point(203, 5);
            this.txtVendortypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVendortypeID.Name = "txtVendortypeID";
            this.txtVendortypeID.Size = new System.Drawing.Size(168, 31);
            this.txtVendortypeID.TabIndex = 2;
            // 
            // txtVendortypeName
            // 
            this.txtVendortypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendortypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendortypeName.Location = new System.Drawing.Point(203, 46);
            this.txtVendortypeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVendortypeName.Name = "txtVendortypeName";
            this.txtVendortypeName.Size = new System.Drawing.Size(168, 31);
            this.txtVendortypeName.TabIndex = 3;
            // 
            // GR2Vendortype
            // 
            this.GR2Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR2Vendortype.Controls.Add(this.DgvVendorType);
            this.GR2Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR2Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR2Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR2Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Name = "GR2Vendortype";
            this.GR2Vendortype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Size = new System.Drawing.Size(635, 565);
            this.GR2Vendortype.TabIndex = 1;
            this.GR2Vendortype.TabStop = false;
            this.GR2Vendortype.Text = "Data";
            // 
            // DgvVendorType
            // 
            this.DgvVendorType.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DgvVendorType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVendorType.Location = new System.Drawing.Point(4, 29);
            this.DgvVendorType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvVendorType.Name = "DgvVendorType";
            this.DgvVendorType.Size = new System.Drawing.Size(627, 531);
            this.DgvVendorType.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 703);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(327, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Shop Management System";
            // 
            // VenderTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1143, 703);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VenderTypes";
            this.Text = "VenderTypes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VenderTypes_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendorType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GR1Vendortype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVendortypeID;
        private System.Windows.Forms.Label lblVendortypeName;
        private System.Windows.Forms.TextBox txtVendortypeID;
        private System.Windows.Forms.TextBox txtVendortypeName;
        private System.Windows.Forms.GroupBox GR2Vendortype;
        private System.Windows.Forms.DataGridView DgvVendorType;
        private KWC.BCS.Controls.CrudControl crudVendorType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}