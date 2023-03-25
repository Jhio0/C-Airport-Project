using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    [Serializable]
    internal class FlightDetailsLeftEmptyException : Exception
    {

        public FlightDetailsLeftEmptyException()
        {
        }

        public FlightDetailsLeftEmptyException(string message) : base(message)
        {
        }


        public FlightDetailsLeftEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FlightDetailsLeftEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
