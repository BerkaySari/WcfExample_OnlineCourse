using WcfExample_OnlineCourse.Models;

namespace WcfExample_OnlineCourse.Helper
{
    public class Return
    {
        public static ReturnValue<T> ReturnSuccess<T>(string message, T obj)
        {
            return new ReturnValue<T>
            {
                IsSuccuess = true,
                Message = message,
                Object = obj
            };
        }

        public static ReturnValue<T> ReturnSuccess<T>(string message)
        {
            return new ReturnValue<T>
            {
                IsSuccuess = true,
                Message = message,
            };
        }

        public static ReturnValue<T> ReturnUnsuccess<T>(string message, T obj)
        {
            return new ReturnValue<T>
            {
                IsSuccuess = false,
                Message = message,
                Object = obj
            };
        }

        public static ReturnValue<T> ReturnUnsuccess<T>(string message)
        {
            return new ReturnValue<T>
            {
                IsSuccuess = false,
                Message = message
            };
        }
    }
}