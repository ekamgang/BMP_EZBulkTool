using System;
using System.Collections.Generic;
using System.Text;

namespace BMP_EZBulkTool
{
    class BulkStatsManager
    {
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

    }
}
