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
      // Order Row 3
      modelBuilder.Entity<Order_Rows>().HasData(new Order_Rows
      {
        Id = 3,
        Qty = 1,
        ShoeId = 113,
        OrderId = 1
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 111,
        Name = "Nike Air Zoom Pegasus 36",
        Brand = "Nike",
        Price = 1299,
        Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_101_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 112,
        Name = "M Gel-Pulse 11",
        Brand = "ASICS",
        Price = 1099,
        Product_Description = "GEL-Pulse 11 från Asics är lätta löparskor för ett neutralt löpsteg. De passar för långdistanslöpning och är utformade för dig som föredrar att träna på landsväg. Skorna är designade med stötdämpande GEL i hälen för mjukare känsla, och är även försedda med Guidance Line-teknologi som hjälper foten hela vägen från hälisättning till frånskjut för en mer effektiv löpstil.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284449_101_ASICS_M%20GEL-PULSE%2011.png",
      });


      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 113,
        Name = "M Aduro 6",
        Brand = "BROKS",
        Price = 999,
        Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med BioMoGo DNA-dämpning som anpassar sig efter din hastighet och vikt för maximal effekt. De har också Segmented Crash Pad som ger ytterligare stötdämpning och en jämnare övergång från häl till tå. Skorna är även utrustade med stödjande ovandel i ventilerande mesh samt med flexibelt framfotsparti och med reflexdetaljer för ökad synlighet.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/276629_101_BROOKS_M%20ADURO%206.png"
      });
    }
  }
}