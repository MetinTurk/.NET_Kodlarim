using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Hafta12Pazartesi.models
{
    public class IsubuException : Exception
    {
        public IsubuException()
        {
        }

        public IsubuException(string? message) : base(message)
        {
        }

        public IsubuException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IsubuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
