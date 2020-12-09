using System.Text;

namespace Mersy.Web.Models
{
    public class ButtonsModel
    {
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public string ButtonType { get; set; }

        public string Class { get; set; }

        public string Icon { get; set; }

        public string ToolTipText { get; set; }
        public string Text { get; set; }

        public long Id { get; set; }//Master

        public long ItemId { get; set; }//Details

        //  public long ProductId { get; set; }
        //...etc

        public string ActionParameters
        {
            get {
                var param = new StringBuilder("?");
                if (Id > 0)
                    param.Append($"id={Id}&");
                if (ItemId > 0)
                    param.Append($"itemId={ItemId}&");
                //if (ProductId != null && ProductId > 0)
                //    param.Append($"productId={ProductId}&");

                return param.ToString().Substring(0, param.Length - 1);
            }

        }

    }
}
