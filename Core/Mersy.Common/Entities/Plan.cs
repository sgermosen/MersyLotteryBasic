using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Entities
{
    public class Plan : BaseEntity
    {
        [Display(Name = "Monto")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Amount { get; set; }

        [Display(Name = "Moneda")]
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; }

        [Display(Name = "Periodicidad")]
        public long PeriodicityId { get; set; }
        public Periodicity Periodicity { get; set; }

        [Display(Name = "Mbs")]
        public int Megabytes { get; set; }

        [Display(Name = "Cantidad de Usuarios")]
        public int UserPosibility { get; set; }

        [Display(Name = "Cantidad de Registros")]
        public int RegiterCount { get; set; }

        public ICollection<OwnerPlan> OwnerPlans { get; set; }

        public ICollection<Option> Options { get; set; }

        public Plan()
        {
            Options = new Collection<Option>();
            OwnerPlans = new Collection<OwnerPlan>();
        }
    }
}
