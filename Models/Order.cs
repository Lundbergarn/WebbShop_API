using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Order
  {
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderRows> OrderRows { get; set; }
    public int CustomerId { get; set; }
    [JsonIgnore]
    public Customer Customer { get; set; }
  }
}