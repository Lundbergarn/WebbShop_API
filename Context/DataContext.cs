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
      modelBuilder.Entity<Customer>().HasData(new Customer
      {
        Id = 2,
        Email = "sara@hotmail.com",
        Password = "password",
        Name = "Sara Larsson",
        Phone = "9739874",
        Address = "vattholvaägen 5c"
      });

      modelBuilder.Entity<Order>().HasData(new Order
      {
        Id = 1,
        Order_Date = new DateTime(),
        CustomerId = 1,
      });

      // Order Row 1
      modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      {
        Id = 1,
        Qty = 2,
        OrderId = 1,
      });
      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 1,
        Image = "Image URL",
        Name = "Silver Deluxe",
        Order_RowsId = 1,
        Price = 112,
        Product_Description = "LIte text om skon",
      });
      modelBuilder.Entity<Color>().HasData(new Color
      {
        Id = 1,
        Order_RowsId = 1,
        Color_Description = "White"
      });
      modelBuilder.Entity<Size>().HasData(new Size
      {
        Id = 1,
        Order_RowsId = 1,
        Size_Description = 43
      });
      modelBuilder.Entity<Brand>().HasData(new Brand
      {
        Id = 1,
        ShoeId = 1,
        Name = "Nike"
      });

      // Order Row 2
      modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      {
        Id = 2,
        Qty = 1,
        OrderId = 1,
      });
      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 2,
        Image = "Image URL",
        Name = "Black panter",
        Order_RowsId = 2,
        Price = 112,
        Product_Description = "LIte text om skon",
      });
      modelBuilder.Entity<Color>().HasData(new Color
      {
        Id = 2,
        Order_RowsId = 2,
        Color_Description = "Black"
      });
      modelBuilder.Entity<Size>().HasData(new Size
      {
        Id = 2,
        Order_RowsId = 2,
        Size_Description = 38
      });
      modelBuilder.Entity<Brand>().HasData(new Brand
      {
        Id = 2,
        ShoeId = 2,
        Name = "Puma"
      });

    }

  }
}