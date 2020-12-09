using System;

namespace Mersy.Common.Models
{
    public class TicketImage
    {
        public long Id { get; set; }

        //[Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //  [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsalezulu.azurewebsites.net/images/noimage.png"
            : $"https://onsale.blob.core.windows.net/products/{ImageId}";
    }
}
