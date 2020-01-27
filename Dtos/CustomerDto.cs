using System.Collections.Generic;
using WebbShop_API.Models;

namespace WebbShop_API.Dtos
{
  public class CustomerDto
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public List<Order> Order { get; set; }
    public string Role { get; set; }

  }
}


