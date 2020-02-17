using System.Runtime.Serialization;

namespace WcfExample_OnlineCourse.Models
{
    [DataContract]
    public class ReturnValue<T>
    {
        [DataMember]
        public bool IsSuccuess { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public T Object { get; set; }
    }
}