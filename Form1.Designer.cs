namespace BMP_EZBulkTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_Resume = new System.Windows.Forms.Button();
            this.Button_Meeting = new System.Windows.Forms.Button();
            this.Button_Deleted = new System.Windows.Forms.Button();
            this.Button_NonQualified = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_InSystem = new System.Windows.Forms.Button();
            this.TextBox_OPEN = new System.Windows.Forms.TextBox();
            this.TextBox_REPLY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_RESUME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_MEETING = new System.Windows.Forms.TextBox();
            this.TextBox_DELETED = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_NONQUALIFIED = new System.Windows.Forms.TextBox();
            this.TextBox_IS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_CopyToClipboard = new System.Windows.Forms.Button();
            this.Button_EditDone = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Label_ErrorText = new System.Windows.Forms.Label();
            this.CheckBox_MeetingBoost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Button_Resume
            // 
            this.Button_Resume.AutoSize = true;
            this.Button_Resume.Location = new System.Drawing.Point(12, 63);
            this.Button_Resume.Name = "Button_Resume";
            this.Button_Resume.Size = new System.Drawing.Size(100, 25);
            this.Button_Resume.TabIndex = 0;
            this.Button_Resume.Text = "Resume";
            this.Button_Resume.UseVisualStyleBackColor = true;
            this.Button_Resume.Click += new System.EventHandler(this.Button_Resume_Click);
            // 
            // Button_Meeting
            // 
            this.Button_Meeting.Location = new System.Drawing.Point(13, 95);
            this.Button_Meeting.Name = "Button_Meeting";
            this.Button_Meeting.Size = new System.Drawing.Size(100, 23);
            this.Button_Meeting.TabIndex = 1;
            this.Button_Meeting.Text = "Meeting";
            this.Button_Meeting.UseVisualStyleBackColor = true;
            this.Button_Meeting.Click += new System.EventHandler(this.Button_Meeting_Click);
            // 
            // Button_Deleted
            // 
            this.Button_Deleted.BackColor = System.Drawing.Color.Red;
            this.Button_Deleted.ForeColor = System.Drawing.Color.Black;
            this.Button_Deleted.Location = new System.Drawing.Point(12, 183);
            this.Button_Deleted.Name = "Button_Deleted";
            this.Button_Deleted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Deleted.Size = new System.Drawing.Size(100, 23);
            this.Button_Deleted.TabIndex = 2;
            this.Button_Deleted.Text = "Deleted";
            this.Button_Deleted.UseVisualStyleBackColor = false;
            this.Button_Deleted.Click += new System.EventHandler(this.Button_Deleted_Click);
            // 
            // Button_NonQualified
            // 
            this.Button_NonQualified.ForeColor = System.Drawing.Color.Red;
            this.Button_NonQualified.Location = new System.Drawing.Point(13, 125);
            this.Button_NonQualified.Name = "Button_NonQualified";
            this.Button_NonQualified.Size = new System.Drawing.Size(100, 23);
            this.Button_NonQualified.TabIndex = 3;
            this.Button_NonQualified.Text = "Not Qual";
            this.Button_NonQualified.UseVisualStyleBackColor = true;
            this.Button_NonQualified.Click += new System.EventHandler(this.Button_NonQualified_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(154, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "OPEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(153, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "REPLY";
            // 
            // Button_InSystem
            // 
            this.Button_InSystem.Location = new System.Drawing.Point(13, 154);
            this.Button_InSystem.Name = "Button_InSystem";
            this.Button_InSystem.Size = new System.Drawing.Size(100, 23);
            this.Button_InSystem.TabIndex = 6;
            this.Button_InSystem.Text = "In System (IS)";
            this.Button_InSystem.UseVisualStyleBackColor = true;
            this.Button_InSystem.Click += new System.EventHandler(this.Button_InSystem_Click);
            // 
            // TextBox_OPEN
            // 
            this.TextBox_OPEN.Location = new System.Drawing.Point(198, 60);
            this.TextBox_OPEN.Name = "TextBox_OPEN";
            this.TextBox_OPEN.ReadOnly = true;
            this.TextBox_OPEN.Size = new System.Drawing.Size(50, 23);
            this.TextBox_OPEN.TabIndex = 7;
            this.TextBox_OPEN.Text = "0";
            // 
            // TextBox_REPLY
            // 
            this.TextBox_REPLY.Location = new System.Drawing.Point(198, 86);
            this.TextBox_REPLY.Name = "TextBox_REPLY";
            this.TextBox_REPLY.ReadOnly = true;
            this.TextBox_REPLY.Size = new System.Drawing.Size(50, 23);
            this.TextBox_REPLY.TabIndex = 8;
            this.TextBox_REPLY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(141, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "RESUME";
            // 
            // TextBox_RESUME
            // 
            this.TextBox_RESUME.Location = new System.Drawing.Point(198, 125);
            this.TextBox_RESUME.Name = "TextBox_RESUME";
            this.TextBox_RESUME.ReadOnly = true;
            this.TextBox_RESUME.Size = new System.Drawing.Size(50, 23);
            this.TextBox_RESUME.TabIndex = 8;
            this.TextBox_RESUME.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(136, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "MEETING";
            // 
            // TextBox_MEETING
            // 
            this.TextBox_MEETING.Location = new System.Drawing.Point(198, 151);
            this.TextBox_MEETING.Name = "TextBox_MEETING";
            this.TextBox_MEETING.ReadOnly = true;
            this.TextBox_MEETING.Size = new System.Drawing.Size(50, 23);
            this.TextBox_MEETING.TabIndex = 8;
            this.TextBox_MEETING.Text = "0";
            // 
            // TextBox_DELETED
            // 
            this.TextBox_DELETED.Location = new System.Drawing.Point(198, 197);
            this.TextBox_DELETED.Name = "TextBox_DELETED";
            this.TextBox_DELETED.ReadOnly = true;
            this.TextBox_DELETED.Size = new System.Drawing.Size(50, 23);
            this.TextBox_DELETED.TabIndex = 8;
            this.TextBox_DELETED.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(139, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "DELETED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(114, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "NonQualified";
            // 
            // TextBox_NONQUALIFIED
            // 
            this.TextBox_NONQUALIFIED.Location = new System.Drawing.Point(198, 226);
            this.TextBox_NONQUALIFIED.Name = "TextBox_NONQUALIFIED";
            this.TextBox_NONQUALIFIED.ReadOnly = true;
            this.TextBox_NONQUALIFIED.Size = new System.Drawing.Size(50, 23);
            this.TextBox_NONQUALIFIED.TabIndex = 8;
            this.TextBox_NONQUALIFIED.Text = "0";
            // 
            // TextBox_IS
            // 
            this.TextBox_IS.Location = new System.Drawing.Point(198, 255);
            this.TextBox_IS.Name = "TextBox_IS";
            this.TextBox_IS.ReadOnly = true;
            this.TextBox_IS.Size = new System.Drawing.Size(50, 23);
            this.TextBox_IS.TabIndex = 8;
            this.TextBox_IS.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(95, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "IS( < 6 MONTHS)";
            // 
            // Button_CopyToClipboard
            // 
            this.Button_CopyToClipboard.Location = new System.Drawing.Point(125, 335);
            this.Button_CopyToClipboard.Name = "Button_CopyToClipboard";
            this.Button_CopyToClipboard.Size = new System.Drawing.Size(123, 23);
            this.Button_CopyToClipboard.TabIndex = 9;
            this.Button_CopyToClipboard.Text = "Copy to Clipboard";
            this.Button_CopyToClipboard.UseVisualStyleBackColor = true;
            this.Button_CopyToClipboard.Click += new System.EventHandler(this.Button_CopyToClipboard_Click);
            // 
            // Button_EditDone
            // 
            this.Button_EditDone.Location = new System.Drawing.Point(198, 31);
            this.Button_EditDone.Name = "Button_EditDone";
            this.Button_EditDone.Size = new System.Drawing.Size(50, 23);
            this.Button_EditDone.TabIndex = 10;
            this.Button_EditDone.Text = "Edit";
            this.Button_EditDone.UseVisualStyleBackColor = true;
            this.Button_EditDone.Click += new System.EventHandler(this.Button_EditDone_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(142, 31);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(50, 23);
            this.Button_Reset.TabIndex = 10;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Label_ErrorText
            // 
            this.Label_ErrorText.AutoSize = true;
            this.Label_ErrorText.Location = new System.Drawing.Point(12, 9);
            this.Label_ErrorText.Name = "Label_ErrorText";
            this.Label_ErrorText.Size = new System.Drawing.Size(226, 15);
            this.Label_ErrorText.TabIndex = 11;
            this.Label_ErrorText.Text = "ERROR: YOUR NUMBERS DO NOT MATCH";
            // 
            // CheckBox_MeetingBoost
            // 
            this.CheckBox_MeetingBoost.AutoSize = true;
            this.CheckBox_MeetingBoost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBox_MeetingBoost.Location = new System.Drawing.Point(13, 212);
            this.CheckBox_MeetingBoost.Name = "CheckBox_MeetingBoost";
            this.CheckBox_MeetingBoost.Size = new System.Drawing.Size(103, 19);
            this.CheckBox_MeetingBoost.TabIndex = 12;
            this.CheckBox_MeetingBoost.Text = "Meeting Boost";
            this.CheckBox_MeetingBoost.UseVisualStyleBackColor = true;
            this.CheckBox_MeetingBoost.CheckedChanged += new System.EventHandler(this.CheckBox_MeetingBoost_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(256, 364);
            this.Controls.Add(this.CheckBox_MeetingBoost);
            this.Controls.Add(this.Label_ErrorText);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_EditDone);
            this.Controls.Add(this.Button_CopyToClipboard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBox_IS);
            this.Controls.Add(this.TextBox_NONQUALIFIED);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_DELETED);
            this.Controls.Add(this.TextBox_MEETING);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_RESUME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_REPLY);
            this.Controls.Add(this.TextBox_OPEN);
            this.Controls.Add(this.Button_InSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_NonQualified);
            this.Controls.Add(this.Button_Deleted);
            this.Controls.Add(this.Button_Meeting);
            this.Controls.Add(this.Button_Resume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EZBulkTool By Alexander Moreno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Resume;
        private System.Windows.Forms.Button Button_Meeting;
        private System.Windows.Forms.Button Button_Deleted;
        private System.Windows.Forms.Button Button_NonQualified;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_InSystem;
        private System.Windows.Forms.TextBox TextBox_OPEN;
        private System.Windows.Forms.TextBox TextBox_REPLY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_RESUME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_MEETING;
        private System.Windows.Forms.TextBox TextBox_DELETED;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_NONQUALIFIED;
        private System.Windows.Forms.TextBox TextBox_IS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_CopyToClipboard;
        private System.Windows.Forms.Button Button_EditDone;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label Label_ErrorText;
        private System.Windows.Forms.CheckBox CheckBox_MeetingBoost;
    }
}

