using Mersy.Common.Entities;
using Mersy.Common.Models;
using System;

namespace Mersy.Web.Helpers
{
    public interface IConverterHelper
    {
        Lottery ToLottery(LotteryViewModel model, Guid imageId, bool isNew);
    }
}