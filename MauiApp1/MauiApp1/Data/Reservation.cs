using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MauiApp1.Data
{
    [Serializable]

    public abstract class Reservation
    {
        [XmlAttribute]
        public string ReservationCode { get; set; }
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string Cost { get; set; }
        public string Name { get; set; }
        public string Citizenship { get; set; }
        public string Status { get; set; }

        public Reservation(string res, string code, string airline, string cost, string name, string citizen, string status)
        {
            ReservationCode = res;
            FlightCode = code;
            Airline = airline;
            Cost = cost;
            Name = name;
            Citizenship = citizen;
            Status = status;
        }
        
        public Reservation()
        {

        }

        public override string ToString()
        {
            return $"{ReservationCode},{FlightCode},{Airline},{Cost},{Name},{Citizenship},{Status}\n";
        }
    }
}
