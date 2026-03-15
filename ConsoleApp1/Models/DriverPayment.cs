using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class DriverPayment
    {
        public int PaymentId { get; set; }

        public int? DriverId { get; set; }

        public decimal? TotalPayout { get; set; }

        public decimal? DistanceKm { get; set; }

        public DateTime CreatedAt { get; set; }

        public Driver? Driver { get; set; }
    }
}
