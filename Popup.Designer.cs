namespace BMP_EZBulkTool
{
    partial class Popup
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
            this.TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBox_DropDownSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Done = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_FirstName.Location = new System.Drawing.Point(12, 39);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.PlaceholderText = "First Name";
            this.TextBox_FirstName.Size = new System.Drawing.Size(219, 23);
            this.TextBox_FirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Email.Location = new System.Drawing.Point(12, 87);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.PlaceholderText = "Email@Example.com";
            this.TextBox_Email.Size = new System.Drawing.Size(219, 23);
            this.TextBox_Email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // ComboBox_DropDownSelect
            // 
            this.ComboBox_DropDownSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_DropDownSelect.FormattingEnabled = true;
            this.ComboBox_DropDownSelect.Items.AddRange(new object[] {
            "Resume",
            "Meeting",
            "BOTH"});
            this.ComboBox_DropDownSelect.Location = new System.Drawing.Point(110, 116);
            this.ComboBox_DropDownSelect.Name = "ComboBox_DropDownSelect";
            this.ComboBox_DropDownSelect.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_DropDownSelect.TabIndex = 5;
            this.ComboBox_DropDownSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter recipient data";
            // 
            // Button_Done
            // 
            this.Button_Done.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Done.Location = new System.Drawing.Point(13, 184);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(75, 23);
            this.Button_Done.TabIndex = 7;
            this.Button_Done.Text = "Done";
            this.Button_Done.UseVisualStyleBackColor = true;
            this.Button_Done.Click += new System.EventHandler(this.Button_Done_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(156, 184);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 8;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(243, 219);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Done);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox_DropDownSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_FirstName);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Popup";
            this.Text = "Popup";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox ComboBox_DropDownSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Done;
        private System.Windows.Forms.Button Button_Cancel;
    }
}