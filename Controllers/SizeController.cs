using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SizeController : ControllerBase
  {
    private readonly ISizeRepository _repo;

    public SizeController(ISizeRepository repo)
    {
      _repo = repo;
    }

    // Get api/shoe
    [HttpGet]
    public async Task<IActionResult> GetSizes()
    {
      List<Size> sizes = await _repo.GetSizes();
      // HTTP 200 response Ok
      return Ok(sizes);
    }

    // GET api/shoe/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSize(int id)
    {
      Size size = await _repo.GetSize(id);

      if (size == null)
      {
        return NotFound();
      }

      return Ok(size);
    }

  }
}
