using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class OrderRows
  {
    public int Id { get; set; }
    public int Qty { get; set; }
    public int ColorId { get; set; }
    public Color Color { get; set; }
    public int SizeId { get; set; }
    public Size Size { get; set; }
    public int ShoeId { get; set; }
    public Shoe Shoe { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public Order Order { get; set; }

  }
}