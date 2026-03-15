using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class SentimentAnalysis
    {
        public int AnalysisId { get; set; }

        public int? FeedbackId { get; set; }

        public decimal? SentimentScore { get; set; }

        public string? Keywords { get; set; }

        public string? Priority { get; set; }

        public Feedback? Feedback { get; set; }
    }
}
