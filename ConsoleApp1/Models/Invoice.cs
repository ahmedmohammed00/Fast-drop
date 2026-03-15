using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public int? ShipmentId { get; set; }

        public int? MerchantId { get; set; }

        public decimal AmountDue { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime? PeriodStart { get; set; }

        public DateTime? PeriodEnd { get; set; }

        public Shipment? Shipment { get; set; }

        public Merchant? Merchant { get; set; }
    }
}
