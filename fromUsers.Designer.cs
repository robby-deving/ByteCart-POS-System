namespace POS_System
{
    partial class fromUsers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.emailTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.nameTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(646, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // phoneTxt
            // 
            this.phoneTxt.AllowPromptAsInput = true;
            this.phoneTxt.AnimateReadOnly = false;
            this.phoneTxt.AsciiOnly = false;
            this.phoneTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.phoneTxt.BeepOnError = false;
            this.phoneTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.phoneTxt.Depth = 0;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneTxt.HidePromptOnLeave = false;
            this.phoneTxt.HideSelection = true;
            this.phoneTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.phoneTxt.LeadingIcon = null;
            this.phoneTxt.Location = new System.Drawing.Point(416, 94);
            this.phoneTxt.Mask = "";
            this.phoneTxt.MaxLength = 32767;
            this.phoneTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.PrefixSuffixText = null;
            this.phoneTxt.PromptChar = '_';
            this.phoneTxt.ReadOnly = false;
            this.phoneTxt.RejectInputOnFirstFailure = false;
            this.phoneTxt.ResetOnPrompt = true;
            this.phoneTxt.ResetOnSpace = true;
            this.phoneTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.SelectionLength = 0;
            this.phoneTxt.SelectionStart = 0;
            this.phoneTxt.ShortcutsEnabled = true;
            this.phoneTxt.Size = new System.Drawing.Size(180, 48);
            this.phoneTxt.SkipLiterals = true;
            this.phoneTxt.TabIndex = 14;
            this.phoneTxt.TabStop = false;
            this.phoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.phoneTxt.TrailingIcon = null;
            this.phoneTxt.UseSystemPasswordChar = false;
            this.phoneTxt.ValidatingType = null;
            // 
            // emailTxt
            // 
            this.emailTxt.AllowPromptAsInput = true;
            this.emailTxt.AnimateReadOnly = false;
            this.emailTxt.AsciiOnly = false;
            this.emailTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTxt.BeepOnError = false;
            this.emailTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.emailTxt.Depth = 0;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailTxt.HidePromptOnLeave = false;
            this.emailTxt.HideSelection = true;
            this.emailTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.emailTxt.LeadingIcon = null;
            this.emailTxt.Location = new System.Drawing.Point(210, 94);
            this.emailTxt.Mask = "";
            this.emailTxt.MaxLength = 32767;
            this.emailTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PrefixSuffixText = null;
            this.emailTxt.PromptChar = '_';
            this.emailTxt.ReadOnly = false;
            this.emailTxt.RejectInputOnFirstFailure = false;
            this.emailTxt.ResetOnPrompt = true;
            this.emailTxt.ResetOnSpace = true;
            this.emailTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTxt.SelectedText = "";
            this.emailTxt.SelectionLength = 0;
            this.emailTxt.SelectionStart = 0;
            this.emailTxt.ShortcutsEnabled = true;
            this.emailTxt.Size = new System.Drawing.Size(155, 48);
            this.emailTxt.SkipLiterals = true;
            this.emailTxt.TabIndex = 13;
            this.emailTxt.TabStop = false;
            this.emailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.emailTxt.TrailingIcon = null;
            this.emailTxt.UseSystemPasswordChar = false;
            this.emailTxt.ValidatingType = null;
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
            this.nameTxt.Location = new System.Drawing.Point(25, 94);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 180);
            this.dataGridView1.TabIndex = 28;
            // 
            // fromUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fromUsers";
            this.Text = "fromUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox phoneTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox emailTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox nameTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}