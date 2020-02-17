using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfExample_OnlineCourse.Models
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public List<School> Schools { get; set; } = new List<School>();
        [DataMember]
        public List<Student> Students { get; set; } = new List<Student>();
    }
}