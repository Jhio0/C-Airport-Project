using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    internal abstract class Airport
    {
        public string cityCode { get; set; }
        public string AirportName { get; set; }

        public Airport(string code, string name)
        {
            cityCode = code;
            AirportName = name;
        }   

        public Airport() { }
    }

}
