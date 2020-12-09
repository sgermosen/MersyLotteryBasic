using Mersy.Common.Entities;
using Mersy.Common.Models;
using Mersy.Infraestructure;
using System;

namespace Mersy.Web.Helpers
{

    public class ConverterHelper : IConverterHelper
    {
        private readonly ApplicationDbContext _context;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(ApplicationDbContext context, ICombosHelper combosHelper)
        {
            _context = context;
            _combosHelper = combosHelper;
        }

        public Lottery ToLottery(LotteryViewModel model, Guid imageId, bool isNew)
        {
            return new Lottery
            {
                Id = isNew ? 0 : model.Id,
                //  ImageId = imageId,
                Name = model.Name
            };
        }

    }
}
