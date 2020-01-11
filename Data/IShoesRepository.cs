using System.Collections.Generic;
using System.Threading.Tasks;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public interface IShoesRepository
  {
    void Add<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    Task<bool> SaveAll();
    Task<Shoe> GetShoe(int id);
    Task<List<Shoe>> GetShoes();
  }
}