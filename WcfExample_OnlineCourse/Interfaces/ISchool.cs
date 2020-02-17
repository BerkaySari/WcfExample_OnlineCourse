using System.ServiceModel;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Interfaces
{
    [ServiceContract]
    public interface ISchool
    {
        [OperationContract]
        ReturnValue<School> AddSchool(School school);

        [OperationContract]
        ReturnValue<Course> AddCourseToSchool(int courseId, int schoolId);

        [OperationContract]
        ReturnValue<Student> AddStudentToSchool(int studentId, int schoolId);

        [OperationContract]
        bool DeleteSchool(int schoolId);

        [OperationContract]
        ReturnValue<School> GetSchool(int schoolId);
    }
}
