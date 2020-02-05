using System.Threading.Tasks;
using WebbShop_API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Models;
using System.Collections.Generic;

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

    // GET api/admin
    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
      List<Order> orders = await _repo.GetOrders();

      if (orders == null)
      {
        return NotFound();
      }

      return Ok(orders);
    }

  }
}