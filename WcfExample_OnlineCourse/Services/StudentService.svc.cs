using System.Linq;
using WcfExample_OnlineCourse.CacheData;
using WcfExample_OnlineCourse.Helper;
using WcfExample_OnlineCourse.Interfaces;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Services
{
    public class StudentService : IStudent
    {
        public ReturnValue<Course> AddCourseToStudent(int courseId, int studentId)
        {
            var studentObj = Data.TempData_Student.FirstOrDefault(student => student.Id == studentId);
            if (studentObj == null)
                return Return.ReturnUnsuccess<Course>("Student object is null");

            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess("Course object is null", courseObj);

            Data.TempData_Student.FirstOrDefault(student => student.Id == studentId).Courses.Add(courseObj);

            return Return.ReturnSuccess("Course added to student", courseObj);
        }

        public ReturnValue<Score> AddScoreToStudent(int scoreId, int studentId)
        {
            var studentObj = Data.TempData_Student.FirstOrDefault(student => student.Id == studentId);
            if (studentObj == null)
                return Return.ReturnUnsuccess<Score>("Student object is null");

            var scoreObj = Data.TempData_Score.FirstOrDefault(score => score.Id == scoreId);
            if (scoreObj == null)
                return Return.ReturnUnsuccess("Score object is null", scoreObj);

            Data.TempData_Student.FirstOrDefault(student => student.Id == studentId).Scores.Add(scoreObj);

            return Return.ReturnSuccess("Score added to student", scoreObj);
        }

        public ReturnValue<Student> AddStudent(Student student)
        {
            Data.TempData_Student.Add(student);
            return Return.ReturnSuccess("Student added successfully", student);
        }

        public bool DeleteStudent(int studentId)
        {
            var retval = Data.TempData_Student.RemoveAll(student => student.Id == studentId);
            return retval > 0;
        }

        public ReturnValue<Student> GetStudent(int studentId)
        {
            var data = Data.TempData_Student.FirstOrDefault(student => student.Id == studentId);
            return data != null ? Return.ReturnSuccess("", data) : Return.ReturnUnsuccess<Student>("Data is null");
        }
    }
}
