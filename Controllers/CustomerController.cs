using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  [Authorize(Policy = "RequireCustomerRole")]
  [Route("api/[controller]")]
  [ApiController]
  public class CustomerController : ControllerBase
  {
    private readonly ICustomerRepository _repo;

    public CustomerController(ICustomerRepository repo)
    {
      _repo = repo;
    }

    // GET api/customer
    [HttpGet]
    public async Task<IActionResult> GetCustomer()
    {
      string customerName = HttpContext.User.Identity.Name;

      var customer = await _repo.GetCustomer(customerName);

      if (customer == null)
      {
        return NotFound();
      }

      return Ok(customer);
    }

    // POST api/customer
    [HttpPost]
    public async Task<IActionResult> PostOrderRow([FromBody] Order order)
    {
      Console.WriteLine("Order reseived");
      string customerName = HttpContext.User.Identity.Name;

      var customer = await _repo.GetCustomer(customerName);

      // Add the right CustomerID to Order
      order.CustomerId = customer.Id;
      order.Order_Date = DateTime.Now;

      // Save order
      // Return orderID
      // Add orderID to orderRow

      var OrderRes = _repo.Add(order);

      foreach (Order_Rows row in order.Order_Rows)
      {
        row.OrderId = OrderRes.Id;
        _repo.Add(row);
      }

      var response = await _repo.SaveAll();

      if (response)
      {
        return Created("/customer", order);
      }

      return NotFound();
    }


    // POST api/customer
    // [HttpPost]
    // public async Task<IActionResult> PostCustomer([FromBody] Customer newBlog)
    // {
    //   _repo.Add(newBlog);

    //   var response = await _repo.SaveAll();

    //   if (response)
    //   {
    //     return Created("/customer", newBlog);
    //   }

    //   return NotFound();
    // }

    // DELETE api/blogs/4
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      string customerName = HttpContext.User.Identity.Name;

      Customer blogToRemove = await _repo.GetCustomer(customerName);

      if (blogToRemove == null)
      {
        return NotFound();
      }

      _repo.Delete(blogToRemove);

      var response = await _repo.SaveAll();

      if (response)
      {
        return Ok("Removed blog " + blogToRemove.FirstName);
      }

      return NotFound();
    }

  }
}
