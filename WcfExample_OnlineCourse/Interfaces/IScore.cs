using System.ServiceModel;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Interfaces
{
    [ServiceContract]
    public interface IScore
    {
        [OperationContract]
        ReturnValue<Score> AddScore(Score score);

        [OperationContract]
        bool DeleteScore(int scoreId);

        [OperationContract]
        ReturnValue<double> GetAvgScoreForCourse(int courseId);

        [OperationContract]
        ReturnValue<double> GetAvgScoreForStudent(int studentId);

        [OperationContract]
        ReturnValue<Score> GetScore(int scoreId);
    }
}
