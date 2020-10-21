using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMP_EZBulkTool
{
    public partial class Form1 : Form
    {
        private BulkStatsManager BSM;
        private MailingService MS;
        private bool EditMode;

        private bool MeetingBoost;
        
        public Form1()
        {
            InitializeComponent();
            BSM = new BulkStatsManager();
            MS = new MailingService();


            //this.Icon = new Icon("Resources/EZ.ico");

            EditMode = false;
            BSM.MeetingBoost = MeetingBoost = false;
            TextBox_OPEN.TextChanged += TextBox_OPEN_TextChanged;
            TextBox_REPLY.TextChanged += TextBox_REPLY_TextChanged;
            TextBox_RESUME.TextChanged += TextBox_RESUME_TextChanged;
            TextBox_MEETING.TextChanged += TextBox_MEETING_TextChanged;
            TextBox_DELETED.TextChanged += TextBox_DELETED_TextChanged;
            TextBox_NONQUALIFIED.TextChanged += TextBox_NONQUALIFIED_TextChanged;
            TextBox_IS.TextChanged += TextBox_IS_TextChanged;
            ListView_ContactExecList.View = View.Details;
        }


        private void TestValid()
        {
            uint NoReply = BSM.Deleted + BSM.NonQualified + BSM.InfusionSoft_InSystem;
            if (!MeetingBoost)
            {
                uint ReplyTotal = BSM.Resume + BSM.Meeting;

                



                Label_ErrorText.ForeColor = Color.FromArgb(Color.Red.ToArgb() * Convert.ToByte((BSM.Open + BSM.Reply - (ReplyTotal * 2) - NoReply) != 0));
                return;
            }
            else
            {
                uint ReplyTotal = (BSM.Resume + BSM.Meeting) / 2;
                Label_ErrorText.ForeColor = Color.FromArgb(Color.Red.ToArgb() * Convert.ToByte((BSM.Open + BSM.Reply - (ReplyTotal * 2) - NoReply) != 0));
            }
            

                
        }

        private void TextBoxChange(TextBox box,  Action<uint> action)
        {
            if (!box.ReadOnly && Regex.IsMatch(box.Text, "^[0-9]+$"))
            {

                action(uint.Parse(box.Text));
                TestValid();
                return;
            }

        }


        private void TextBox_OPEN_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.Open = value);
        }

        private void TextBox_REPLY_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.Reply = value);
        }

        private void TextBox_RESUME_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.Resume = value);
        }

        private void TextBox_MEETING_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.Meeting = value);
        }

        private void TextBox_DELETED_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.Deleted = value);
        }

        private void TextBox_NONQUALIFIED_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.NonQualified = value);
        }

        private void TextBox_IS_TextChanged(object sender, EventArgs e)
        {
            TextBoxChange(sender as TextBox, value => BSM.InfusionSoft_InSystem = value);
        }







        private void UpdateAllTextBoxes()
        {
            this.TextBox_OPEN.Text = BSM.Open.ToString();
            this.TextBox_REPLY.Text = BSM.Reply.ToString();
            this.TextBox_RESUME.Text = BSM.Resume.ToString();
            this.TextBox_MEETING.Text = BSM.Meeting.ToString();
            this.TextBox_DELETED.Text = BSM.Deleted.ToString();
            this.TextBox_NONQUALIFIED.Text = BSM.NonQualified.ToString();
            this.TextBox_IS.Text = BSM.InfusionSoft_InSystem.ToString();
            






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Resume_Click(object sender, EventArgs e)
        {
            this.BSM.Increment_Resume();
            this.TextBox_OPEN.Text = BSM.Open.ToString();
            this.TextBox_REPLY.Text = BSM.Reply.ToString();
            this.TextBox_RESUME.Text = BSM.Resume.ToString();
            this.TextBox_MEETING.Text = BSM.Meeting.ToString();

            Popup newPopup = new Popup(InsertIntoList, (!MeetingBoost) ? "Resume" : "BOTH");
            newPopup.Show();

            
        }

        private void Button_Meeting_Click(object sender, EventArgs e)
        {
            this.BSM.Increment_Meeting();
            this.TextBox_OPEN.Text = BSM.Open.ToString();
            this.TextBox_REPLY.Text = BSM.Reply.ToString();

            this.TextBox_MEETING.Text = BSM.Meeting.ToString();
            this.TextBox_RESUME.Text = BSM.Resume.ToString();

            Popup newPopup = new Popup(InsertIntoList, (!MeetingBoost) ? "Meeting" : "BOTH");
            newPopup.Show();
        }

        private void InsertIntoList(string firstname,string email, string Type)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.Text = firstname;
            newItem.SubItems.Add(email);
            newItem.SubItems.Add(Type);
            ListView_ContactExecList.Items.Add(newItem);
            ListView_ContactExecList.Refresh();
        }

        private void Button_NonQualified_Click(object sender, EventArgs e)
        {
            this.BSM.Increment_NonQualified();
            this.TextBox_OPEN.Text = BSM.Open.ToString();

            this.TextBox_NONQUALIFIED.Text = BSM.NonQualified.ToString();
        }

        private void Button_InSystem_Click(object sender, EventArgs e)
        {
            this.BSM.IncrementIS();
            this.TextBox_OPEN.Text = BSM.Open.ToString();

            this.TextBox_IS.Text = BSM.InfusionSoft_InSystem.ToString();
        }

        private void Button_Deleted_Click(object sender, EventArgs e)
        {
            this.BSM.Increment_Deleted();
            this.TextBox_OPEN.Text = BSM.Open.ToString();

            this.TextBox_DELETED.Text = BSM.Deleted.ToString();
        }

        private void Button_CopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(BSM.GenerateText());
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            this.ListView_ContactExecList.Items.Clear();
            this.ListView_ContactExecList.Refresh();
            this.BSM.Reset();
            UpdateAllTextBoxes();
            TestValid();
        }




        private void Button_EditDone_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                EditMode = true;
                Button_EditDone.Text = "Done";
                TextBox_OPEN.ReadOnly = false;
                TextBox_REPLY.ReadOnly = false;
                TextBox_RESUME.ReadOnly = false;
                TextBox_MEETING.ReadOnly = false;
                TextBox_DELETED.ReadOnly = false;
                TextBox_NONQUALIFIED.ReadOnly = false;
                TextBox_IS.ReadOnly = false;
            }
            else
            {
                EditMode = false;
                Button_EditDone.Text = "Edit";
                TextBox_OPEN.ReadOnly = true;
                TextBox_REPLY.ReadOnly = true;
                TextBox_RESUME.ReadOnly = true;
                TextBox_MEETING.ReadOnly = true;
                TextBox_DELETED.ReadOnly = true;
                TextBox_NONQUALIFIED.ReadOnly = true;
                TextBox_IS.ReadOnly = true;
            }

        }

        private void CheckBox_MeetingBoost_CheckedChanged(object sender, EventArgs e)
        {
            var box = sender as CheckBox;
            if( BSM.Open > 0)
            {
                
                DialogResult result = MessageBox.Show("Changing modes during bulk work will confuse numbers validation. Is that Okay? ", "Changing mode during In-Progress BULK", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BSM.MeetingBoost = this.MeetingBoost = (sender as CheckBox).Checked;
                    return;
                }
                else
                {
                    box.CheckedChanged -= CheckBox_MeetingBoost_CheckedChanged;
                    box.Checked = !box.Checked;
                    box.CheckedChanged += CheckBox_MeetingBoost_CheckedChanged;

                    return;
                }

            }

            BSM.MeetingBoost = this.MeetingBoost = (sender as CheckBox).Checked;
        }

        private async void Button_SendEmails_Click(object sender, EventArgs e)
        {
            this.MS.loadListViewItems(ListView_ContactExecList.Items);
            await this.MS.SendEmails();
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if(ListView_ContactExecList.SelectedItems.Count != 0)
            {
                ListView_ContactExecList.Items.Remove(ListView_ContactExecList.SelectedItems[0]);
                ListView_ContactExecList.Refresh();
            }
        }
    }
}
