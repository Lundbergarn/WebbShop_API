using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Shoe
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public string Product_Description { get; set; }
    public string Image { get; set; }
    public int Order_RowsId { get; set; }
    [JsonIgnore]
    public Order_Rows Order_Rows { get; set; }
  }
}