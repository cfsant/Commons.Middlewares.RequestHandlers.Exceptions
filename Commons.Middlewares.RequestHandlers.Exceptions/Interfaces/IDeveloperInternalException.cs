using System;

namespace Commons.Middlewares.RequestHandlers.Exceptions.Interfaces
{
    public interface IDeveloperInternalException : IInternalException
    {
        Exception? InnerException { get; set; }
        string StackTrace { get; set; }
    }
}
