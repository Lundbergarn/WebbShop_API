using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoeController : ControllerBase
  {
    private readonly IShoesRepository _repo;

    public ShoeController(IShoesRepository repo)
    {
      _repo = repo;
    }

    // Get api/shoe
    [HttpGet]
    public async Task<IActionResult> GetShoes()
    {
      var values = await _repo.GetShoes();
      // HTTP 200 response Ok
      return Ok(values);
    }

    // GET api/shoe/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetShoe(int id)
    {
      var shoe = await _repo.GetShoe(id);

      if (shoe == null)
      {
        return NotFound();
      }

      return Ok(shoe);
    }


    // POST api/shoe
    [HttpPost]
    public async Task<IActionResult> PostShoe([FromBody] Customer newShoe)
    {
      _repo.Add(newShoe);

      var response = await _repo.SaveAll();

      if (response)
      {
        return Created("/shoe", newShoe);
      }

      return NotFound();
    }

    // DELETE api/shoe/4
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      Shoe shoeToRemove = await _repo.GetShoe(id);

      if (shoeToRemove == null)
      {
        return NotFound();
      }

      _repo.Delete(shoeToRemove);

      var response = await _repo.SaveAll();

      if (response)
      {
        return Ok("Removed shoe " + shoeToRemove.Name);
      }

      return NotFound();
    }

  }
}
