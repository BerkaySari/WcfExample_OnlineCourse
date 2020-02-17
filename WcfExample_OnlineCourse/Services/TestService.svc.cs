using System;
using WcfExample_OnlineCourse.Helper;
using WcfExample_OnlineCourse.Interfaces;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Services
{
    public class TestService : ITest
    {
        public ReturnValue<bool> CreateTestData()
        {
            createCourses();
            createSchools();
            createStudents();
            createScores();

            createReleationships();

            return Return.ReturnSuccess("Test data is created", true);
        }

        private void createCourses()
        {
            CourseService cs = new CourseService();
            cs.AddCourse(new Course
            {
                Id = 1,
                Code = "Math101",
                Name = "Math"
            });

            cs.AddCourse(new Course
            {
                Id = 2,
                Code = "Math102",
                Name = "Geometry"
            });

            cs.AddCourse(new Course
            {
                Id = 3,
                Code = "Che101",
                Name = "Chemistry"
            });

            cs.AddCourse(new Course
            {
                Id = 4,
                Code = "Phy101",
                Name = "Physics"
            });

            cs.AddCourse(new Course
            {
                Id = 5,
                Code = "His101",
                Name = "History"
            });
        }

        private void createSchools()
        {
            SchoolService ss = new SchoolService();
            ss.AddSchool(new School
            {
                Id = 1,
                City = "İstanbul",
                State = "Beşiktaş",
                SchoolCode = "Ist1",
                SchoolName = "Istanbul Public School",
            });

            ss.AddSchool(new School
            {
                Id = 2,
                City = "İstanbul",
                State = "Kadıköy",
                SchoolCode = "Ist2",
                SchoolName = "Istanbul Private School",
            });

            ss.AddSchool(new School
            {
                Id = 3,
                City = "İzmir",
                State = "Bornova",
                SchoolCode = "Izm1",
                SchoolName = "İzmir Public School",
            });

            ss.AddSchool(new School
            {
                Id = 4,
                City = "Ankara",
                State = "Çankaya",
                SchoolCode = "Ank1",
                SchoolName = "Ankara Public School",
            });
        }

        private void createStudents()
        {
            StudentService ss = new StudentService();
            ss.AddStudent(new Student
            {
                Id = 1,
                Class = "8. Grade",
                Name = "TempName 1",
                Surname = "TempSurname 1",
                Email = "tempmail1@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 1
            });

            ss.AddStudent(new Student
            {
                Id = 2,
                Class = "9. Grade",
                Name = "TempName 2",
                Surname = "TempSurname 2",
                Email = "tempmail2@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 1
            });

            ss.AddStudent(new Student
            {
                Id = 3,
                Class = "7. Grade",
                Name = "TempName 3",
                Surname = "TempSurname 3",
                Email = "tempmail3@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 1
            });


            ss.AddStudent(new Student
            {
                Id = 4,
                Class = "6. Grade",
                Name = "TempName 4",
                Surname = "TempSurname 4",
                Email = "tempmail4@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 2
            });

            ss.AddStudent(new Student
            {
                Id = 5,
                Class = "10. Grade",
                Name = "TempName 5",
                Surname = "TempSurname 5",
                Email = "tempmail5@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 2
            });

            ss.AddStudent(new Student
            {
                Id = 6,
                Class = "9. Grade",
                Name = "TempName 6",
                Surname = "TempSurname 6",
                Email = "tempmail6@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 2
            });

            ss.AddStudent(new Student
            {
                Id = 7,
                Class = "9. Grade",
                Name = "TempName 7",
                Surname = "TempSurname 7",
                Email = "tempmail7@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 3
            });

            ss.AddStudent(new Student
            {
                Id = 8,
                Class = "8. Grade",
                Name = "TempName 8",
                Surname = "TempSurname 8",
                Email = "tempmail8@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 3
            });

            ss.AddStudent(new Student
            {
                Id = 9,
                Class = "7. Grade",
                Name = "TempName 9",
                Surname = "TempSurname 9",
                Email = "tempmail9@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 3
            });

            ss.AddStudent(new Student
            {
                Id = 10,
                Class = "7. Grade",
                Name = "TempName 10",
                Surname = "TempSurname 10",
                Email = "tempmail10@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 4
            });

            ss.AddStudent(new Student
            {
                Id = 11,
                Class = "9. Grade",
                Name = "TempName 11",
                Surname = "TempSurname 11",
                Email = "tempmail11@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 4
            });

            ss.AddStudent(new Student
            {
                Id = 12,
                Class = "8. Grade",
                Name = "TempName 12",
                Surname = "TempSurname 12",
                Email = "tempmail12@gmail.com",
                Password = "testpassw0rd",
                SchoolId = 4
            });
        }

        private void createScores()
        {
            Random rnd = new Random();
            ScoreService ss = new ScoreService();
            ss.AddScore(new Score
            {
                Id = 1,
                CourseScore = rnd.Next(101),
                StudentId = 1,
                CourseId = 1
            });

            ss.AddScore(new Score
            {
                Id = 2,
                CourseScore = rnd.Next(101),
                StudentId = 4,
                CourseId = 1
            });

            ss.AddScore(new Score
            {
                Id = 3,
                CourseScore = rnd.Next(101),
                StudentId = 6,
                CourseId = 1
            });

            ss.AddScore(new Score
            {
                Id = 4,
                CourseScore = rnd.Next(101),
                StudentId = 11,
                CourseId = 1
            });

            ss.AddScore(new Score
            {
                Id = 5,
                CourseScore = rnd.Next(101),
                StudentId = 12,
                CourseId = 1
            });

            ss.AddScore(new Score
            {
                Id = 6,
                CourseScore = rnd.Next(101),
                StudentId = 2,
                CourseId = 2
            });

            ss.AddScore(new Score
            {
                Id = 7,
                CourseScore = rnd.Next(101),
                StudentId = 3,
                CourseId = 2
            });

            ss.AddScore(new Score
            {
                Id = 8,
                CourseScore = rnd.Next(101),
                StudentId = 7,
                CourseId = 2
            });

            ss.AddScore(new Score
            {
                Id = 9,
                CourseScore = rnd.Next(101),
                StudentId = 8,
                CourseId = 2
            });

            ss.AddScore(new Score
            {
                Id = 10,
                CourseScore = rnd.Next(101),
                StudentId = 10,
                CourseId = 2
            });

            ss.AddScore(new Score
            {
                Id = 11,
                CourseScore = rnd.Next(101),
                StudentId = 5,
                CourseId = 3
            });

            ss.AddScore(new Score
            {
                Id = 12,
                CourseScore = rnd.Next(101),
                StudentId = 7,
                CourseId = 3
            });

            ss.AddScore(new Score
            {
                Id = 13,
                CourseScore = rnd.Next(101),
                StudentId = 8,
                CourseId = 3
            });

            ss.AddScore(new Score
            {
                Id = 14,
                CourseScore = rnd.Next(101),
                StudentId = 11,
                CourseId = 3
            });

            ss.AddScore(new Score
            {
                Id = 15,
                CourseScore = rnd.Next(101),
                StudentId = 1,
                CourseId = 4
            });

            ss.AddScore(new Score
            {
                Id = 16,
                CourseScore = rnd.Next(101),
                StudentId = 6,
                CourseId = 4
            });

            ss.AddScore(new Score
            {
                Id = 17,
                CourseScore = rnd.Next(101),
                StudentId = 7,
                CourseId = 4
            });

            ss.AddScore(new Score
            {
                Id = 18,
                CourseScore = rnd.Next(101),
                StudentId = 9,
                CourseId = 4
            });

            ss.AddScore(new Score
            {
                Id = 19,
                CourseScore = rnd.Next(101),
                StudentId = 11,
                CourseId = 4
            });
            
            ss.AddScore(new Score
            {
                Id = 20,
                CourseScore = rnd.Next(101),
                StudentId = 12,
                CourseId = 4
            });
        }

        private void createReleationships()
        {
            createCourseReleationships();
            createSchoolReleationships();
            createStudentReleationships();
        }

        private void createCourseReleationships()
        {
            CourseService cs = new CourseService();
            cs.AddStudentToCourse(1, 1);
            cs.AddStudentToCourse(4, 1);
            cs.AddStudentToCourse(6, 1);
            cs.AddStudentToCourse(11, 1);
            cs.AddStudentToCourse(12, 1);
            cs.AddStudentToCourse(2, 2);
            cs.AddStudentToCourse(3, 2);
            cs.AddStudentToCourse(7, 2);
            cs.AddStudentToCourse(8, 2);
            cs.AddStudentToCourse(10, 2);
            cs.AddStudentToCourse(5, 3);
            cs.AddStudentToCourse(7, 3);
            cs.AddStudentToCourse(8, 3);
            cs.AddStudentToCourse(11, 3);
            cs.AddStudentToCourse(1, 4);
            cs.AddStudentToCourse(6, 4);
            cs.AddStudentToCourse(7, 4);
            cs.AddStudentToCourse(9, 4);
            cs.AddStudentToCourse(11, 4);
            cs.AddStudentToCourse(12, 4);

            cs.AddSchoolToCourse(1, 1);
            cs.AddSchoolToCourse(1, 2);
            cs.AddSchoolToCourse(1, 3);
            cs.AddSchoolToCourse(2, 2);
            cs.AddSchoolToCourse(2, 3);
            cs.AddSchoolToCourse(2, 4);
            cs.AddSchoolToCourse(3, 1);
            cs.AddSchoolToCourse(3, 2);
            cs.AddSchoolToCourse(3, 4);
            cs.AddSchoolToCourse(4, 1);
            cs.AddSchoolToCourse(4, 3);
            cs.AddSchoolToCourse(4, 4);
        }

        private void createSchoolReleationships()
        {
            SchoolService ss = new SchoolService();
            ss.AddStudentToSchool(1, 1);
            ss.AddStudentToSchool(2, 1);
            ss.AddStudentToSchool(3, 1);
            ss.AddStudentToSchool(4, 2);
            ss.AddStudentToSchool(5, 2);
            ss.AddStudentToSchool(6, 2);
            ss.AddStudentToSchool(7, 3);
            ss.AddStudentToSchool(8, 3);
            ss.AddStudentToSchool(9, 3);
            ss.AddStudentToSchool(10, 4);
            ss.AddStudentToSchool(11, 4);
            ss.AddStudentToSchool(12, 4);

            ss.AddCourseToSchool(1, 1);
            ss.AddCourseToSchool(2, 1);
            ss.AddCourseToSchool(3, 1);
            ss.AddCourseToSchool(2, 2);
            ss.AddCourseToSchool(3, 2);
            ss.AddCourseToSchool(4, 2);
            ss.AddCourseToSchool(1, 3);
            ss.AddCourseToSchool(2, 3);
            ss.AddCourseToSchool(4, 3);
            ss.AddCourseToSchool(1, 4);
            ss.AddCourseToSchool(3, 4);
            ss.AddCourseToSchool(4, 4);
        }

        private void createStudentReleationships()
        {
            StudentService ss = new StudentService();
            ss.AddCourseToStudent(1, 1);
            ss.AddCourseToStudent(1, 4);
            ss.AddCourseToStudent(1, 6);
            ss.AddCourseToStudent(1, 11);
            ss.AddCourseToStudent(1, 12);
            ss.AddCourseToStudent(2, 2);
            ss.AddCourseToStudent(2, 3);
            ss.AddCourseToStudent(2, 7);
            ss.AddCourseToStudent(2, 8);
            ss.AddCourseToStudent(2, 10);
            ss.AddCourseToStudent(3, 5);
            ss.AddCourseToStudent(3, 7);
            ss.AddCourseToStudent(3, 8);
            ss.AddCourseToStudent(3, 11);
            ss.AddCourseToStudent(4, 1);
            ss.AddCourseToStudent(4, 6);
            ss.AddCourseToStudent(4, 7);
            ss.AddCourseToStudent(4, 9);
            ss.AddCourseToStudent(4, 11);
            ss.AddCourseToStudent(4, 12);

            ss.AddScoreToStudent(1, 1);
            ss.AddScoreToStudent(2, 4);
            ss.AddScoreToStudent(3, 6);
            ss.AddScoreToStudent(4, 11);
            ss.AddScoreToStudent(5, 12);
            ss.AddScoreToStudent(6, 2);
            ss.AddScoreToStudent(7, 3);
            ss.AddScoreToStudent(8, 7);
            ss.AddScoreToStudent(9, 8);
            ss.AddScoreToStudent(10, 10);
            ss.AddScoreToStudent(11, 5);
            ss.AddScoreToStudent(12, 7);
            ss.AddScoreToStudent(13, 8);
            ss.AddScoreToStudent(14, 11);
            ss.AddScoreToStudent(15, 1);
            ss.AddScoreToStudent(16, 6);
            ss.AddScoreToStudent(17, 7);
            ss.AddScoreToStudent(18, 9);
            ss.AddScoreToStudent(19, 11);
            ss.AddScoreToStudent(20, 12);
        }
    }
}
