using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Color
  {
    public int Id { get; set; }
    public string Color_Description { get; set; }
    public int Order_RowsId { get; set; }
    [JsonIgnore]
    public Order_Rows Order_Rows { get; set; }

  }
}