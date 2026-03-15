using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Route
    {
        public int RouteId { get; set; }

        public string? RouteName { get; set; }

        public string Status { get; set; } = "active";

        public ICollection<RouteStop>? RouteStops { get; set; }

        public ICollection<DriverRoute>? DriverRoutes { get; set; }

        public ICollection<Shipment>? Shipments { get; set; }
    }
}
