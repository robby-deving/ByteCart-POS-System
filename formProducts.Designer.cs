namespace POS_System
{
    partial class formProducts
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.priceTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.nameTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exportBtn = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(160, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(617, 92);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 48);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Submit";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
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
            this.quantityTxt.Location = new System.Drawing.Point(385, 92);
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
            this.quantityTxt.Size = new System.Drawing.Size(155, 48);
            this.quantityTxt.SkipLiterals = true;
            this.quantityTxt.TabIndex = 13;
            this.quantityTxt.TabStop = false;
            this.quantityTxt.Text = " ";
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantityTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.quantityTxt.TrailingIcon = null;
            this.quantityTxt.UseSystemPasswordChar = false;
            this.quantityTxt.ValidatingType = null;
            // 
            // priceTxt
            // 
            this.priceTxt.AllowPromptAsInput = true;
            this.priceTxt.AnimateReadOnly = false;
            this.priceTxt.AsciiOnly = false;
            this.priceTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priceTxt.BeepOnError = false;
            this.priceTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.priceTxt.Depth = 0;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceTxt.HidePromptOnLeave = false;
            this.priceTxt.HideSelection = true;
            this.priceTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.priceTxt.LeadingIcon = null;
            this.priceTxt.Location = new System.Drawing.Point(215, 92);
            this.priceTxt.Mask = "";
            this.priceTxt.MaxLength = 32767;
            this.priceTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.PasswordChar = '\0';
            this.priceTxt.PrefixSuffixText = null;
            this.priceTxt.PromptChar = '_';
            this.priceTxt.ReadOnly = false;
            this.priceTxt.RejectInputOnFirstFailure = false;
            this.priceTxt.ResetOnPrompt = true;
            this.priceTxt.ResetOnSpace = true;
            this.priceTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceTxt.SelectedText = "";
            this.priceTxt.SelectionLength = 0;
            this.priceTxt.SelectionStart = 0;
            this.priceTxt.ShortcutsEnabled = true;
            this.priceTxt.Size = new System.Drawing.Size(140, 48);
            this.priceTxt.SkipLiterals = true;
            this.priceTxt.TabIndex = 12;
            this.priceTxt.TabStop = false;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.priceTxt.TrailingIcon = null;
            this.priceTxt.UseSystemPasswordChar = false;
            this.priceTxt.ValidatingType = null;
            // 
            // nameTxt
            // 
            this.nameTxt.AllowPromptAsInput = true;
            this.nameTxt.AnimateReadOnly = false;
            this.nameTxt.AsciiOnly = false;
            this.nameTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameTxt.BeepOnError = false;
            this.nameTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nameTxt.Depth = 0;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTxt.HidePromptOnLeave = false;
            this.nameTxt.HideSelection = true;
            this.nameTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.nameTxt.LeadingIcon = null;
            this.nameTxt.Location = new System.Drawing.Point(19, 92);
            this.nameTxt.Mask = "";
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PrefixSuffixText = null;
            this.nameTxt.PromptChar = '_';
            this.nameTxt.ReadOnly = false;
            this.nameTxt.RejectInputOnFirstFailure = false;
            this.nameTxt.ResetOnPrompt = true;
            this.nameTxt.ResetOnSpace = true;
            this.nameTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(143, 48);
            this.nameTxt.SkipLiterals = true;
            this.nameTxt.TabIndex = 11;
            this.nameTxt.TabStop = false;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nameTxt.TrailingIcon = null;
            this.nameTxt.UseSystemPasswordChar = false;
            this.nameTxt.ValidatingType = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 191);
            this.dataGridView1.TabIndex = 20;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(644, 181);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(95, 26);
            this.exportBtn.TabIndex = 21;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // formProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProducts";
            this.Text = "formProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox quantityTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox priceTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox nameTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exportBtn;
    }
}