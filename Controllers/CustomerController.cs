using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebbShop_API.Data;
using WebbShop_API.Dtos;
using WebbShop_API.Models;

namespace WebbShop_API.Controllers
{
  [Authorize(Policy = "RequireCustomerRole")]
  [Route("api/[controller]")]
  [ApiController]
  public class CustomerController : ControllerBase
  {
    private readonly ICustomerRepository _repo;
    private readonly IMapper _mapper;

    public CustomerController(ICustomerRepository repo, IMapper mapper)
    {
      this._mapper = mapper;
      _repo = repo;
    }

    // GET api/customer
    [HttpGet]
    public async Task<IActionResult> GetCustomer()
    {
      string customerName = HttpContext.User.Identity.Name;

      var customer = await _repo.GetCustomer(customerName);

      // Mapp into
      var customerToReturn = _mapper.Map<CustomerDto>(customer);

      if (customer == null)
      {
        return NotFound();
      }

      return Ok(customerToReturn);
    }

    // POST api/customer
    [HttpPost]
    public async Task<IActionResult> PostOrderRow([FromBody] Order order)
    {
      string customerName = HttpContext.User.Identity.Name;

      var customer = await _repo.GetCustomer(customerName);

      // Add the right CustomerID to Order
      order.CustomerId = customer.Id;
      order.OrderDate = DateTime.Now;

      var OrderRes = _repo.Add(order);

      foreach (OrderRows row in order.OrderRows)
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

    // Put api/customer/id
    [HttpPut]
    public async Task<IActionResult> PostCustomerData([FromBody] Customer customerData)
    {
      string customerName = HttpContext.User.Identity.Name;

      // Find customer
      var customer = await _repo.GetCustomer(customerName);

      // Add data to customer
      customer.FirstName = customerData.FirstName;
      customer.LastName = customerData.LastName;
      customer.Phone = customerData.Phone;
      customer.Address = customerData.Address;

      // Add customer
      _repo.Update(customer);

      var response = await _repo.SaveAll();

      if (response)
      {
        return Created("/customer", customer);
      }

      return NotFound();
    }

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
