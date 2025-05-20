namespace POS_System
{
    partial class formDiscounts
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mniAmountTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.discountValueTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.discountTypeTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.nameTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sdate = new System.Windows.Forms.DateTimePicker();
            this.edate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discounts";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(795, 217);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(240, 59);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Submit";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(789, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Minimum Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Discount Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Discount Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // mniAmountTxt
            // 
            this.mniAmountTxt.AllowPromptAsInput = true;
            this.mniAmountTxt.AnimateReadOnly = false;
            this.mniAmountTxt.AsciiOnly = false;
            this.mniAmountTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mniAmountTxt.BeepOnError = false;
            this.mniAmountTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mniAmountTxt.Depth = 0;
            this.mniAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mniAmountTxt.HidePromptOnLeave = false;
            this.mniAmountTxt.HideSelection = true;
            this.mniAmountTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mniAmountTxt.LeadingIcon = null;
            this.mniAmountTxt.Location = new System.Drawing.Point(795, 105);
            this.mniAmountTxt.Margin = new System.Windows.Forms.Padding(4);
            this.mniAmountTxt.Mask = "";
            this.mniAmountTxt.MaxLength = 32767;
            this.mniAmountTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mniAmountTxt.Name = "mniAmountTxt";
            this.mniAmountTxt.PasswordChar = '\0';
            this.mniAmountTxt.PrefixSuffixText = null;
            this.mniAmountTxt.PromptChar = '_';
            this.mniAmountTxt.ReadOnly = false;
            this.mniAmountTxt.RejectInputOnFirstFailure = false;
            this.mniAmountTxt.ResetOnPrompt = true;
            this.mniAmountTxt.ResetOnSpace = true;
            this.mniAmountTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mniAmountTxt.SelectedText = "";
            this.mniAmountTxt.SelectionLength = 0;
            this.mniAmountTxt.SelectionStart = 0;
            this.mniAmountTxt.ShortcutsEnabled = true;
            this.mniAmountTxt.Size = new System.Drawing.Size(240, 48);
            this.mniAmountTxt.SkipLiterals = true;
            this.mniAmountTxt.TabIndex = 14;
            this.mniAmountTxt.TabStop = false;
            this.mniAmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mniAmountTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mniAmountTxt.TrailingIcon = null;
            this.mniAmountTxt.UseSystemPasswordChar = false;
            this.mniAmountTxt.ValidatingType = null;
            // 
            // discountValueTxt
            // 
            this.discountValueTxt.AllowPromptAsInput = true;
            this.discountValueTxt.AnimateReadOnly = false;
            this.discountValueTxt.AsciiOnly = false;
            this.discountValueTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.discountValueTxt.BeepOnError = false;
            this.discountValueTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.discountValueTxt.Depth = 0;
            this.discountValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.discountValueTxt.HidePromptOnLeave = false;
            this.discountValueTxt.HideSelection = true;
            this.discountValueTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.discountValueTxt.LeadingIcon = null;
            this.discountValueTxt.Location = new System.Drawing.Point(520, 105);
            this.discountValueTxt.Margin = new System.Windows.Forms.Padding(4);
            this.discountValueTxt.Mask = "";
            this.discountValueTxt.MaxLength = 32767;
            this.discountValueTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.discountValueTxt.Name = "discountValueTxt";
            this.discountValueTxt.PasswordChar = '\0';
            this.discountValueTxt.PrefixSuffixText = null;
            this.discountValueTxt.PromptChar = '_';
            this.discountValueTxt.ReadOnly = false;
            this.discountValueTxt.RejectInputOnFirstFailure = false;
            this.discountValueTxt.ResetOnPrompt = true;
            this.discountValueTxt.ResetOnSpace = true;
            this.discountValueTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discountValueTxt.SelectedText = "";
            this.discountValueTxt.SelectionLength = 0;
            this.discountValueTxt.SelectionStart = 0;
            this.discountValueTxt.ShortcutsEnabled = true;
            this.discountValueTxt.Size = new System.Drawing.Size(207, 48);
            this.discountValueTxt.SkipLiterals = true;
            this.discountValueTxt.TabIndex = 13;
            this.discountValueTxt.TabStop = false;
            this.discountValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.discountValueTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.discountValueTxt.TrailingIcon = null;
            this.discountValueTxt.UseSystemPasswordChar = false;
            this.discountValueTxt.ValidatingType = null;
            // 
            // discountTypeTxt
            // 
            this.discountTypeTxt.AllowPromptAsInput = true;
            this.discountTypeTxt.AnimateReadOnly = false;
            this.discountTypeTxt.AsciiOnly = false;
            this.discountTypeTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.discountTypeTxt.BeepOnError = false;
            this.discountTypeTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.discountTypeTxt.Depth = 0;
            this.discountTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.discountTypeTxt.HidePromptOnLeave = false;
            this.discountTypeTxt.HideSelection = true;
            this.discountTypeTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.discountTypeTxt.LeadingIcon = null;
            this.discountTypeTxt.Location = new System.Drawing.Point(293, 105);
            this.discountTypeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.discountTypeTxt.Mask = "";
            this.discountTypeTxt.MaxLength = 32767;
            this.discountTypeTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.discountTypeTxt.Name = "discountTypeTxt";
            this.discountTypeTxt.PasswordChar = '\0';
            this.discountTypeTxt.PrefixSuffixText = null;
            this.discountTypeTxt.PromptChar = '_';
            this.discountTypeTxt.ReadOnly = false;
            this.discountTypeTxt.RejectInputOnFirstFailure = false;
            this.discountTypeTxt.ResetOnPrompt = true;
            this.discountTypeTxt.ResetOnSpace = true;
            this.discountTypeTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discountTypeTxt.SelectedText = "";
            this.discountTypeTxt.SelectionLength = 0;
            this.discountTypeTxt.SelectionStart = 0;
            this.discountTypeTxt.ShortcutsEnabled = true;
            this.discountTypeTxt.Size = new System.Drawing.Size(187, 48);
            this.discountTypeTxt.SkipLiterals = true;
            this.discountTypeTxt.TabIndex = 12;
            this.discountTypeTxt.TabStop = false;
            this.discountTypeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.discountTypeTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.discountTypeTxt.TrailingIcon = null;
            this.discountTypeTxt.UseSystemPasswordChar = false;
            this.discountTypeTxt.ValidatingType = null;
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
            this.nameTxt.Location = new System.Drawing.Point(32, 105);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
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
            this.nameTxt.Size = new System.Drawing.Size(191, 48);
            this.nameTxt.SkipLiterals = true;
            this.nameTxt.TabIndex = 11;
            this.nameTxt.TabStop = false;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nameTxt.TrailingIcon = null;
            this.nameTxt.UseSystemPasswordChar = false;
            this.nameTxt.ValidatingType = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Start Date";
            // 
            // sdate
            // 
            this.sdate.Location = new System.Drawing.Point(32, 205);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(191, 22);
            this.sdate.TabIndex = 24;
            // 
            // edate
            // 
            this.edate.Location = new System.Drawing.Point(311, 205);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(191, 22);
            this.edate.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(999, 222);
            this.dataGridView1.TabIndex = 26;
            // 
            // formDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mniAmountTxt);
            this.Controls.Add(this.discountValueTxt);
            this.Controls.Add(this.discountTypeTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDiscounts";
            this.Text = "formDiscounts";
            this.Load += new System.EventHandler(this.formDiscounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mniAmountTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox discountValueTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox discountTypeTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox nameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker sdate;
        private System.Windows.Forms.DateTimePicker edate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}