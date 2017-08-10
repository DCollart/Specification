using System;
using System.Runtime.Serialization;

namespace Specification.Specifications
{
    public class UnableToCompileException : InvalidOperationException
    {
        public UnableToCompileException()
        {
        }

        public UnableToCompileException(string message) : base(message)
        {
        }

        public UnableToCompileException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}