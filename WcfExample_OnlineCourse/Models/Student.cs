using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfExample_OnlineCourse.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public List<Course> Courses { get; set; } = new List<Course>();
        [DataMember]
        public List<Score> Scores { get; set; } = new List<Score>();
        [DataMember]
        public int SchoolId { get; set; }
    }
}