using WebbShop_API.Models;
using Microsoft.EntityFrameworkCore;

namespace WebbShop_API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    // Values represent tablename in DB

    public DbSet<Admin> Admin { get; set; }
    public DbSet<Brand> Brand { get; set; }
    public DbSet<Color> Color { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order_Rows> Order_Rows { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Shoe> Shoe { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Value> Values { get; set; }

  }
}