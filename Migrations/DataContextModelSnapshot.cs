﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebbShop_API.Contexts;

namespace WebbShop_API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("WebbShop_API.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color_Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("WebbShop_API.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "vattholvaägen 5c",
                            Email = "lundbergarn2@hotmail.com",
                            FirstName = "Christoffer",
                            LastName = "Lundberg",
                            PasswordHash = new byte[] { 46, 96, 15, 2, 176, 90, 63, 139, 19, 71, 121, 42, 251, 54, 49, 93, 235, 232, 255, 143, 6, 232, 172, 109, 39, 151, 247, 115, 116, 176, 71, 96, 117, 202, 84, 99, 105, 126, 12, 140, 207, 152, 105, 160, 117, 202, 99, 42, 122, 166, 105, 226, 154, 172, 30, 1, 212, 98, 58, 102, 159, 5, 214, 237 },
                            PasswordSalt = new byte[] { 199, 110, 83, 95, 26, 98, 33, 202, 147, 125, 254, 12, 231, 120, 198, 112, 136, 68, 148, 238, 99, 98, 38, 63, 154, 107, 101, 166, 119, 115, 75, 61, 163, 244, 15, 251, 28, 107, 240, 95, 150, 231, 223, 219, 100, 134, 206, 226, 148, 163, 144, 238, 49, 214, 183, 126, 120, 169, 162, 195, 176, 227, 223, 150, 10, 146, 254, 8, 153, 229, 89, 112, 196, 15, 17, 145, 230, 77, 207, 171, 47, 2, 35, 244, 151, 101, 55, 90, 251, 9, 130, 41, 35, 142, 9, 54, 86, 74, 121, 181, 120, 88, 60, 184, 105, 55, 210, 65, 13, 117, 220, 139, 190, 166, 166, 18, 228, 161, 9, 108, 170, 118, 69, 69, 96, 103, 234, 216 },
                            Phone = "9739874",
                            Role = "Customer",
                            UserName = "lundberg"
                        },
                        new
                        {
                            Id = 2,
                            Address = "vattholvaägen 5c",
                            Email = "sara@hotmail.com",
                            FirstName = "Sara",
                            LastName = "Larsson",
                            PasswordHash = new byte[] { 46, 96, 15, 2, 176, 90, 63, 139, 19, 71, 121, 42, 251, 54, 49, 93, 235, 232, 255, 143, 6, 232, 172, 109, 39, 151, 247, 115, 116, 176, 71, 96, 117, 202, 84, 99, 105, 126, 12, 140, 207, 152, 105, 160, 117, 202, 99, 42, 122, 166, 105, 226, 154, 172, 30, 1, 212, 98, 58, 102, 159, 5, 214, 237 },
                            PasswordSalt = new byte[] { 199, 110, 83, 95, 26, 98, 33, 202, 147, 125, 254, 12, 231, 120, 198, 112, 136, 68, 148, 238, 99, 98, 38, 63, 154, 107, 101, 166, 119, 115, 75, 61, 163, 244, 15, 251, 28, 107, 240, 95, 150, 231, 223, 219, 100, 134, 206, 226, 148, 163, 144, 238, 49, 214, 183, 126, 120, 169, 162, 195, 176, 227, 223, 150, 10, 146, 254, 8, 153, 229, 89, 112, 196, 15, 17, 145, 230, 77, 207, 171, 47, 2, 35, 244, 151, 101, 55, 90, 251, 9, 130, 41, 35, 142, 9, 54, 86, 74, 121, 181, 120, 88, 60, 184, 105, 55, 210, 65, 13, 117, 220, 139, 190, 166, 166, 18, 228, 161, 9, 108, 170, 118, 69, 69, 96, 103, 234, 216 },
                            Phone = "9739874",
                            Role = "Customer",
                            UserName = "sara"
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Order_Date = new DateTime(2020, 1, 14, 14, 24, 7, 706, DateTimeKind.Local).AddTicks(8721)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Order_Date = new DateTime(2020, 1, 14, 14, 24, 7, 709, DateTimeKind.Local).AddTicks(9189)
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Order_Rows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShoeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ShoeId");

                    b.ToTable("Order_Rows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            Qty = 1,
                            ShoeId = 111
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            Qty = 1,
                            ShoeId = 111
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 1,
                            Qty = 1,
                            ShoeId = 113
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Shoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image_Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Product_Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            Id = 111,
                            Brand = "Nike",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_101_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 1299m,
                            Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 112,
                            Brand = "ASICS",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284449_101_ASICS_M%20GEL-PULSE%2011.png",
                            Name = "M Gel-Pulse 11",
                            Price = 1099m,
                            Product_Description = "GEL-Pulse 11 från Asics är lätta löparskor för ett neutralt löpsteg. De passar för långdistanslöpning och är utformade för dig som föredrar att träna på landsväg. Skorna är designade med stötdämpande GEL i hälen för mjukare känsla, och är även försedda med Guidance Line-teknologi som hjälper foten hela vägen från hälisättning till frånskjut för en mer effektiv löpstil."
                        },
                        new
                        {
                            Id = 113,
                            Brand = "BROKS",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/276629_101_BROOKS_M%20ADURO%206.png",
                            Name = "M Aduro 6",
                            Price = 999m,
                            Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med BioMoGo DNA-dämpning som anpassar sig efter din hastighet och vikt för maximal effekt. De har också Segmented Crash Pad som ger ytterligare stötdämpning och en jämnare övergång från häl till tå. Skorna är även utrustade med stödjande ovandel i ventilerande mesh samt med flexibelt framfotsparti och med reflexdetaljer för ökad synlighet."
                        },
                        new
                        {
                            Id = 114,
                            Brand = "Nike",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_110_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 799m,
                            Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 115,
                            Brand = "Nike",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_108_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 1299m,
                            Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 116,
                            Brand = "Adidas",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284541_101_ADIDAS_M%20SENSEBOOST%20GO.png",
                            Name = "M Senseboost Go",
                            Price = 899m,
                            Product_Description = "Senseboost Go är bekväma löparskor för ett neutralt löpsteg. Designade med stretchig stickad ovandel som andas och som formar sig efter fotens rörelser när du springer. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget. Skorna har en tajt passform och är konstruerade med ett särskilt stöd över mellanfoten, samt har en bred plattform som ger extra stöd vid sidoförflyttningar. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons."
                        },
                        new
                        {
                            Id = 117,
                            Brand = "Adidas",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284351_105_ADIDAS_M%20ULTRABOOST%2019.png",
                            Name = "M Ultraboost 19",
                            Price = 1799m,
                            Product_Description = "Ultraboost 19 är löparskor för ett neutralt löpsteg. Skorna har en stretchig stickad ovandel som formar sig efter foten och som har få sömmar för att minimera risken för skav. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget, samt en formgjuten hälkopp som ger en naturlig passform och optimal rörelse vid hälen. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons, och är gjord i Continental-gummi som ger bra grepp på både vått och torrt underlag. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget."
                        },
                        new
                        {
                            Id = 118,
                            Brand = "Nike",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_111_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 1399m,
                            Product_Description = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 119,
                            Brand = "ASICS",
                            Image_Url = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284454_101_ASICS_M%20ROADHAWK%20FF%202%20SHINE.png",
                            Name = "M Roadhawk Ff 2 Shine",
                            Price = 849m,
                            Product_Description = "Lätta löparskor för ett neutralt löpsteg. Shine-versionen av Roadhawk FF 2 är utrustad med extra många reflekterande detaljer för att du ska synas bättre under löprundor i mörker. Skorna är även försedda med Asics nya mellansula FlyteFoam Propel som ger responsiv stötdämpning för extra skjuts i steget. Modellen har också sömlös och ventilerande ovandel som formar sig efter foten för bra komfort och stabil passform. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget."
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Size_Description")
                        .HasColumnType("decimal(4, 1)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("WebbShop_API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("WebbShop_API.Models.Order", b =>
                {
                    b.HasOne("WebbShop_API.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebbShop_API.Models.Order_Rows", b =>
                {
                    b.HasOne("WebbShop_API.Models.Order", "Order")
                        .WithMany("Order_Rows")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebbShop_API.Models.Shoe", "Shoe")
                        .WithMany()
                        .HasForeignKey("ShoeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
