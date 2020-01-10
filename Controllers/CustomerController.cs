using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CustomerController : ControllerBase
  {
    private readonly ICustomerRepository _repo;

    public CustomerController(ICustomerRepository repo)
    {
      _repo = repo;
    }

    // GET api/blogs/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomer(int id)
    {
      var blog = await _repo.GetCustomer(id);

      if (blog == null)
      {
        return NotFound();
      }

      return Ok(blog);
    }

    // POST api/blogs
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Customer newBlog)
    {
      _repo.Add(newBlog);

      var response = await _repo.SaveAll();

      if (response)
      {
        return Created("/customer", newBlog);
      }

      return NotFound();
    }

    // DELETE api/blogs/4
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      Customer blogToRemove = await _repo.GetCustomer(id);

      if (blogToRemove == null)
      {
        return NotFound();
      }

      _repo.Delete(blogToRemove);

      var response = await _repo.SaveAll();

      if (response)
      {
        return Ok("Removed blog " + blogToRemove.Name);
      }

      return NotFound();
    }

  }
}
