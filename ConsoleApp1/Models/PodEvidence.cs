using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class PodEvidence
    {
        public int AttemptId { get; set; }

        public string? PhotoUrl { get; set; }

        public bool OtpVerified { get; set; }

        public string? Notes { get; set; }

        public ShipmentAttempt ShipmentAttempt { get; set; }
    }
}
