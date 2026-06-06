namespace PETSHOP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtPAS = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btlogin);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUN);
            this.panel1.Controls.Add(this.txtPAS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 632);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
           
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // btClear
            // 
            this.btClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btClear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Blue;
            this.btClear.Location = new System.Drawing.Point(282, 414);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(96, 49);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btlogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.Color.Red;
            this.btlogin.Location = new System.Drawing.Point(125, 414);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(87, 49);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "Log In";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(360, 355);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(275, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN ";
           
            // 
            // txtUN
            // 
            this.txtUN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUN.Location = new System.Drawing.Point(246, 210);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(274, 26);
            this.txtUN.TabIndex = 3;
          
            // 
            // txtPAS
            // 
            this.txtPAS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPAS.Location = new System.Drawing.Point(246, 300);
            this.txtPAS.Name = "txtPAS";
            this.txtPAS.Size = new System.Drawing.Size(274, 26);
            this.txtPAS.TabIndex = 4;
            this.txtPAS.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1183, 632);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox txtPAS;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}