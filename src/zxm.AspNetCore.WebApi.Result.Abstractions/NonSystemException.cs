using System;

namespace zxm.AspNetCore.WebApi.Result.Abstractions
{
    public class NonSystemException : Exception
    {
        public NonSystemException(string message) : base(message)
        {
        }

        public NonSystemException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
