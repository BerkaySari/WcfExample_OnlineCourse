using System.Linq;
using WcfExample_OnlineCourse.CacheData;
using WcfExample_OnlineCourse.Helper;
using WcfExample_OnlineCourse.Interfaces;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Services
{
    public class SchoolService : ISchool
    {
        public ReturnValue<School> AddSchool(School school)
        {
            Data.TempData_School.Add(school);
            return Return.ReturnSuccess("School added successfully", school);
        }

        public ReturnValue<Course> AddCourseToSchool(int courseId, int schoolId)
        {
            var schoolObj = Data.TempData_School.FirstOrDefault(school => school.Id == schoolId);
            if (schoolObj == null)
                return Return.ReturnUnsuccess<Course>("School object is null");

            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess("Course object is null", courseObj);

            Data.TempData_School.FirstOrDefault(school => school.Id == schoolId).Courses.Add(courseObj);

            return Return.ReturnSuccess("Course added to school", courseObj);
        }

        public ReturnValue<Student> AddStudentToSchool(int studentId, int schoolId)
        {
            var schoolObj = Data.TempData_School.FirstOrDefault(school => school.Id == schoolId);
            if (schoolObj == null)
                return Return.ReturnUnsuccess<Student>("School object is null");

            var studentObj = Data.TempData_Student.FirstOrDefault(student => student.Id == studentId);
            if (studentObj == null)
                return Return.ReturnUnsuccess("Student object is null", studentObj);

            Data.TempData_School.FirstOrDefault(school => school.Id == schoolId).Students.Add(studentObj);

            return Return.ReturnSuccess("Student added to school", studentObj);
        }

        public bool DeleteSchool(int schoolId)
        {
            var retval = Data.TempData_School.RemoveAll(school => school.Id == schoolId);
            return retval > 0;
        }
        
        public ReturnValue<School> GetSchool(int schoolId)
        {
            var data = Data.TempData_School.FirstOrDefault(school => school.Id == schoolId);
            return data != null ? Return.ReturnSuccess("", data) : Return.ReturnUnsuccess<School>("Data is null");
        }
    }
}
