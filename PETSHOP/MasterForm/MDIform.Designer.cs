namespace PETSHOP
{
    partial class MDIform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIform));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FormVT = new System.Windows.Forms.ToolStripMenuItem();
            this.FormV = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(948, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormVT,
            this.FormV,
            this.saveToolStripMenuItem,
            this.subCategoryToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.modesToolStripMenuItem,
            this.companyToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(119, 32);
            this.fileMenu.Text = "Masters";
            // 
            // FormVT
            // 
            this.FormVT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormVT.ImageTransparentColor = System.Drawing.Color.Black;
            this.FormVT.Name = "FormVT";
            this.FormVT.Size = new System.Drawing.Size(214, 32);
            this.FormVT.Text = "VendorTypes";
            this.FormVT.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // FormV
            // 
            this.FormV.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormV.Image = ((System.Drawing.Image)(resources.GetObject("FormV.Image")));
            this.FormV.ImageTransparentColor = System.Drawing.Color.Black;
            this.FormV.Name = "FormV";
            this.FormV.Size = new System.Drawing.Size(214, 32);
            this.FormV.Text = "Vendors";
            this.FormV.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.saveToolStripMenuItem.Text = "Category";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.subCategoryToolStripMenuItem.Text = "SubCategory";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.saveAsToolStripMenuItem.Text = "Product";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statusToolStripMenuItem.Image")));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modesToolStripMenuItem.Image")));
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.modesToolStripMenuItem.Text = "Modes";
            this.modesToolStripMenuItem.Click += new System.EventHandler(this.modesToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.Image = ((System.Drawing.Image)(resources.GetObject("editMenu.Image")));
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(150, 32);
            this.editMenu.Text = "Transaction";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.undoToolStripMenuItem.Text = "Orders";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem,
            this.productToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.orderDetailsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.viewMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenu.Image = ((System.Drawing.Image)(resources.GetObject("viewMenu.Image")));
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(118, 32);
            this.viewMenu.Text = "Reports";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notePadToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.userToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolsMenu.Image")));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(116, 32);
            this.toolsMenu.Text = "Utilities";
            // 
            // notePadToolStripMenuItem
            // 
            this.notePadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notePadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notePadToolStripMenuItem.Image")));
            this.notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            this.notePadToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.notePadToolStripMenuItem.Text = "Note Pad";
            this.notePadToolStripMenuItem.Click += new System.EventHandler(this.notePadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorToolStripMenuItem.Image")));
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // MDIform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIform";
            this.Text = "MDIform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIform_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem FormVT;
        private System.Windows.Forms.ToolStripMenuItem FormV;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
    }
}



