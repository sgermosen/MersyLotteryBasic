using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersy.Api.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Mersy.Api.DTOs
{
    public class LotterySaleDTO
    {
        public long Id { get; set; }

        public string Ticket { get; set; }

        public string Barcode { get; set; }

        public DateTime Date { get; set; }
 
        public decimal TotalAmount { get; set; }
         
        public decimal Prize { get; set; }

        public int SeqByOwner { get; set; }

        public int SeqByShop { get; set; }
  
        public string Remarks { get; set; }

        public bool WasPaid { get; set; }

        public bool Anulated { get; set; }
        public bool Winner { get; set; }
         
        public long PaymentTypeId { get; set; }
         
        public long ParentId { get; set; }

        //[ModelBinder(BinderType = typeof(TypeBinder<List<int>>))]
        //public List<long> Details { get; set; }

        [ModelBinder(BinderType = typeof(TypeBinder<List<LotterySaleItemsDTO>>))]
        public List<LotterySaleItemsDTO> LotterySaleItems { get; set; }
    }
}
