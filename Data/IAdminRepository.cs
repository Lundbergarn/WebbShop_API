using System.Collections.Generic;
using System.Threading.Tasks;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public interface IAdminRepository
  {
    Task<List<Order>> GetOrders();
  }
}