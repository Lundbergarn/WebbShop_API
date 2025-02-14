using Microsoft.AspNetCore.Identity;

namespace WebbShop_API.Models
{
  public class Admin
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Role { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
  }
}