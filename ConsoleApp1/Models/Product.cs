using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int? MerchantId { get; set; }

        public Merchant? Merchant { get; set; }

        public ICollection<ProductWarehouse>? ProductWarehouses { get; set; }

        public ICollection<ShipmentProduct>? ShipmentProducts { get; set; }
    }
}
