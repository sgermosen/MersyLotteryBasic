using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mersy.Common.Entities
{
    public class Periodicity : BaseEntity
    {
        public string Code { get; set; }
        public ICollection<Plan> Plans { get; set; }

        public Periodicity()
        {
            Plans = new Collection<Plan>();
        }
    }
}
