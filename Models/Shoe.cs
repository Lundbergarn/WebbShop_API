using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebbShop_API.Models
{
  public class Shoe
  {
    public int Id { get; set; }
    // [Required]
    public string Name { get; set; }
    public string Brand { get; set; }
    // [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string Product_Description { get; set; }
    public string Image_Url { get; set; }
  }
}