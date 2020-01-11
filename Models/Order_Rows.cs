using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Order_Rows
  {
    public int Id { get; set; }
    public int Qty { get; set; }
    // public int ColorId { get; set; }
    // [JsonIgnore]
    // public Color Color { get; set; }
    // public int SizeId { get; set; }
    // [JsonIgnore]
    // public Size Size { get; set; }
    public int ShoeId { get; set; }
    public Shoe Shoe { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public Order Order { get; set; }

  }
}