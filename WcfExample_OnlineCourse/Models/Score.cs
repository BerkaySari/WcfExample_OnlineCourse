using System.Runtime.Serialization;

namespace WcfExample_OnlineCourse.Models
{
    [DataContract]
    public class Score
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StudentId { get; set; }
        [DataMember]
        public int CourseId { get; set; }
        [DataMember]
        public int CourseScore { get; set; }
    }
}