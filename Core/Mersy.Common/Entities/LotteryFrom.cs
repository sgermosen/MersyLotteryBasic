using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mersy.Common.Entities
{
    public class LotteryFrom : BaseEntity
    {
        public ICollection<Lottery> Lotteries { get; set; }

        public LotteryFrom()
        {
            Lotteries = new Collection<Lottery>();
        }
    }
}
