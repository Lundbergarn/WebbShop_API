using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Size
  {
    public int Id { get; set; }
    [Column(TypeName = "decimal(4, 1)")]
    public decimal Size_Description { get; set; }

  }
}