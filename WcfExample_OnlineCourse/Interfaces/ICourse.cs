using System.ServiceModel;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Interfaces
{
    [ServiceContract]
    public interface ICourse
    {
        [OperationContract]
        ReturnValue<Course> AddCourse(Course course);

        [OperationContract]
        ReturnValue<School> AddSchoolToCourse(int schoolId, int courseId);

        [OperationContract]
        ReturnValue<Student> AddStudentToCourse(int studentId, int courseId);

        [OperationContract]
        bool DeleteCourse(int courseId);

        [OperationContract]
        ReturnValue<Course> GetCourse(int courseId);

        [OperationContract]
        ReturnValue<int> GetRegisteredStudentsCount(int courseId);

        [OperationContract]
        ReturnValue<double> GetRegisteredStudentsScoreAvg(int courseId);
    }
}
