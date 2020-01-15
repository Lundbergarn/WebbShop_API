using System.Threading.Tasks;
using WebbShop_API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  // [Authorize(Policy = "RequireAdminRole")]
  // [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class AdminController : ControllerBase
  {
    private readonly IAdminRepository _repo;

    public AdminController(IAdminRepository repo)
    {
      _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
      var orders = await _repo.GetOrders();

      if (orders == null)
      {
        return NotFound();
      }

      return Ok(orders);
    }

  }
}