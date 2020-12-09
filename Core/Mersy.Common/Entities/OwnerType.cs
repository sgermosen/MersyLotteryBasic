using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mersy.Common.Entities
{
    public class OwnerType : BaseEntity
    {
        public ICollection<Owner> Owners { get; set; }

        public OwnerType()
        {
            Owners = new Collection<Owner>();
        }
    }
}
