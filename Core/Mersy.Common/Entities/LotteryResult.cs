using Mersy.Common.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mersy.Common.Entities
{
    public class LotteryResult : AuditEntity, IBaseEntity
    {
        public long LotteryId { get; set; }

        public Lottery Lottery { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string FirstValue { get; set; }

        [Required]
        public string SecondValue { get; set; }

        [Required]
        public string ThirdValue { get; set; }

    }
}
