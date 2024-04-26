using System;


namespace ConsoleExceptionHandleApp2.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
