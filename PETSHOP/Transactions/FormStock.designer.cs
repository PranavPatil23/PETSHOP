namespace PETSHOP.Transactions
{
    partial class FormStock
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCurrentStock = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentStock)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.SplitContainer1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.Panel1.Size = new System.Drawing.Size(772, 474);
            this.Panel1.TabIndex = 5;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer1.Location = new System.Drawing.Point(10, 10);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.FlowLayoutPanel1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(752, 454);
            this.SplitContainer1.SplitterWidth = 10;
            this.SplitContainer1.TabIndex = 0;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.FlowLayoutPanel1.Controls.Add(this.Label7);
            this.FlowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(752, 50);
            this.FlowLayoutPanel1.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.Yellow;
            this.Label7.Location = new System.Drawing.Point(3, 15);
            this.Label7.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Label7.Size = new System.Drawing.Size(251, 20);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Update Material / Product Stock : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(260, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.GroupBox2);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer2.Size = new System.Drawing.Size(752, 394);
            this.SplitContainer2.SplitterDistance = 349;
            this.SplitContainer2.SplitterWidth = 20;
            this.SplitContainer2.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.dgvOrderDetails);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.ForeColor = System.Drawing.Color.Navy;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.GroupBox2.Size = new System.Drawing.Size(349, 394);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Order Details Material";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AllowUserToResizeRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(10, 39);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(329, 345);
            this.dgvOrderDetails.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dgvCurrentStock);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.GroupBox1.Size = new System.Drawing.Size(383, 394);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Material Current Stock";
            // 
            // dgvCurrentStock
            // 
            this.dgvCurrentStock.AllowUserToAddRows = false;
            this.dgvCurrentStock.AllowUserToDeleteRows = false;
            this.dgvCurrentStock.AllowUserToResizeRows = false;
            this.dgvCurrentStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentStock.Location = new System.Drawing.Point(15, 39);
            this.dgvCurrentStock.Name = "dgvCurrentStock";
            this.dgvCurrentStock.Size = new System.Drawing.Size(353, 340);
            this.dgvCurrentStock.TabIndex = 0;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 474);
            this.Controls.Add(this.Panel1);
            this.Name = "FormStock";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgvCurrentStock;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnUpdate;
    }
}