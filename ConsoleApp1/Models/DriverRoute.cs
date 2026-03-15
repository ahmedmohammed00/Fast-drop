using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class DriverRoute
    {
        public int DriverId { get; set; }

        public int RouteId { get; set; }

        public decimal? RoutePay { get; set; }

        public Driver Driver { get; set; }

        public Route Route { get; set; }
    }
}
