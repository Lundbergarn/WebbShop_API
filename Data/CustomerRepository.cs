using System.Threading.Tasks;
using WebbShop_API.Models;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Contexts;

namespace WebbShop_API.Data
{
  public class CustomerRepository : ICustomerRepository
  {
    private readonly DataContext _context;
    public CustomerRepository(DataContext context)
    {
      this._context = context;
    }
    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }

    public async Task<Customer> GetCustomer(int id)
    {
      var customer = await _context.Customers
        .Include(o => o.Order)
        .ThenInclude(o => o.Order_Rows)
        .FirstOrDefaultAsync(b => b.Id == id);

      return customer;
    }

    public async Task<bool> SaveAll()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}
