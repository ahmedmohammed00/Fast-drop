using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Zone
    {
        public int ZoneId { get; set; }

        public string Name { get; set; }

        public string? City { get; set; }

        public string? GeojsonBoundary { get; set; }

        public decimal? DeliveryFee { get; set; }

        public bool ActiveStatus { get; set; }

        public ICollection<Address>? Addresses { get; set; }

        public ICollection<Driver>? Drivers { get; set; }

        public ICollection<DemandForecast>? DemandForecasts { get; set; }
    }
}
