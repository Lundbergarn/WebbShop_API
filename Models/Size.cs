using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Size
  {
    public int Id { get; set; }
    [Column(TypeName = "decimal(4, 1)")]
    public decimal Size_Description { get; set; }
    public int Order_RowsId { get; set; }
    [JsonIgnore]
    public Order_Rows Order_Rows { get; set; }
  }
}