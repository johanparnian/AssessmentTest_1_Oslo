using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ConsoleApp
{
    public class Burrow
    {
        public double Longitude { get; set; }
        public double Latitude{ get; set; }

        public Burrow(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
