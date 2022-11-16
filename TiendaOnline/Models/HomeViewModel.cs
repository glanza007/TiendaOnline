using TiendaOnline.Common;
using TiendaOnline.Data.Entities;

namespace TiendaOnline.Models
{
    public class HomeViewModel
    {
        public PaginatedList<Product> Products { get; set; }

        public ICollection<Category> Categories { get; set; }

        public float Quantity { get; set; }
    }
}
