using System;
using System.Runtime.Serialization;

namespace SamsMusicPlayer
{
    [Serializable]
    internal class CorruptFileException : Exception
    {
        public CorruptFileException()
        {
        }

        public CorruptFileException(string message) : base(message)
        {
        }

        public CorruptFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CorruptFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}