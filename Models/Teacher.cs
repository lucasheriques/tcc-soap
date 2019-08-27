using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Teacher
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Disciplines { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string University { get; set; }
        [DataMember]
        public string Birthday { get; set; }
    }
}