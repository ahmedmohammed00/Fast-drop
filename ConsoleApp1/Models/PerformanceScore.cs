using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class PerformanceScore
    {
        public int PerfId { get; set; }

        public int? DriverId { get; set; }

        public decimal? DailyScore { get; set; }

        public string? Tier { get; set; }

        public decimal? WeightedHistory { get; set; }

        public DateTime RecordedAt { get; set; }

        public Driver? Driver { get; set; }
    }
}
