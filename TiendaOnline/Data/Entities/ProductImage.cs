using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TiendaOnline.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        [Display(Name = "Foto")]
        public string ImageUrl { get; set; }
        //TODO: Pending to change to the correct path
        [Display(Name = "Foto")]
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
        ? $"https://localhost:7290/images/noimage.png"
        : $"https://localhost:7290/{ImageUrl.Substring(1)}";
        //: $"https://shopping4.blob.core.windows.net/products/{ImageId}";
    }
}
