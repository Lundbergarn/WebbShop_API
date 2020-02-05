using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Contexts;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public class ColorRepository : IColorRepository
  {
    private readonly DataContext _context;
    public ColorRepository(DataContext context)
    {
      this._context = context;
    }

    public async Task<Color> GetColor(int id)
    {
      Color color = await _context.Colors
        .FirstOrDefaultAsync(b => b.Id == id);

      return color;
    }
    public async Task<List<Color>> GetColors()
    {
      List<Color> colors = await _context.Colors
        .ToListAsync();

      return colors;
    }


    public async Task<bool> SaveAll()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}