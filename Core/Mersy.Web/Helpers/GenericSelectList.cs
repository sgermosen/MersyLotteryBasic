namespace Mersy.Web.Helpers
{
    using Mersy.Infraestructure;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GenericSelectListx : IGenericSelectList
    {

        private readonly ApplicationDbContext _context;

        public GenericSelectListx(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> CreateSelectList<T>(IList<T> entities, Func<T, object> funcToGetValue, Func<T, object> funcToGetText)
        {
            var r = new List<SelectListItem> { new SelectListItem { Value = "0", Text = "_Seleccione Una Opción" } };
            if (entities.Count > 0)
            {
                r.AddRange(entities
                 .Select(x => new SelectListItem
                 {
                     Value = funcToGetValue(x).ToString(),
                     Text = funcToGetText(x).ToString()
                 }).OrderBy(p => p.Text));

            }
            else
            {
                r = new List<SelectListItem> { new SelectListItem { Value = "0", Text = "Sin Registros, Porfavor Cree Algunos" } };

            }

            return r;
        }
        public IEnumerable<SelectListItem> CreateSelectListWithNoChoose<T>(IList<T> entities, Func<T, object> funcToGetValue, Func<T, object> funcToGetText)
        {
            var r = new List<SelectListItem>();

            if (entities.Count > 0)
            {
                r.AddRange(entities
                 .Select(x => new SelectListItem
                 {
                     Value = funcToGetValue(x).ToString(),
                     Text = funcToGetText(x).ToString()
                 }).OrderBy(p => p.Text));

            }
            else
            {
                r = new List<SelectListItem> { new SelectListItem { Value = "0", Text = "Sin Registros, Porfavor Cree Algunos" } };


            }
            return r;
        }

        public IEnumerable<SelectListItem> GetSelectLotteries()
        {
            List<SelectListItem> list = _context.Lotteries.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = $"{t.Id}"
            })
            .OrderBy(t => t.Text)
            .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select a lottery...]",
                Value = "0"
            });

            return list;
        }
    }
}
