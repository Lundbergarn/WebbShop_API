using System.Threading.Tasks;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public interface IAuthRepository
  {
    Task<Customer> Register(Customer customer, string password); //user register returns user

    Task<Customer> Login(string username, string password); //user login returns user

    Task<bool> UserExists(string username); //checking if user exists returns boolean true or false

  }
}