using System;
using System.Runtime.Serialization;

namespace VendeBemVeiculos
{
    [Serializable]
    internal class AlreadyCreatedException : Exception
    {
        public AlreadyCreatedException()
        {
        }

        public AlreadyCreatedException(string message) : base(message)
        {
        }

        public AlreadyCreatedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AlreadyCreatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}