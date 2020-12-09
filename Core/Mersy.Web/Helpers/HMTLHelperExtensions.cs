using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Mersy.Web.Helpers
{
    public static class HtmlHelpers
    {
        public static HtmlString YesNo(this IHtmlHelper html, bool yesNo)
        {
            var text = yesNo ? "Y" : "N";
            return new HtmlString(text);
        }
        public static HtmlString TicketStatus(this IHtmlHelper html, bool isPaid, decimal prize)
        {
            if (isPaid)
                return new HtmlString("Pagado");
            if (prize > 0)
                return new HtmlString("Ganador");

            return new HtmlString("No Premiado");

        }

        //      @Html.FormatedTime(item.CreatedAt.Value) //@using Mersy.Web.Helpers
        public static string FormatedDate(this IHtmlHelper html, DateTime date)
        {
            if (date == null)
                return string.Empty;
            else
                try
                {
                    return date.ToString("dd/MM/yyyy");
                }
                catch (Exception)
                {
                    return string.Empty;
                }
        }

        //      @Html.FormatedTime(item.CreatedAt.Value) //@using Mersy.Web.Helpers
        public static string FormatedTime(this IHtmlHelper html, DateTime date)
        {
            if (date == null)
                return string.Empty;
            else
                try
                {
                    return date.ToString("hh:mm tt");
                }
                catch (Exception)
                {
                    return string.Empty;
                }
        }

        public static string isActive(this IHtmlHelper html, string controller = null, string action = null)
        {
            string activeClass = "active"; // change here if you another name to activate sidebar items
            // detect current app state
            string actualAction = (string)html.ViewContext.RouteData.Values["action"];
            string actualController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(controller))
                controller = actualController;

            if (string.IsNullOrEmpty(action))
                action = actualAction;

            return controller == actualController && action == actualAction ? activeClass : string.Empty;
        }
    }
}
