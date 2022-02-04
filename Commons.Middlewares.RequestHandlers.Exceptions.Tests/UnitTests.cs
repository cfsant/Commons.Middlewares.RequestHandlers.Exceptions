using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using Xunit;

namespace Commons.Middlewares.RequestHandlers.Exceptions.Tests
{
    public class UnitTests
    {
        private const string INTERNAL_EXCEPTION_MESSAGE = "InternalException";
        private const string DEVELOPER_INTERNAL_EXCEPTION_MESSAGE = "DeveloperInternalException";
        private const string PRODUCTION_INTERNAL_EXCEPTION_MESSAGE = "ProductionInternalException";

        public UnitTests()
        {
        }

        [Fact]
        public void InternalExceptionTests()
        {
            InternalException exception = new InternalException(INTERNAL_EXCEPTION_MESSAGE);

            Assert.NotNull(exception);
            Assert.Equal(INTERNAL_EXCEPTION_MESSAGE, exception.Message);
        }

        [Fact]
        public void DeveloperInternalExceptionTests()
        {
            var e = new Exception(DEVELOPER_INTERNAL_EXCEPTION_MESSAGE);

            DeveloperInternalException exception = new DeveloperInternalException(e.Message, e, e.StackTrace);

            Assert.NotNull(exception);
            Assert.Equal(e.Message, exception.Message);
            Assert.Equal(e, exception.InnerException);
            Assert.Equal(e.StackTrace, exception.StackTrace);
        }

        [Fact]
        public void ProductionInternalExceptionTests()
        {
            var e = new Exception(PRODUCTION_INTERNAL_EXCEPTION_MESSAGE);

            ProductionInternalException exception = new ProductionInternalException(e.Message, PRODUCTION_INTERNAL_EXCEPTION_MESSAGE);

            Assert.NotNull(exception);
            Assert.Equal(e.Message, exception.Message);
            Assert.Equal(PRODUCTION_INTERNAL_EXCEPTION_MESSAGE, exception.Detail);
        }
    }
}
