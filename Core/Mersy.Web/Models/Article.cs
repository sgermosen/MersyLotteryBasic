using System;
using Mersy.Common.Models;

namespace Mersy.Web.Models
{
    public class Article : LotterySaleView
    {
        public string articleHeading { get; set; }
        public string articleContent { get; set; }
        public string userId { get; set; }
    }
}
