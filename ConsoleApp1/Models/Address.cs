using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string? District { get; set; }

        public string? Street { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public int? ZoneId { get; set; }

        public Zone? Zone { get; set; }

        public ICollection<Merchant>? Merchants { get; set; }

        public ICollection<Warehouse>? Warehouses { get; set; }

        public ICollection<RouteStop>? RouteStops { get; set; }
    }
}
