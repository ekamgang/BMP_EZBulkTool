using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static BMPBulkFunctions.DataContracts;
namespace BMP_EZBulkTool
{
    public partial class Form2 : Form
    {
       

        public BulkStatsManager BSM { get; set; }
        public Form2(BulkStatsManager manager) : base()
        {
            InitializeComponent();

            this.BSM = manager;

            this.dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            UpdateStatsAsync();

        }

        private async void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            await this.UpdateStatsAsync();
        }

        private async Task UpdateStatsAsync()
        {
            try
            {
                SQLJsonBulkNumbers values = await this.BSM.GetBulkNumbers(dateTimePicker1.Value);
                if (values != null)
                {
                    TextBox_TotalOpen.Text = values.OPENED.ToString();
                    TextBox_TotalReply.Text = values.REPLIED.ToString();
                    TextBox_TotalResume.Text = values.RESUMES.ToString();
                    TextBox_TotalMeeting.Text = values.MEETING.ToString();
                    TextBox_TotalDeleted.Text = values.DELETED.ToString();
                    TextBox_TotalNonQualified.Text = values.NOTQUAL.ToString();
                    TextBox_TotalIS.Text = values.INSYSTEM.ToString();
                }
                return;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await this.UpdateStatsAsync();
        }
    }
}
