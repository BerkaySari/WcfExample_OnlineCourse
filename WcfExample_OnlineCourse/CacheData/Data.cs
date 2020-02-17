using System.Collections.Generic;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.CacheData
{
    public class Data
    {
        public static List<Course> TempData_Courses { get; set; } = new List<Course>();
        public static List<School> TempData_School { get; set; } = new List<School>();
        public static List<Score> TempData_Score { get; set; } = new List<Score>();
        public static List<Student> TempData_Student { get; set; } = new List<Student>();
    }
}