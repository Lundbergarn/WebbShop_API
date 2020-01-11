using System.Collections.Generic;

namespace WebbShop_API.Models
{
  public class Customer
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public List<Order> Order { get; set; }

  }
}