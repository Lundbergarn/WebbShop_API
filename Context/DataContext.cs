using System;
using Microsoft.EntityFrameworkCore;
using WebbShop_API.Models;

namespace WebbShop_API.Contexts
{
  public class DataContext : DbContext
  {

    // public DbSet<Admin> Admins { get; set; }
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


    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
      using (var hmac = new System.Security.Cryptography.HMACSHA512()) //HMAC uses hash based message
      {
        passwordSalt = hmac.Key; /// setting password salt to the randomly generated key
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // gets password as a byte array
      }

    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      byte[] passwordHash, passwordSalt;
      CreatePasswordHash("password", out passwordHash, out passwordSalt);

      // modelBuilder.Entity<Admin>().HasData(new Admin
      // {
      //   Id = 11111,
      //   UserName = "admins",
      //   Role = "Admin",
      //   PasswordHash = passwordHash,
      //   PasswordSalt = passwordSalt
      // });

      modelBuilder.Entity<Customer>().HasData(new Customer
      {
        Id = 1,
        Email = "lundbergarn2@hotmail.com",
        UserName = "lundberg",
        FirstName = "Christoffer",
        LastName = "Lundberg",
        Phone = "9739874",
        Address = "vattholvaägen 5c",
        Role = "Customer",
        PasswordHash = passwordHash,
        PasswordSalt = passwordSalt
      });
      modelBuilder.Entity<Customer>().HasData(new Customer
      {
        Id = 2,
        Email = "sara@hotmail.com",
        UserName = "sara",
        FirstName = "Sara",
        LastName = "Larsson",
        Phone = "9739874",
        Address = "vattholvaägen 5c",
        Role = "Customer",
        PasswordHash = passwordHash,
        PasswordSalt = passwordSalt
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

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 114,
        Name = "Nike Air Zoom Pegasus 36",
        Brand = "Nike",
        Price = 799,
        Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_110_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png"
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 115,
        Name = "Nike Air Zoom Pegasus 36",
        Brand = "Nike",
        Price = 1299,
        Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_108_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png"
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 116,
        Name = "M Senseboost Go",
        Brand = "Adidas",
        Price = 899,
        Product_Description = "Senseboost Go är bekväma löparskor för ett neutralt löpsteg. Designade med stretchig stickad ovandel som andas och som formar sig efter fotens rörelser när du springer. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget. Skorna har en tajt passform och är konstruerade med ett särskilt stöd över mellanfoten, samt har en bred plattform som ger extra stöd vid sidoförflyttningar. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284541_101_ADIDAS_M%20SENSEBOOST%20GO.png"
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 117,
        Name = "M Ultraboost 19",
        Brand = "Adidas",
        Price = 1799,
        Product_Description = "Ultraboost 19 är löparskor för ett neutralt löpsteg. Skorna har en stretchig stickad ovandel som formar sig efter foten och som har få sömmar för att minimera risken för skav. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget, samt en formgjuten hälkopp som ger en naturlig passform och optimal rörelse vid hälen. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons, och är gjord i Continental-gummi som ger bra grepp på både vått och torrt underlag. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284351_105_ADIDAS_M%20ULTRABOOST%2019.png"
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 118,
        Name = "Nike Air Zoom Pegasus 36",
        Brand = "Nike",
        Price = 1399,
        Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_111_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png"
      });

      modelBuilder.Entity<Shoe>().HasData(new Shoe
      {
        Id = 119,
        Name = "M Roadhawk Ff 2 Shine",
        Brand = "ASICS",
        Price = 849,
        Product_Description = "Lätta löparskor för ett neutralt löpsteg. Shine-versionen av Roadhawk FF 2 är utrustad med extra många reflekterande detaljer för att du ska synas bättre under löprundor i mörker. Skorna är även försedda med Asics nya mellansula FlyteFoam Propel som ger responsiv stötdämpning för extra skjuts i steget. Modellen har också sömlös och ventilerande ovandel som formar sig efter foten för bra komfort och stabil passform. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget.",
        Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284454_101_ASICS_M%20ROADHAWK%20FF%202%20SHINE.png"
      });
    }
  }
}