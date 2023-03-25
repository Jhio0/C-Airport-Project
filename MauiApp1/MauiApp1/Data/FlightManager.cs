using MauiApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    internal class FlightManager : Flight
    {
        private const string flight_csv = "C:\\Users\\soria\\OneDrive\\Documents\\OOP2\\main airport\\MauiApp1\\MauiApp1\\Resources\\text\\flights (1).csv";
        public static List<FlightManager> flightlist = new List<FlightManager>();
        public FlightManager() 
        {
            PopulateFlights();
        }

        public FlightManager(string code, string airline, string fromairport, string toairport, string day, string time, int count, double cost)
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
        public void PopulateFlights()
        {
            foreach (string line in System.IO.File.ReadLines(flight_csv))
            {
                string[] fields = line.Split(',');
                string code = fields[0];
                string airline = fields[1];
                string fromairport = fields[2];
                string toairport = fields[3];
                string day = fields[4];
                string time = fields[5];
                int count = int.Parse(fields[6]);
                double cost = double.Parse(fields[7]);

                flightlist.Add(new FlightManager(code, airline, fromairport, toairport, day, time, count, cost));

            }
        }

        public static void WriteFlightsIntoFile()
        {
            List<string> FlightListStrings = new List<string>();
            foreach (Flight f in flightlist)
            {
                FlightListStrings.Add(f.ToString());
            }
            File.WriteAllLines("C:\\Users\\soria\\OneDrive\\Documents\\OOP2\\main airport\\MauiApp1\\MauiApp1\\Resources\\text\\flights (1).csv", FlightListStrings);
        }

        public static List<FlightManager> GetFlights()
        {
            return flightlist;
        }

        public static List<Flight> matchingFlights = new List<Flight>();

        public static List<Flight> GetMatchingFlights()
        {
            return matchingFlights;
        }


    public static List<Flight> reservationPick = new List<Flight>();

        public static List<Flight> GetReservationText()
        {
            return reservationPick;
        }

        public static List<Flight> reservation = new List<Flight>();

        public static List<Flight> flighreservation()
        {
            return reservation;
        }

    }
}
