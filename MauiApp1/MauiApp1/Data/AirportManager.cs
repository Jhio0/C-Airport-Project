using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    internal class AirportManager : Airport
    {
        public static List<AirportManager> airports = new List<AirportManager>();
        private const string airport_csv = "C:\\Users\\soria\\OneDrive\\Documents\\OOP2\\main airport\\MauiApp1\\MauiApp1\\Resources\\text\\airports.csv";

        public AirportManager()
        {
            PopulateAirport();
        }
        public AirportManager(string code, string name) : base(code, name)
        { }
        
        public void PopulateAirport()
        {
            foreach (string line in System.IO.File.ReadLines(airport_csv))
            {
                string[] fields = line.Split(',');
                string airportcode = fields[0];
                string airportname = fields[1];
                airports.Add(new AirportManager(airportcode, airportname));
            }
        }

        public static List<AirportManager> GetAirports() 
        {
            return airports; 
        }
    }
}
