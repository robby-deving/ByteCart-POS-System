namespace POS_System
{
    partial class formLoyaltyPrograms
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.nameTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loyalty Programs";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(634, 141);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 56);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Submit";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.AllowPromptAsInput = true;
            this.descriptionTxt.AnimateReadOnly = false;
            this.descriptionTxt.AsciiOnly = false;
            this.descriptionTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.descriptionTxt.BeepOnError = false;
            this.descriptionTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.descriptionTxt.Depth = 0;
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionTxt.HidePromptOnLeave = false;
            this.descriptionTxt.HideSelection = true;
            this.descriptionTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.descriptionTxt.LeadingIcon = null;
            this.descriptionTxt.Location = new System.Drawing.Point(218, 87);
            this.descriptionTxt.Mask = "";
            this.descriptionTxt.MaxLength = 32767;
            this.descriptionTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.PasswordChar = '\0';
            this.descriptionTxt.PrefixSuffixText = null;
            this.descriptionTxt.PromptChar = '_';
            this.descriptionTxt.ReadOnly = false;
            this.descriptionTxt.RejectInputOnFirstFailure = false;
            this.descriptionTxt.ResetOnPrompt = true;
            this.descriptionTxt.ResetOnSpace = true;
            this.descriptionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionTxt.SelectedText = "";
            this.descriptionTxt.SelectionLength = 0;
            this.descriptionTxt.SelectionStart = 0;
            this.descriptionTxt.ShortcutsEnabled = true;
            this.descriptionTxt.Size = new System.Drawing.Size(538, 48);
            this.descriptionTxt.SkipLiterals = true;
            this.descriptionTxt.TabIndex = 12;
            this.descriptionTxt.TabStop = false;
            this.descriptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descriptionTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.descriptionTxt.TrailingIcon = null;
            this.descriptionTxt.UseSystemPasswordChar = false;
            this.descriptionTxt.ValidatingType = null;
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
            this.nameTxt.Location = new System.Drawing.Point(22, 87);
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 153);
            this.dataGridView1.TabIndex = 20;
            // 
            // formLoyaltyPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLoyaltyPrograms";
            this.Text = "formLoyaltyPrograms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox descriptionTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox nameTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}