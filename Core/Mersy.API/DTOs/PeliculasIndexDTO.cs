using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.DTOs
{
    public class LotterySalesIndexDTO
    {
        public List<LotterySaleDTO> Premiados { get; set; }
        public List<LotterySaleDTO> DelDia { get; set; }
    }
}
