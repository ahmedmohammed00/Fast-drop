using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class ShipmentStatus
    {
        public int StatusId { get; set; }

        public int ShipmentId { get; set; }

        public string Status { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Shipment Shipment { get; set; }
    }
}
