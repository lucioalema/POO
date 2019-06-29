using System;
namespace Excepciones
{
    public class OperacionIncorrectaException: Exception
    {
        private static readonly string DefaultMessage = "Ocurrió un error personalizado.";

        public OperacionIncorrectaException()
            : base(DefaultMessage)
        {
            
        }

        public OperacionIncorrectaException(string message)
            : base(message)
        {
            
        }

        public OperacionIncorrectaException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
    }
}