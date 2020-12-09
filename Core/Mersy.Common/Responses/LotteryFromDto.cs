using System.Collections.Generic;

namespace Mersy.Common.Responses
{
    public class LotteryFromResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<LotteryResponse> Lotteries { get; set; }

    }
}
