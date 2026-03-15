using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }

        public DateTime CreationDate { get; set; }

        public decimal CodAmount { get; set; }

        public decimal? WeightKg { get; set; }

        public int? WarehouseId { get; set; }

        public int? MerchantId { get; set; }

        public int? RouteId { get; set; }

        public int? AddressId { get; set; }

        public Warehouse? Warehouse { get; set; }

        public Merchant? Merchant { get; set; }

        public Route? Route { get; set; }

        public Address? Address { get; set; }

        public ICollection<ShipmentStatus>? ShipmentStatuses { get; set; }

        public ICollection<ShipmentProduct>? ShipmentProducts { get; set; }

        public ICollection<ShipmentAttempt>? ShipmentAttempts { get; set; }
    }
}
