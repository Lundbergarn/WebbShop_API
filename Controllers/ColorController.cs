using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ColorController : ControllerBase
  {
    private readonly IColorRepository _repo;

    public ColorController(IColorRepository repo)
    {
      _repo = repo;
    }

    // Get api/shoe
    [HttpGet]
    public async Task<IActionResult> GetColors()
    {
      var colors = await _repo.GetColors();
      // HTTP 200 response Ok
      return Ok(colors);
    }

    // GET api/shoe/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetColor(int id)
    {
      var color = await _repo.GetColor(id);

      if (color == null)
      {
        return NotFound();
      }

      return Ok(color);
    }

  }
}
