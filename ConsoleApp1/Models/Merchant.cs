using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Merchant
    {
        public int MerchantId { get; set; }

        public string ShopName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string? ContactName { get; set; }

        public string? Phone { get; set; }

        public string Status { get; set; } = "active";

        public int? AddressId { get; set; }

        public Address? Address { get; set; }

        public ICollection<Product>? Products { get; set; }

        public ICollection<Shipment>? Shipments { get; set; }

        public ICollection<Invoice>? Invoices { get; set; }
    }
}
