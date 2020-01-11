using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;

namespace WebbShop_API.Controllers
{
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