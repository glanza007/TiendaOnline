using TiendaOnline.Common;
using TiendaOnline.Models;

namespace TiendaOnline.Helpers
{
    public interface IOrdersHelper
    {
        Task<Response> ProcessOrderAsync(ShowCartViewModel model);

        Task<Response> CancelOrderAsync(int id);
    }
}
