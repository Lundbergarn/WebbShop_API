using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Order
  {
    public int Id { get; set; }
    public DateTime Order_Date { get; set; }
    public List<Order_Rows> Order_Rows { get; set; }
    public int CustomerId { get; set; }
    [JsonIgnore]
    public Customer Customer { get; set; }
  }
}