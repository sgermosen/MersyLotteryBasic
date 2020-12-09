using System;
using System.Collections.Generic;
using Mersy.Common.Entities;
using Mersy.Common.Models;

namespace Mersy.Web.Models
{
    public class PlayViewModel
    {
        public List<LotterySaleItemView> Items { get; set; }
        public LotterySale Sale { get; set; }
        public string Lottery { get; set; }
        public string Number { get; set; }
        public string Mode { get;  set; }
    }
}
