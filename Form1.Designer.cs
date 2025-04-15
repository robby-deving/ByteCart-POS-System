namespace POS_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productPan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.createorderPan = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dashPan = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.inventoryPan = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.employeePan = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.userPan = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.discountPan = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.lpPan = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.logoutPan = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.productPan.SuspendLayout();
            this.createorderPan.SuspendLayout();
            this.dashPan.SuspendLayout();
            this.inventoryPan.SuspendLayout();
            this.employeePan.SuspendLayout();
            this.userPan.SuspendLayout();
            this.discountPan.SuspendLayout();
            this.lpPan.SuspendLayout();
            this.logoutPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 35);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(682, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " ByteCart POS System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Controls.Add(this.dashPan);
            this.flowLayoutPanel1.Controls.Add(this.createorderPan);
            this.flowLayoutPanel1.Controls.Add(this.productPan);
            this.flowLayoutPanel1.Controls.Add(this.inventoryPan);
            this.flowLayoutPanel1.Controls.Add(this.employeePan);
            this.flowLayoutPanel1.Controls.Add(this.userPan);
            this.flowLayoutPanel1.Controls.Add(this.discountPan);
            this.flowLayoutPanel1.Controls.Add(this.lpPan);
            this.flowLayoutPanel1.Controls.Add(this.logoutPan);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 498);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // productPan
            // 
            this.productPan.Controls.Add(this.button3);
            this.productPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPan.Location = new System.Drawing.Point(3, 97);
            this.productPan.Name = "productPan";
            this.productPan.Size = new System.Drawing.Size(171, 41);
            this.productPan.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-9, -27);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(187, 98);
            this.button3.TabIndex = 2;
            this.button3.Text = "   Products";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // createorderPan
            // 
            this.createorderPan.Controls.Add(this.button1);
            this.createorderPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createorderPan.Location = new System.Drawing.Point(3, 50);
            this.createorderPan.Name = "createorderPan";
            this.createorderPan.Size = new System.Drawing.Size(171, 41);
            this.createorderPan.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-9, -27);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(187, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Create Order";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dashPan
            // 
            this.dashPan.Controls.Add(this.button2);
            this.dashPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashPan.Location = new System.Drawing.Point(3, 3);
            this.dashPan.Name = "dashPan";
            this.dashPan.Size = new System.Drawing.Size(171, 41);
            this.dashPan.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-9, -27);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(187, 98);
            this.button2.TabIndex = 2;
            this.button2.Text = "   Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // inventoryPan
            // 
            this.inventoryPan.Controls.Add(this.button4);
            this.inventoryPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryPan.Location = new System.Drawing.Point(3, 144);
            this.inventoryPan.Name = "inventoryPan";
            this.inventoryPan.Size = new System.Drawing.Size(171, 41);
            this.inventoryPan.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-9, -27);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(187, 98);
            this.button4.TabIndex = 2;
            this.button4.Text = "   Inventories";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // employeePan
            // 
            this.employeePan.Controls.Add(this.button5);
            this.employeePan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePan.Location = new System.Drawing.Point(3, 191);
            this.employeePan.Name = "employeePan";
            this.employeePan.Size = new System.Drawing.Size(171, 41);
            this.employeePan.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-9, -27);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(187, 98);
            this.button5.TabIndex = 2;
            this.button5.Text = "   Employees";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // userPan
            // 
            this.userPan.Controls.Add(this.button6);
            this.userPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPan.Location = new System.Drawing.Point(3, 238);
            this.userPan.Name = "userPan";
            this.userPan.Size = new System.Drawing.Size(171, 41);
            this.userPan.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-9, -27);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(187, 98);
            this.button6.TabIndex = 2;
            this.button6.Text = "   Users";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // discountPan
            // 
            this.discountPan.Controls.Add(this.button7);
            this.discountPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPan.Location = new System.Drawing.Point(3, 285);
            this.discountPan.Name = "discountPan";
            this.discountPan.Size = new System.Drawing.Size(171, 41);
            this.discountPan.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-9, -27);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(187, 98);
            this.button7.TabIndex = 2;
            this.button7.Text = "   Discounts";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lpPan
            // 
            this.lpPan.Controls.Add(this.button8);
            this.lpPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpPan.Location = new System.Drawing.Point(3, 332);
            this.lpPan.Name = "lpPan";
            this.lpPan.Size = new System.Drawing.Size(171, 41);
            this.lpPan.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-9, -27);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(187, 98);
            this.button8.TabIndex = 2;
            this.button8.Text = "   Loyalty Programs";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // logoutPan
            // 
            this.logoutPan.Controls.Add(this.button9);
            this.logoutPan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutPan.Location = new System.Drawing.Point(3, 379);
            this.logoutPan.Name = "logoutPan";
            this.logoutPan.Size = new System.Drawing.Size(171, 41);
            this.logoutPan.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-9, -27);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(187, 98);
            this.button9.TabIndex = 2;
            this.button9.Text = "   Logout";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 533);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.productPan.ResumeLayout(false);
            this.createorderPan.ResumeLayout(false);
            this.dashPan.ResumeLayout(false);
            this.inventoryPan.ResumeLayout(false);
            this.employeePan.ResumeLayout(false);
            this.userPan.ResumeLayout(false);
            this.discountPan.ResumeLayout(false);
            this.lpPan.ResumeLayout(false);
            this.logoutPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel productPan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel createorderPan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel dashPan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel inventoryPan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel employeePan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel userPan;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel discountPan;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel lpPan;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel logoutPan;
        private System.Windows.Forms.Button button9;
    }
}

