using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Mersy.Web.Helpers
{
    public interface IGenericSelectList
    {
        IEnumerable<SelectListItem> CreateSelectList<T>(IList<T> entities, Func<T, object> funcToGetValue, Func<T, object> funcToGetText);
        IEnumerable<SelectListItem> CreateSelectListWithNoChoose<T>(IList<T> entities, Func<T, object> funcToGetValue, Func<T, object> funcToGetText);
        IEnumerable<SelectListItem> GetSelectLotteries();
    }
}