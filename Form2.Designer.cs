namespace BMP_EZBulkTool
{
    partial class Form2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_TotalOpen = new System.Windows.Forms.TextBox();
            this.TextBox_TotalReply = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_TotalResume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_TotalMeeting = new System.Windows.Forms.TextBox();
            this.TextBox_TotalDeleted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_TotalNonQualified = new System.Windows.Forms.TextBox();
            this.TextBox_TotalIS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bulk Stats for";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 7);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 11, 3, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOTAL OPEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL REPLY";
            // 
            // TextBox_TotalOpen
            // 
            this.TextBox_TotalOpen.Location = new System.Drawing.Point(123, 38);
            this.TextBox_TotalOpen.Name = "TextBox_TotalOpen";
            this.TextBox_TotalOpen.ReadOnly = true;
            this.TextBox_TotalOpen.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalOpen.TabIndex = 7;
            this.TextBox_TotalOpen.Text = "0";
            // 
            // TextBox_TotalReply
            // 
            this.TextBox_TotalReply.Location = new System.Drawing.Point(123, 64);
            this.TextBox_TotalReply.Name = "TextBox_TotalReply";
            this.TextBox_TotalReply.ReadOnly = true;
            this.TextBox_TotalReply.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalReply.TabIndex = 8;
            this.TextBox_TotalReply.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "TOTAL RESUME";
            // 
            // TextBox_TotalResume
            // 
            this.TextBox_TotalResume.Location = new System.Drawing.Point(123, 103);
            this.TextBox_TotalResume.Name = "TextBox_TotalResume";
            this.TextBox_TotalResume.ReadOnly = true;
            this.TextBox_TotalResume.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalResume.TabIndex = 8;
            this.TextBox_TotalResume.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "TOTAL MEETING";
            // 
            // TextBox_TotalMeeting
            // 
            this.TextBox_TotalMeeting.Location = new System.Drawing.Point(123, 129);
            this.TextBox_TotalMeeting.Name = "TextBox_TotalMeeting";
            this.TextBox_TotalMeeting.ReadOnly = true;
            this.TextBox_TotalMeeting.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalMeeting.TabIndex = 8;
            this.TextBox_TotalMeeting.Text = "0";
            // 
            // TextBox_TotalDeleted
            // 
            this.TextBox_TotalDeleted.Location = new System.Drawing.Point(123, 175);
            this.TextBox_TotalDeleted.Name = "TextBox_TotalDeleted";
            this.TextBox_TotalDeleted.ReadOnly = true;
            this.TextBox_TotalDeleted.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalDeleted.TabIndex = 8;
            this.TextBox_TotalDeleted.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(29, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL DELETED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(4, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "TOTAL NonQualified";
            // 
            // TextBox_TotalNonQualified
            // 
            this.TextBox_TotalNonQualified.Location = new System.Drawing.Point(123, 204);
            this.TextBox_TotalNonQualified.Name = "TextBox_TotalNonQualified";
            this.TextBox_TotalNonQualified.ReadOnly = true;
            this.TextBox_TotalNonQualified.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalNonQualified.TabIndex = 8;
            this.TextBox_TotalNonQualified.Text = "0";
            // 
            // TextBox_TotalIS
            // 
            this.TextBox_TotalIS.Location = new System.Drawing.Point(123, 233);
            this.TextBox_TotalIS.Name = "TextBox_TotalIS";
            this.TextBox_TotalIS.ReadOnly = true;
            this.TextBox_TotalIS.Size = new System.Drawing.Size(50, 23);
            this.TextBox_TotalIS.TabIndex = 8;
            this.TextBox_TotalIS.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "TOTAL IS( < 6 M)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBox_TotalIS);
            this.Controls.Add(this.TextBox_TotalNonQualified);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_TotalDeleted);
            this.Controls.Add(this.TextBox_TotalMeeting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_TotalResume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_TotalReply);
            this.Controls.Add(this.TextBox_TotalOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form2";
            this.Text = "Bulk Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_TotalOpen;
        private System.Windows.Forms.TextBox TextBox_TotalReply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_TotalResume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_TotalMeeting;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.TextBox TextBox_TotalIS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox_TotalDeleted;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox TextBox_TotalNonQualified;
    }
}