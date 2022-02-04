using Commons.Middlewares.RequestHandlers.Exceptions.Interfaces;

namespace Commons.Middlewares.RequestHandlers.Exceptions
{
    public class InternalException : IInternalException
    {
        public InternalException()
        {

        }

        public InternalException(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
