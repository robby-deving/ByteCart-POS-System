namespace POS_System
{
    partial class formInventory
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
            this.productTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.quantityTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventories";
            // 
            // productTxt
            // 
            this.productTxt.AllowPromptAsInput = true;
            this.productTxt.AnimateReadOnly = false;
            this.productTxt.AsciiOnly = false;
            this.productTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productTxt.BeepOnError = false;
            this.productTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.productTxt.Depth = 0;
            this.productTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productTxt.HidePromptOnLeave = false;
            this.productTxt.HideSelection = true;
            this.productTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.productTxt.LeadingIcon = null;
            this.productTxt.Location = new System.Drawing.Point(21, 92);
            this.productTxt.Mask = "";
            this.productTxt.MaxLength = 32767;
            this.productTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.productTxt.Name = "productTxt";
            this.productTxt.PasswordChar = '\0';
            this.productTxt.PrefixSuffixText = null;
            this.productTxt.PromptChar = '_';
            this.productTxt.ReadOnly = false;
            this.productTxt.RejectInputOnFirstFailure = false;
            this.productTxt.ResetOnPrompt = true;
            this.productTxt.ResetOnSpace = true;
            this.productTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productTxt.SelectedText = "";
            this.productTxt.SelectionLength = 0;
            this.productTxt.SelectionStart = 0;
            this.productTxt.ShortcutsEnabled = true;
            this.productTxt.Size = new System.Drawing.Size(143, 48);
            this.productTxt.SkipLiterals = true;
            this.productTxt.TabIndex = 11;
            this.productTxt.TabStop = false;
            this.productTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.productTxt.TrailingIcon = null;
            this.productTxt.UseSystemPasswordChar = false;
            this.productTxt.ValidatingType = null;
            // 
            // quantityTxt
            // 
            this.quantityTxt.AllowPromptAsInput = true;
            this.quantityTxt.AnimateReadOnly = false;
            this.quantityTxt.AsciiOnly = false;
            this.quantityTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quantityTxt.BeepOnError = false;
            this.quantityTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.quantityTxt.Depth = 0;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.quantityTxt.HidePromptOnLeave = false;
            this.quantityTxt.HideSelection = true;
            this.quantityTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.quantityTxt.LeadingIcon = null;
            this.quantityTxt.Location = new System.Drawing.Point(217, 92);
            this.quantityTxt.Mask = "";
            this.quantityTxt.MaxLength = 32767;
            this.quantityTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.PasswordChar = '\0';
            this.quantityTxt.PrefixSuffixText = null;
            this.quantityTxt.PromptChar = '_';
            this.quantityTxt.ReadOnly = false;
            this.quantityTxt.RejectInputOnFirstFailure = false;
            this.quantityTxt.ResetOnPrompt = true;
            this.quantityTxt.ResetOnSpace = true;
            this.quantityTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityTxt.SelectedText = "";
            this.quantityTxt.SelectionLength = 0;
            this.quantityTxt.SelectionStart = 0;
            this.quantityTxt.ShortcutsEnabled = true;
            this.quantityTxt.Size = new System.Drawing.Size(140, 48);
            this.quantityTxt.SkipLiterals = true;
            this.quantityTxt.TabIndex = 12;
            this.quantityTxt.TabStop = false;
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantityTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.quantityTxt.TrailingIcon = null;
            this.quantityTxt.UseSystemPasswordChar = false;
            this.quantityTxt.ValidatingType = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(420, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 180);
            this.dataGridView1.TabIndex = 27;
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.productTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInventory";
            this.Text = "formInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox productTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox quantityTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}