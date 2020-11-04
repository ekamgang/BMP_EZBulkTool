
using System.Runtime.Serialization;

namespace BMPBulkFunctions
{
    public static class DataContracts
    {
        [DataContract]
        public class SQLJsonBulkNumbers
        {
            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "DAY",Order = 0)]
            public string DAY { get; set; }

            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "OPENED", Order = 1)]
            public int OPENED { get; set; }

            [DataMember(EmitDefaultValue =true, IsRequired = true, Name = "REPLIED", Order = 2)]
            public int REPLIED { get; set; }
            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "RESUMES", Order = 3)]
            public int RESUMES { get; set; }
            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "MEETING", Order = 4)]
            public int MEETING { get; set; }
            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "NOTQUAL", Order = 5)]
            public int NOTQUAL { get; set; }
            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "INSYSTEM", Order = 6)]
            public int INSYSTEM { get; set; }
            [DataMember(EmitDefaultValue = true, IsRequired = true, Name = "DELETED", Order = 7)]
            public int DELETED { get; set; }
        }



    }
}
