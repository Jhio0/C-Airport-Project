using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    [Serializable]
    internal class FlightIsFullException : Exception
    {
        public FlightIsFullException()
        {
        }

        public FlightIsFullException(string message) : base(message)
        {
        }


        public FlightIsFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FlightIsFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
