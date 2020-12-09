using System.ComponentModel.DataAnnotations.Schema;
using Mersy.Common.Models;

namespace Mersy.Common.Helpers
{
    public interface IBaseEntity
    {
        long Id { get; set; }

        string Name { get; set; }

       // bool Deleted { get; set; }      
    }

    public class BaseEntity: Notification
    {
        public long Id { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public string UrlToReturn { get; set; }

        [NotMapped]
        public bool IsNew { get; set; }

    }
}
