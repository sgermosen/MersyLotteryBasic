namespace Mersy.Common.Entities
{
    using Helpers;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class OwnerPlan : BaseEntity
    {
        public long OwnerId { get; set; }
        public Owner Owner { get; set; }

        public long PlanId { get; set; }
        public Plan Plan { get; set; }

        public ICollection<PlanTransaction> PlanTransactions { get; set; }

        public OwnerPlan()
        {
            PlanTransactions = new Collection<PlanTransaction>();
        }

    }
}
