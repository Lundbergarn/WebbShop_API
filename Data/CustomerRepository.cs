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
    public T Add<T>(T entity) where T : class
    {
      _context.Add(entity);

      return entity;
    }

    public T Update<T>(T entity) where T : class
    {
      _context.Update(entity);

      return entity;
    }

    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }

    public async Task<Customer> GetCustomer(string name)
    {
      Customer customer = await _context.Customers
        .Include(o => o.Order)
          .ThenInclude(o => o.OrderRows)
            .ThenInclude(or => or.Shoe)
        .Include(o => o.Order)
          .ThenInclude(o => o.OrderRows)
            .ThenInclude(or => or.Color)
        .Include(o => o.Order)
          .ThenInclude(o => o.OrderRows)
            .ThenInclude(or => or.Size)
        .FirstOrDefaultAsync(b => b.UserName == name);

      return customer;
    }

    public async Task<bool> SaveAll()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}
