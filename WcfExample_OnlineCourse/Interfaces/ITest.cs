using System.ServiceModel;
using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Interfaces
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        ReturnValue<bool> CreateTestData();
    }
}
