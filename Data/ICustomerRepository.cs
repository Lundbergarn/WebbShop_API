using System.Collections.Generic;
using System.Threading.Tasks;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public interface ICustomerRepository
  {
    T Add<T>(T entity) where T : class;
    T Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    Task<bool> SaveAll();
    Task<Customer> GetCustomer(string name);
  }
}