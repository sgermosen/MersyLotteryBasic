using Mersy.Common.Helpers;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Entities
{
    public class PlanTransaction : BaseEntity
    {
        [Column(TypeName = "decimal(12,2)")]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int Megabytes { get; set; }

        public int Registers { get; set; }

        public int UserPosibility { get; set; }

        public long CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public long PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }

        public long OwnerPlanId { get; set; }
        public OwnerPlan OwnerPlan { get; set; }


    }
}
