namespace POS_System
{
    partial class formCreateOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitTransaction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.listCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAmountGiven = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.Label();
            this.cusIdTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Order";
            // 
            // btnSubmitTransaction
            // 
            this.btnSubmitTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnSubmitTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTransaction.ForeColor = System.Drawing.Color.White;
            this.btnSubmitTransaction.Location = new System.Drawing.Point(519, 390);
            this.btnSubmitTransaction.Name = "btnSubmitTransaction";
            this.btnSubmitTransaction.Size = new System.Drawing.Size(122, 48);
            this.btnSubmitTransaction.TabIndex = 20;
            this.btnSubmitTransaction.Text = "Save";
            this.btnSubmitTransaction.UseVisualStyleBackColor = false;
            this.btnSubmitTransaction.Click += new System.EventHandler(this.btnSubmitTransaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // flowProducts
            // 
            this.flowProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowProducts.Location = new System.Drawing.Point(0, 0);
            this.flowProducts.Margin = new System.Windows.Forms.Padding(2);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(375, 450);
            this.flowProducts.TabIndex = 31;
            // 
            // listCart
            // 
            this.listCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.listCart.FormattingEnabled = true;
            this.listCart.Location = new System.Drawing.Point(421, 0);
            this.listCart.Margin = new System.Windows.Forms.Padding(2);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(312, 450);
            this.listCart.TabIndex = 32;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(474, 265);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total";
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.Location = new System.Drawing.Point(586, 285);
            this.txtAmountGiven.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(76, 20);
            this.txtAmountGiven.TabIndex = 34;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(586, 305);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(76, 20);
            this.txtDiscount.TabIndex = 35;
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Location = new System.Drawing.Point(564, 365);
            this.lblFinalTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(0, 13);
            this.lblFinalTotal.TabIndex = 36;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(748, 351);
            this.lblChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 13);
            this.lblChange.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "SubTotal";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(583, 338);
            this.subTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(28, 17);
            this.subTotal.TabIndex = 41;
            this.subTotal.Text = "     ";
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.Location = new System.Drawing.Point(474, 365);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(125, 13);
            this.customerId.TabIndex = 42;
            this.customerId.Text = "Customer Loyalty number";
            // 
            // cusIdTxt
            // 
            this.cusIdTxt.Location = new System.Drawing.Point(605, 365);
            this.cusIdTxt.Name = "cusIdTxt";
            this.cusIdTxt.Size = new System.Drawing.Size(100, 20);
            this.cusIdTxt.TabIndex = 43;
            // 
            // formCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.cusIdTxt);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtAmountGiven);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSubmitTransaction);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.flowProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCreateOrder";
            this.Text = "formCreateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.ListBox listCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label customerId;
        private System.Windows.Forms.TextBox cusId;
        private System.Windows.Forms.TextBox cusIdTxt;
    }
}