
using System.Runtime.Serialization;

namespace Json_Xml
{
    [DataContract]
    public class Squad
    {
        [DataMember]
        public string squadName {  get; set; }
        [DataMember]
        public string homeTown { get; set; }
        [DataMember]
        public int formed { get; set; }
        [DataMember]
        public string secretBase { get; set; }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public Member [] members  { get; set; }

    }
}
