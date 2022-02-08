using Commons.Middlewares.RequestHandlers.Exceptions.Interfaces;
using System;

namespace Commons.Middlewares.RequestHandlers.Exceptions
{
    public class DeveloperInternalException : InternalException, IDeveloperInternalException
    {
        public DeveloperInternalException()
        {

        }

#nullable enable
        public DeveloperInternalException(string message, Exception? exception, string stackTrace)
#nullable disable
        {
            Message = message;
            InnerException = exception;
            StackTrace = stackTrace;
        }

        public Exception InnerException { get; set; }
        public string StackTrace { get; set; }
    }
}
