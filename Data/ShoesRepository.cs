using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Contexts;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public class ShoesRepository : IShoesRepository
  {
    private readonly DataContext _context;
    public ShoesRepository(DataContext context)
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

    public async Task<Shoe> GetShoe(int id)
    {
      Shoe shoe = await _context.Shoes
        .FirstOrDefaultAsync(b => b.Id == id);

      return shoe;
    }
    public async Task<List<Shoe>> GetShoes()
    {
      List<Shoe> shoes = await _context.Shoes
        .ToListAsync();

      return shoes;
    }

    public async Task<bool> SaveAll()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}