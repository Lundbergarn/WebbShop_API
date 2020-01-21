using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Contexts;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public class SizeRepository : ISizeRepository
  {
    private readonly DataContext _context;
    public SizeRepository(DataContext context)
    {
      this._context = context;
    }

    public async Task<Size> GetSize(int id)
    {
      var size = await _context.Sizes
        .FirstOrDefaultAsync(b => b.Id == id);

      return size;
    }
    public async Task<List<Size>> GetSizes()
    {
      var sizes = await _context.Sizes
        .ToListAsync();

      return sizes;
    }


    public async Task<bool> SaveAll()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}