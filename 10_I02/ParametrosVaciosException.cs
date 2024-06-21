using System.Runtime.Serialization;

namespace _10_I02
{
    [Serializable]
    internal class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException()
        {
        }

        public ParametrosVaciosException(string? message) : base(message)
        {
        }

        public ParametrosVaciosException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ParametrosVaciosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}