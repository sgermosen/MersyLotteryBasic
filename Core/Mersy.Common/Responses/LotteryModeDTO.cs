namespace Mersy.Common.Responses
{
    public class LotteryModeResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int PlayableNumber { get; set; }

        public int AwardedNumber { get; set; }
    }
}
