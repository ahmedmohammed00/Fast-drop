using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class ShipmentProduct
    {
        public int ShipmentId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public Shipment Shipment { get; set; }

        public Product Product { get; set; }
    }
}
