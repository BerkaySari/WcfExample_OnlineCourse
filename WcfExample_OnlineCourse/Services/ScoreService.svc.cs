using System.Linq;
using WcfExample_OnlineCourse.CacheData;
using WcfExample_OnlineCourse.Helper;
using WcfExample_OnlineCourse.Interfaces;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Services
{
    public class ScoreService : IScore
    {
        public ReturnValue<Score> AddScore(Score score)
        {
            Data.TempData_Score.Add(score);
            return Return.ReturnSuccess("Score added successfully", score);
        }

        public bool DeleteScore(int scoreId)
        {
            var retval = Data.TempData_Score.RemoveAll(score => score.Id == scoreId);
            return retval > 0;
        }

        public ReturnValue<double> GetAvgScoreForCourse(int courseId)
        {
            var courseObj = Data.TempData_Courses.FirstOrDefault(course => course.Id == courseId);
            if (courseObj == null)
                return Return.ReturnUnsuccess<double>("Course object is null");

            var courseAverage = Data.TempData_Score.Where(score => score.CourseId == courseId).Select(score => score.CourseScore).Average();
            return Return.ReturnSuccess("", courseAverage);
        }

        public ReturnValue<double> GetAvgScoreForStudent(int studentId)
        {
            var studentObj = Data.TempData_Student.FirstOrDefault(student => student.Id == studentId);
            if (studentObj == null)
                return Return.ReturnUnsuccess<double>("Student object is null");

            var studentAverage = Data.TempData_Score.Where(score => score.StudentId == studentId).Select(score => score.CourseScore).Average();
            return Return.ReturnSuccess("", studentAverage);
        }

        public ReturnValue<Score> GetScore(int scoreId)
        {
            var data = Data.TempData_Score.FirstOrDefault(score => score.Id == scoreId);
            return data != null ? Return.ReturnSuccess("", data) : Return.ReturnUnsuccess<Score>("Data is null");
        }
    }
}
