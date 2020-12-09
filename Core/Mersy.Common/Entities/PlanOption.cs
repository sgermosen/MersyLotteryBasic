using Mersy.Common.Helpers;

namespace Mersy.Common.Entities
{
    public class PlanOption : BaseEntity
    {
        public long PlanId { get; set; }
        public Plan Plan { get; set; }

        public long OptionId { get; set; }
        public Option Option { get; set; }

    }
}
