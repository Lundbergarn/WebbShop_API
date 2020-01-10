using System;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Models;

namespace WebbShop_API.Contexts
{
  public class DataContext : DbContext
  {

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order_Rows> Order_Rows { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Value> Values { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    //  => options.UseSqlite("Data Source=myblogdb.db");
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Customer>().HasData(new Customer
      {
        Id = 1,
        Email = "lundbergarn2@hotmail.com",
        Password = "password",
        Name = "Christoffer Lundberg",
        Phone = "9739874",
        Address = "vattholvaägen 5c"
      });

      modelBuilder.Entity<Order>().HasData(new Order
      {
        Id = 1,
        Order_Date = new DateTime(),
        CustomerId = 1,
      });

      modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      {
        Id = 1,
        Qty = 2,
        OrderId = 1,
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 1,
        Brand = "Nike",
      });
    }

  }
}