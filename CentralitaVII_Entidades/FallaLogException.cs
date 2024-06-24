using System.Runtime.Serialization;

namespace CentralitaVII_Entidades
{
    [Serializable]
    internal class FallaLogException : Exception
    {
        public FallaLogException()
        {
        }

        public FallaLogException(string? message) : base(message)
        {
        }

        public FallaLogException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FallaLogException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}