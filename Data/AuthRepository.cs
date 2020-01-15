using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Contexts;
using WebbShop_API.Data;
using WebbShop_API.Models;

namespace WebbShop_API.Data
{
  public class AuthRepository : IAuthRepository
  {
    private readonly DataContext _context;
    public AuthRepository(DataContext context)
    {
      _context = context;
    }
    public async Task<Customer> Login(string username, string password)
    {
      var user = await _context.Customers.FirstOrDefaultAsync(x => x.UserName == username); //will return matching username or null if no match

      if (username == null)
        return null;

      if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)) // returns true or false depending if password macthes
        return null;

      return user;
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
      using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) //HMAC uses hash based message
      {
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // if hashes match means password is correct
        for (int i = 0; i < computedHash.Length; i++)
        {
          if (computedHash[i] != passwordHash[i]) return false;
        }
      }
      return true;
    }

    public async Task<Customer> Register(Customer user, string password)
    {
      byte[] passwordHash, passwordSalt;
      CreatePasswordHash(password, out passwordHash, out passwordSalt); //using out to pass hash and salt as a reference and not a value

      user.PasswordHash = passwordHash;
      user.PasswordSalt = passwordSalt;
      user.Role = Role.Customer;

      await _context.Customers.AddAsync(user);
      await _context.SaveChangesAsync(); //this saves changes back to the datbase

      return user;
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
      using (var hmac = new System.Security.Cryptography.HMACSHA512()) //HMAC uses hash based message
      {
        passwordSalt = hmac.Key; /// setting password salt to the randomly generated key
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // gets password as a byte array
      }

    }

    public async Task<bool> UserExists(string username)
    {
      if (await _context.Customers.AnyAsync(x => x.UserName == username)) // compare this username against all other usernames
        return true;

      return false;
    }
  }
}