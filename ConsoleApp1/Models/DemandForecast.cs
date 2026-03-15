using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class DemandForecast
    {
        public int ForecastId { get; set; }

        public int? ZoneId { get; set; }

        public int? ForecastedVolume { get; set; }

        public bool? PeakPrediction { get; set; }

        public DateTime ForecastDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public Zone? Zone { get; set; }
    }
}
