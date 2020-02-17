using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfExample_OnlineCourse.Models
{
    [DataContract]
    public class School
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string SchoolName { get; set; }
        [DataMember]
        public string SchoolCode { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public List<Course> Courses { get; set; } = new List<Course>();
        [DataMember]
        public List<Student> Students { get; set; } = new List<Student>();
    }
}