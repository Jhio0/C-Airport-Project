using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    internal abstract class Flight
    {
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string fromAirport { get; set; }
        public string toAirport { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public int Count { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; } 
        public string Citizen { get; set; }
        public string Code { get; set; }


        public Flight(string code, string airline, string fromairport, string toairport, string day, string time, int count, double cost)
        {
            FlightCode = code;
            Airline = airline;
            fromAirport = fromairport;
            toAirport = toairport;
            Day = day;
            Time = time;
            Count = count;
            Cost = cost;
        }

        public Flight(){ }

        public override string ToString()
        {
            return $"{FlightCode},{Airline},{fromAirport},{toAirport},{Day},{Time},{Count},{Cost}.00";
        }
    }
}
