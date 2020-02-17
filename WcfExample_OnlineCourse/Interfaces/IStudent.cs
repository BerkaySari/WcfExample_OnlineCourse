using System.ServiceModel;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Interfaces
{
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        ReturnValue<Course> AddCourseToStudent(int courseId, int studentId);

        [OperationContract]
        ReturnValue<Score> AddScoreToStudent(int scoreId, int studentId);

        [OperationContract]
        ReturnValue<Student> AddStudent(Student student);

        [OperationContract]
        bool DeleteStudent(int studentId);

        [OperationContract]
        ReturnValue<Student> GetStudent(int studentId);
    }
}
