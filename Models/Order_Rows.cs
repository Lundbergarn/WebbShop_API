using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Order_Rows
  {
    public int Id { get; set; }
    public int Qty { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public Order Order { get; set; }
  }
}