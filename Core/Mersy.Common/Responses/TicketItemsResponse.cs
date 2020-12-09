namespace Mersy.Common.Responses
{
    public class TicketItemResponse
    {
        public long Id { get; set; }

        public long LotterySaleId { get; set; }
        public TicketResponse Ticket { get; set; }

        public long LotteryModeId { get; set; }
        public LotteryModeResponse Mode { get; set; }

        public long LotteryId { get; set; }
        public LotteryResponse Lottery { get; set; }

        public decimal PlayedAmount { get; set; }
        public string PlayedNumbers { get; set; }
        public string Played1 { get; set; }
        public string Played2 { get; set; }
        public string Played3 { get; set; }
        public decimal Prize { get; set; }
    }
}