
using System.Runtime.Serialization;

namespace Json_Xml
{
    [DataContract]
    public class Member
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public string secretIdentity { get; set; }
        [DataMember]
        public string[] powers { get; set; }
    }
}
