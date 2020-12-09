using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mersy.Common.Entities
{
    public class Currency : BaseEntity
    {
        public string Code { get; set; }
        public ICollection<Plan> Plans { get; set; }
       
        public Currency()
        {
            Plans = new Collection<Plan>(); 
        }
    }
}
