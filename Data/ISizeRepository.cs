using System.Collections.Generic;
using System.Threading.Tasks;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public interface ISizeRepository
  {
    Task<bool> SaveAll();
    Task<Size> GetSize(int id);
    Task<List<Size>> GetSizes();
  }
}