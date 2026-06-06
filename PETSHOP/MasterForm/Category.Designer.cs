namespace PETSHOP
{
    partial class Category
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.crudCategory = new KWC.BCS.Controls.CrudControl();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GR1Vendortype = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.GR2Vendortype = new System.Windows.Forms.GroupBox();
            this.DgvCategory = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblCategory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1215, 641);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCategory.Location = new System.Drawing.Point(530, 15);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(154, 34);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
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
            this.splitContainer2.Size = new System.Drawing.Size(1215, 572);
            this.splitContainer2.SplitterDistance = 482;
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
            this.splitContainer3.Panel1.Controls.Add(this.crudCategory);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1215, 482);
            this.splitContainer3.SplitterDistance = 88;
            this.splitContainer3.TabIndex = 0;
            // 
            // crudCategory
            // 
            this.crudCategory.BackColor = System.Drawing.Color.LightCyan;
            this.crudCategory.BindingSource = null;
            this.crudCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudCategory.Location = new System.Drawing.Point(0, 0);
            this.crudCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crudCategory.Name = "crudCategory";
            this.crudCategory.PrimaryKeyTextBox = null;
            this.crudCategory.Size = new System.Drawing.Size(88, 482);
            this.crudCategory.TabIndex = 1;
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
            this.splitContainer4.Size = new System.Drawing.Size(1123, 482);
            this.splitContainer4.SplitterDistance = 478;
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
            this.GR1Vendortype.Size = new System.Drawing.Size(478, 482);
            this.GR1Vendortype.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.lblCategoryID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoryName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCategoryID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCategoryName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.Location = new System.Drawing.Point(44, 9);
            this.lblCategoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(128, 23);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "CategoryID:";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(4, 50);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(168, 23);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "CategoryName:";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCategoryID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.Location = new System.Drawing.Point(180, 5);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(258, 31);
            this.txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCategoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(180, 46);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(258, 31);
            this.txtCategoryName.TabIndex = 3;
            // 
            // GR2Vendortype
            // 
            this.GR2Vendortype.BackColor = System.Drawing.Color.Lavender;
            this.GR2Vendortype.Controls.Add(this.DgvCategory);
            this.GR2Vendortype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GR2Vendortype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR2Vendortype.Location = new System.Drawing.Point(0, 0);
            this.GR2Vendortype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GR2Vendortype.Name = "GR2Vendortype";
            this.GR2Vendortype.Padding = new System.Windows.Forms.Padding(8, 10, 8, 15);
            this.GR2Vendortype.Size = new System.Drawing.Size(641, 482);
            this.GR2Vendortype.TabIndex = 1;
            this.GR2Vendortype.TabStop = false;
            this.GR2Vendortype.Text = "Data";
            // 
            // DgvCategory
            // 
            this.DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCategory.Location = new System.Drawing.Point(8, 34);
            this.DgvCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvCategory.Name = "DgvCategory";
            this.DgvCategory.Size = new System.Drawing.Size(625, 433);
            this.DgvCategory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 641);
            this.panel1.TabIndex = 3;
            // 
            // Category
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1215, 641);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Category";
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Category_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label lblCategory;
        private KWC.BCS.Controls.CrudControl crudCategory;
        private System.Windows.Forms.GroupBox GR1Vendortype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.GroupBox GR2Vendortype;
        private System.Windows.Forms.DataGridView DgvCategory;
        private System.Windows.Forms.Panel panel1;
    }
}