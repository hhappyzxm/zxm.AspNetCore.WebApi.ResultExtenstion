using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zxm.AspNetCore.WebApi.ResultExtenstion
{
    public class NonSystemException : Exception
    {
        public NonSystemException(string message) : base(message)
        {
        }
    }
}
