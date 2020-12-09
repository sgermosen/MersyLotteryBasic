using Mersy.Common.Entities;
using System;

namespace Mersy.Common.Models
{
    public class ResultsViewModel
    {
        public DateTime Date { get; set; }

        public Lottery Bo { get; set; }

        public Lottery Ns { get; set; }

        public Lottery Ln { get; set; }

        public string Bo1 { get; set; }
        public string Bo2 { get; set; }
        public string Bo3 { get; set; }

        public string Ns1 { get; set; }
        public string Ns2 { get; set; }
        public string Ns3 { get; set; }

        public string Ln1 { get; set; }
        public string Ln2 { get; set; }
        public string Ln3 { get; set; }

        public string Indicator { get; set; }

    }
}
