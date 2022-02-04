using Commons.Middlewares.RequestHandlers.Exceptions.Interfaces;

namespace Commons.Middlewares.RequestHandlers.Exceptions
{
    public class ProductionInternalException : InternalException, IProductionInternalException
    {
        public ProductionInternalException()
        {

        }

        public ProductionInternalException(string message, string detail)
        {
            Message = message;
            Detail = detail;
        }

        public string Detail { get; set; }
    }
}
