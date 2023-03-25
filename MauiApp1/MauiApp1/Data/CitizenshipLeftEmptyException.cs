using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    [Serializable]
    internal class CitizenshipLeftEmptyException : Exception
    {
        public CitizenshipLeftEmptyException()
        {
        }

        public CitizenshipLeftEmptyException(string message) : base(message)
        {
        }


        public CitizenshipLeftEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CitizenshipLeftEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
