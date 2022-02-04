namespace Commons.Middlewares.RequestHandlers.Exceptions.Interfaces
{
    interface IProductionInternalException : IInternalException
    {
        string Detail { get; set; }
    }
}
