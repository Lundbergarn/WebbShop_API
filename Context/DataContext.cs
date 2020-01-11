using System;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Models;

namespace WebbShop_API.Contexts
{
  public class DataContext : DbContext
  {

    public DbSet<Admin> Admins { get; set; }
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
        First_Name = "Christoffer",
        Last_Name = "Lundberg",
        Phone = "9739874",
        Address = "vattholvaägen 5c"
      });
      modelBuilder.Entity<Customer>().HasData(new Customer
      {
        Id = 2,
        Email = "sara@hotmail.com",
        Password = "password",
        First_Name = "Sara",
        Last_Name = "Larsson",
        Phone = "9739874",
        Address = "vattholvaägen 5c"
      });

      modelBuilder.Entity<Order>().HasData(new Order
      {
        Id = 1,
        Order_Date = DateTime.Now,
        CustomerId = 1,
      });
      modelBuilder.Entity<Order>().HasData(new Order
      {
        Id = 2,
        Order_Date = DateTime.Now,
        CustomerId = 2,
      });

      // Order Row 1
      modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      {
        Id = 1,
        Qty = 1,
        ShoeId = 111,
        OrderId = 1
      });
      // Order Row 2
      modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      {
        Id = 2,
        Qty = 1,
        ShoeId = 111,
        OrderId = 2
      });


      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 111,
        Name = "Silver Deluxe",
        Brand = "Nike",
        Price = 100,
        Product_Description = "Lorem Ipsum Dolar",
        Image_Url = "Image URL",
      });


      // Order Row 2
      // modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      // {
      //   Id = 2,
      //   Qty = 1,
      //   ShoeId = 222,
      //   OrderId = 1,
      // });
      // modelBuilder.Entity<Shoe>().HasData(new Shoe
      // {
      //   Id = 222,
      //   Image = "Image URL",
      //   Name = "Black panter",
      //   Brand = "Puma",
      //   Price = 112,
      //   Product_Description = "Lite text om skon",
      //   Order_RowsId = 2
      // });
      // modelBuilder.Entity<Color>().HasData(new Color
      // {
      //   Id = 2,
      //   Order_RowsId = 2,
      //   Color_Description = "Black"
      // });
      // modelBuilder.Entity<Size>().HasData(new Size
      // {
      //   Id = 2,
      //   Order_RowsId = 2,
      //   Size_Description = 38
      // });

      // modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      // {
      //   Id = 3,
      //   Qty = 2,
      //   ShoeId = 333,
      //   OrderId = 1,
      // });
      // modelBuilder.Entity<Shoe>().HasData(new Shoe
      // {
      //   Id = 333,
      //   Image = "Image URL",
      //   Name = "Golden Shoe",
      //   Brand = "Adidas",
      //   Price = 199,
      //   Product_Description = "Lorem Ipsum Dolar",
      //   Order_RowsId = 3
      // });


    }

  }
}