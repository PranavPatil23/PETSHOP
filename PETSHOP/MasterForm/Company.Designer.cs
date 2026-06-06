namespace PETSHOP.MasterForm
{
    partial class Company
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.crudCompany = new KWC.BCS.Controls.CrudControl();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GR1Vendortype = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVendortypeID = new System.Windows.Forms.Label();
            this.lblVendortypeName = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.GR2Vendortype = new System.Windows.Forms.GroupBox();
            this.DgvCompany = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 663);
            this.panel1.TabIndex = 4;
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(996, 663);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Size = new System.Drawing.Size(996, 590);
            this.splitContainer2.SplitterDistance = 533;
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
            this.splitContainer3.Panel1.Controls.Add(this.crudCompany);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(996, 533);
            this.splitContainer3.SplitterDistance = 61;
            this.splitContainer3.TabIndex = 0;
            // 
            // crudCompany
            // 
            this.crudCompany.BackColor = System.Drawing.Color.LightCyan;
            this.crudCompany.BindingSource = null;
            this.crudCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudCompany.Location = new System.Drawing.Point(0, 0);
            this.crudCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crudCompany.Name = "crudCompany";
            this.crudCompany.PrimaryKeyTextBox = null;
            this.crudCompany.Size = new System.Drawing.Size(61, 533);
            this.crudCompany.TabIndex = 1;
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
            this.splitContainer4.Size = new System.Drawing.Size(931, 533);
            this.splitContainer4.SplitterDistance = 372;
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
            this.GR1Vendortype.Size = new System.Drawing.Size(372, 533);
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
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyName, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 499);
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
            this.lblVendortypeID.Size = new System.Drawing.Size(134, 23);
            this.lblVendortypeID.TabIndex = 0;
            this.lblVendortypeID.Text = "CompanyID:";
            // 
            // lblVendortypeName
            // 
            this.lblVendortypeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendortypeName.AutoSize = true;
            this.lblVendortypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendortypeName.Location = new System.Drawing.Point(4, 50);
            this.lblVendortypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendortypeName.Name = "lblVendortypeName";
            this.lblVendortypeName.Size = new System.Drawing.Size(174, 23);
            this.lblVendortypeName.TabIndex = 1;
            this.lblVendortypeName.Text = "CompanyName:";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(186, 5);
            this.txtCompanyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(168, 31);
            this.txtCompanyID.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(186, 46);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(168, 31);
            this.txtCompanyName.TabIndex = 3;
            // 
            // GR2Vendortype
            // 
            this.GR2Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR2Vendortype.Controls.Add(this.DgvCompany);
            this.GR2Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR2Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR2Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR2Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Name = "GR2Vendortype";
            this.GR2Vendortype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Size = new System.Drawing.Size(553, 533);
            this.GR2Vendortype.TabIndex = 1;
            this.GR2Vendortype.TabStop = false;
            this.GR2Vendortype.Text = "Data";
            // 
            // DgvCompany
            // 
            this.DgvCompany.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCompany.Location = new System.Drawing.Point(4, 29);
            this.DgvCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvCompany.Name = "DgvCompany";
            this.DgvCompany.Size = new System.Drawing.Size(545, 499);
            this.DgvCompany.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(390, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Company:";
            // 
            // Company
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(996, 663);
            this.Controls.Add(this.panel1);
            this.Name = "Company";
            this.Text = "Company";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Company_Load);
            this.panel1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private KWC.BCS.Controls.CrudControl crudCompany;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox GR1Vendortype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVendortypeID;
        private System.Windows.Forms.Label lblVendortypeName;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.GroupBox GR2Vendortype;
        private System.Windows.Forms.DataGridView DgvCompany;
        private System.Windows.Forms.Label label1;
    }
}