using System;
using System.Runtime.Serialization;

namespace VendeBemVeiculos
{
    [Serializable]
    internal class ExceptionDadoJaExistente : Exception
    {
        public ExceptionDadoJaExistente()
        {
        }

        public ExceptionDadoJaExistente(string message) : base(message)
        {
        }

        public ExceptionDadoJaExistente(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionDadoJaExistente(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}