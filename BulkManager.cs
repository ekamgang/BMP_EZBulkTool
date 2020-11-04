using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using BMPBulkFunctions;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace BMP_EZBulkTool
{

    
    public class BulkStatsManager
    {
        private static readonly string AppKey = "";
        private static readonly HttpClient client = new HttpClient();

        public bool MeetingBoost { get; set; }
        public uint Open { get; set; }
        public uint Reply { get; set; }
        public uint Resume { get; set; }
        public uint Meeting { get; set; }
        public uint Deleted { get; set; }
        public uint NonQualified {get; set;}
        public uint InfusionSoft_InSystem { get; set; }


        public BulkStatsManager()
        {
            Open = Reply = Resume = Meeting = Deleted = NonQualified = InfusionSoft_InSystem = 0;
        }

        public BulkStatsManager(uint Open = 0, uint Reply = 0, uint Resume = 0, uint Meeting = 0, uint Deleted = 0, uint NonQualified = 0, uint IS = 0)
        {
            this.Open = Open;
            this.Reply = Reply;
            this.Resume = Resume;
            this.Meeting = Meeting;
            this.Deleted = Deleted;
            this.NonQualified = NonQualified;
            this.InfusionSoft_InSystem = IS;
        }

        public void Increment_Resume()
        {
            this.Open++;
            this.Reply++;
            this.Resume++;
            if (!MeetingBoost) { 
                return;
            }
            this.Meeting++;

        }

        public void Increment_Meeting()
        {
            this.Open++;
            this.Reply++;
            this.Meeting++;
            if (!MeetingBoost) {
                return;
            }
            this.Resume++;
            return;

        }

        public void Increment_Deleted()
        {
            this.Open++;
            this.Deleted++;
        }

        public void Increment_NonQualified()
        {
            this.Open++;
            this.NonQualified++;
        }

        public void IncrementIS()
        {
            this.Open++;
            this.InfusionSoft_InSystem++;
        }

        public void Reset()
        {
            Open = Reply = Resume = Meeting = Deleted = NonQualified = InfusionSoft_InSystem = 0;
        }


        public string GenerateText()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"BULK\n");
            stringBuilder.Append($"Open {Open}\n");
            stringBuilder.Append($"Reply {Reply}\n\n");
            stringBuilder.Append($"Resume {Resume}\n");
            stringBuilder.Append($"Meeting {Meeting}\n\n");
            stringBuilder.Append($"Deleted {Deleted}\n");
            stringBuilder.Append($"Non-Qual {NonQualified}\n");
            stringBuilder.Append($"IS (< 6 months) {this.InfusionSoft_InSystem}\n");

            return stringBuilder.ToString();

        }



        public async Task<bool> HTTPSendToDB(string FirstName, string LastName)
        {
            /*
            var UrlValues = new Dictionary<string, string>
            {
                {"code", AppKey },
                {"clientId","BMPBulkTools_WindowsApp" }, //Hard coded values ( I KNOW,  BAD PRACTICE, TODO: config file)
                {"firstname", FirstName },
                {"lastname", LastName },
                {"opened", this.Open.ToString() },
                {"replied" , this.Reply.ToString() },
                {"resumes", this.Resume.ToString() },
                {"meeting", this.Meeting.ToString() },
                {"notqual", this.NonQualified.ToString() },
                {"deleted", this.Deleted.ToString() },
                {"insystem", this.InfusionSoft_InSystem.ToString() },
                
            };

            
            */

            var content = new FormUrlEncodedContent(new Dictionary<string,string>());
            var response = await client.PostAsync(String.Format("https://bmpbulkfunctions.azurewebsites.net/api/InsertNewBulkSession?code={0}&clientId={1}&firstname={2}&lastname={3}&opened={4}&replied={5}&resumes={6}&meeting={7}&notqual={8}&deleted={9}&insystem={10}",AppKey, "BMPBulkTools_WindowsApp",FirstName,LastName,Open,Reply,Resume,Meeting,NonQualified,Deleted,InfusionSoft_InSystem),content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;

            
        }


        public async Task<DataContracts.SQLJsonBulkNumbers> GetBulkNumbers(DateTime date)
        {
            try
            {
                var response = await client.GetAsync(String.Format("https://bmpbulkfunctions.azurewebsites.net/api/GetDailyBulk?code={0}&clientId={1}&date={2}", AppKey, "BMPBulkTools_WindowsApp", date.ToString("yyyy-MM-dd")));

                if (response.IsSuccessStatusCode)
                {
                    DataContracts.SQLJsonBulkNumbers bulkNumbers = JsonConvert.DeserializeObject<DataContracts.SQLJsonBulkNumbers>(await response.Content.ReadAsStringAsync());

                    return bulkNumbers;
                }
            }
            catch(HttpRequestException e1)
            {
                //Show dialog?
                MessageBox.Show($"An Error occured during HTTP request. Message: {e1.Message}", "ERROR DURING REQUEST", MessageBoxButtons.OK);
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }

    }
}
