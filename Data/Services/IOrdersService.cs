using OnlineTicketsMovieManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineTicketsMovieManagement.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
 