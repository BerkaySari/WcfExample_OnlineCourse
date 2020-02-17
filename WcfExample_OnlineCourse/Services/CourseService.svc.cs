using System.Linq;
using WcfExample_OnlineCourse.CacheData;
using WcfExample_OnlineCourse.Interfaces;
using WcfExample_OnlineCourse.Models;
using WcfExample_OnlineCourse.Helper;

namespace WcfExample_OnlineCourse.Services
{
    public class CourseService : ICourse
    {
        public ReturnValue<Course> AddCourse(Course course)
        {
            Data.TempData_Courses.Add(course);
            return Return.ReturnSuccess("Course added successfully", course);
        }

        public ReturnValue<School> AddSchoolToCourse(int schoolId, int courseId)
        {
            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess<School>("Course object is null");

            var schoolObj = Data.TempData_School.FirstOrDefault(school => school.Id == schoolId);
            if (schoolObj == null)
                return Return.ReturnUnsuccess("School object is null", schoolObj);
            
            Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId).Schools.Add(schoolObj);

            return Return.ReturnSuccess("School added to course", schoolObj);
        }

        public ReturnValue<Student> AddStudentToCourse(int studentId, int courseId)
        {
            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess<Student>("Course object is null");

            var studentObj = Data.TempData_Student.FirstOrDefault(school => school.Id == studentId);
            if (studentObj == null)
                return Return.ReturnUnsuccess("Student object is null", studentObj);

            Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId).Students.Add(studentObj);

            return Return.ReturnSuccess("Student added to course", studentObj);
        }

        public bool DeleteCourse(int courseId)
        {
            var retval = Data.TempData_Courses.RemoveAll(course => course.Id == courseId);
            return retval > 0;
        }

        public ReturnValue<Course> GetCourse(int courseId)
        {
            var data = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            return data != null ? Return.ReturnSuccess("", data) : Return.ReturnUnsuccess<Course>("Data is null");
        }

        public ReturnValue<int> GetRegisteredStudentsCount(int courseId)
        {
            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess("Course object is null", 0);

            return Return.ReturnSuccess("", courseObj.Students.Count);
        }

        public ReturnValue<double> GetRegisteredStudentsScoreAvg(int courseId)
        {
            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess<double>("Course object is null");

            var courseScores = Data.TempData_Score.Where(score => score.CourseId == courseId);
            return Return.ReturnSuccess("", courseScores.Average(score => score.CourseScore));
        }
    }
}
