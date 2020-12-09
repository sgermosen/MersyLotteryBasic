using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Models
{
    public class Notification
    {
        [NotMapped]
        public string Icon { get; set; }
        [NotMapped]
        public long ElementId { get; set; }
        [NotMapped]
        public string Title { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public string Action { get; set; }
        [NotMapped]
        public string Controller { get; set; }
        [NotMapped]
        public string Area { get; set; }
        [NotMapped]
        public bool SeeIt { get; set; }
    }
}
