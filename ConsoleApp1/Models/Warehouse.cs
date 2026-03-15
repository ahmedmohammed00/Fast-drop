using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }

        public string WarehouseName { get; set; }

        public int? AddressId { get; set; }

        public Address? Address { get; set; }

        public ICollection<ProductWarehouse>? ProductWarehouses { get; set; }

        public ICollection<Shipment>? Shipments { get; set; }
    }
}
