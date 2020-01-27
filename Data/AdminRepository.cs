using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Contexts;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public class AdminRepository : IAdminRepository
  {
    private readonly DataContext _context;
    public AdminRepository(DataContext context)
    {
      this._context = context;
    }
    public async Task<List<Order>> GetOrders()
    {
      var orders = await _context.Orders
        .Include(o => o.OrderRows)
          .ThenInclude(or => or.Shoe)
        .Include(o => o.OrderRows)
          .ThenInclude(or => or.Size)
        .ToListAsync();

      return orders;
    }
  }
}