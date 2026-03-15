using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class RouteStop
    {
        public int StopId { get; set; }

        public int RouteId { get; set; }

        public int AddressId { get; set; }

        public int SequenceOrder { get; set; }

        public DateTime? DeliveredAt { get; set; }

        public Route Route { get; set; }

        public Address Address { get; set; }
    }
}
