using Mersy.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Mersy.Common.Entities
{
    public class Lottery : BaseEntity
    {

        [Required(ErrorMessage = "El Campo es requerido")]
        [Display(Name = "Codigo")]
        public string Code { get; set; }

        [Required(ErrorMessage = "El Campo es requerido")]
        public DateTime CloseHour { get; set; }

        public string ColorInHex { get; set; }

        public decimal Loto1First { get; set; }
        public decimal Loto1Second { get; set; }
        public decimal Loto1Third { get; set; }
        public decimal Loto2First { get; set; }
        public decimal Loto2Second { get; set; }
        public decimal Loto3First { get; set; }
        public decimal Loto3Second { get; set; }
        public decimal Loto4First { get; set; }

        public bool Available { get; set; }
        //  public ICollection<LotteryPrize> LotteryPrizes { get; set; }
        //  public ICollection<LotteryAvailable> LotteryAvailables { get; set; }
        public ICollection<LotterySchedule> LotterySchedules { get; set; }

        public long LotteryFromId { get; set; }

        public LotteryFrom LotteryFrom { get; set; }

        public Lottery()
        {
            //  LotteryAvailables = new Collection<LotteryAvailable>();
            //   LotteryPrizes = new Collection<LotteryPrize>();
            LotterySchedules = new Collection<LotterySchedule>();
        }
    }
}
