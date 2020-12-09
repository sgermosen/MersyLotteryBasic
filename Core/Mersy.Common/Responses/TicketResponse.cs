using System;
using System.Collections.Generic;

namespace Mersy.Common.Responses
{
    public class TicketResponse
    {
        public string Ticket { get; set; }

        public string Barcode { get; set; }

        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        public decimal Prize { get; set; }

        public int SeqByOwner { get; set; }

        public int SeqByShop { get; set; }

        public long CashierDetailId { get; set; }

        public ICollection<TicketItemResponse> Plays { get; set; }

        public string Remarks { get; set; }

        public bool WasPaid { get; set; }

        public bool Anulated { get; set; }
        public bool Winner { get; set; }

        public long PaymentTypeId { get; set; }

        public long ParentId { get; set; }


    }
}
