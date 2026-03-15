using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        public int? ShipmentId { get; set; }

        public int? DriverId { get; set; }

        public decimal? Rating { get; set; }

        public string? Comment { get; set; }

        public DateTime CreatedAt { get; set; }

        public Shipment? Shipment { get; set; }

        public Driver? Driver { get; set; }

        public ICollection<SentimentAnalysis>? SentimentAnalyses { get; set; }
    }
}
