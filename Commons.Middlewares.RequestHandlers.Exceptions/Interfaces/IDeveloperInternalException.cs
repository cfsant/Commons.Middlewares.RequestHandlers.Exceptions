using System;

namespace Commons.Middlewares.RequestHandlers.Exceptions.Interfaces
{
    public interface IDeveloperInternalException : IInternalException
    {
#nullable enable
        Exception? InnerException { get; set; }
#nullable disable
        string StackTrace { get; set; }
    }
}
