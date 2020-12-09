using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mersy.Common.Entities
{
    public class LotteryMode : BaseEntity
    {
        //        Borlette
        //Mariage
        //Loto 3	
        //Loto 4	
        //Loto 5	
        //Loto 6
        //quiniela
        //pale
        //tripleta
        public string Code { get; set; }
        public int PlayableNumber { get; set; }

        public int AwardedNumber { get; set; }

        // public ICollection<LotteryAvailable> LotteryAvailables { get; set; }
        // public ICollection<LotteryPrize> LotteryPrizes { get; set; }

        public ICollection<LotterySaleItem> LotterySaleItems { get; set; }

        public LotteryMode()
        {
            LotterySaleItems = new Collection<LotterySaleItem>();
            //  LotteryPrizes = new Collection<LotteryPrize>();
            // LotteryAvailables = new Collection<LotteryAvailable>();
        }
    }
}
