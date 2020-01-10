using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Brand
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string URL { get; set; }
    public int ShoeId { get; set; }
    [JsonIgnore]
    public Shoe Shoe { get; set; }
  }
}