using System.Collections.Generic;
using System.Threading.Tasks;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public interface IColorRepository
  {
    Task<bool> SaveAll();
    Task<Color> GetColor(int id);
    Task<List<Color>> GetColors();
  }
}