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

                    b.Property<string>("ColorDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            ColorDescription = "Svart"
                        },
                        new
                        {
                            Id = 102,
                            ColorDescription = "Vit"
                        },
                        new
                        {
                            Id = 103,
                            ColorDescription = "Blå"
                        },
                        new
                        {
                            Id = 104,
                            ColorDescription = "Röd"
                        },
                        new
                        {
                            Id = 105,
                            ColorDescription = "Grå"
                        });
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
                            PasswordHash = new byte[] { 54, 151, 118, 43, 22, 134, 35, 51, 110, 94, 204, 224, 97, 200, 42, 88, 51, 110, 12, 217, 163, 44, 14, 52, 153, 156, 37, 242, 212, 31, 101, 61, 46, 136, 238, 125, 77, 12, 154, 38, 192, 23, 174, 239, 253, 179, 18, 134, 169, 145, 174, 47, 78, 97, 32, 20, 95, 1, 33, 69, 240, 246, 59, 56 },
                            PasswordSalt = new byte[] { 45, 83, 5, 46, 195, 57, 253, 126, 97, 104, 116, 135, 183, 95, 73, 152, 169, 121, 236, 244, 55, 237, 132, 132, 113, 237, 53, 238, 74, 192, 77, 83, 244, 37, 20, 147, 88, 15, 83, 62, 236, 92, 71, 250, 225, 85, 91, 166, 128, 50, 31, 184, 56, 177, 85, 203, 125, 17, 22, 29, 179, 160, 117, 211, 199, 3, 113, 31, 224, 4, 97, 130, 125, 80, 105, 119, 164, 86, 126, 204, 187, 16, 73, 125, 109, 76, 128, 215, 141, 117, 254, 191, 28, 244, 225, 181, 155, 18, 208, 165, 35, 164, 127, 95, 227, 187, 118, 9, 44, 13, 156, 21, 186, 189, 201, 162, 159, 241, 102, 185, 32, 104, 148, 47, 154, 155, 88, 127 },
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
                            PasswordHash = new byte[] { 54, 151, 118, 43, 22, 134, 35, 51, 110, 94, 204, 224, 97, 200, 42, 88, 51, 110, 12, 217, 163, 44, 14, 52, 153, 156, 37, 242, 212, 31, 101, 61, 46, 136, 238, 125, 77, 12, 154, 38, 192, 23, 174, 239, 253, 179, 18, 134, 169, 145, 174, 47, 78, 97, 32, 20, 95, 1, 33, 69, 240, 246, 59, 56 },
                            PasswordSalt = new byte[] { 45, 83, 5, 46, 195, 57, 253, 126, 97, 104, 116, 135, 183, 95, 73, 152, 169, 121, 236, 244, 55, 237, 132, 132, 113, 237, 53, 238, 74, 192, 77, 83, 244, 37, 20, 147, 88, 15, 83, 62, 236, 92, 71, 250, 225, 85, 91, 166, 128, 50, 31, 184, 56, 177, 85, 203, 125, 17, 22, 29, 179, 160, 117, 211, 199, 3, 113, 31, 224, 4, 97, 130, 125, 80, 105, 119, 164, 86, 126, 204, 187, 16, 73, 125, 109, 76, 128, 215, 141, 117, 254, 191, 28, 244, 225, 181, 155, 18, 208, 165, 35, 164, 127, 95, 227, 187, 118, 9, 44, 13, 156, 21, 186, 189, 201, 162, 159, 241, 102, 185, 32, 104, 148, 47, 154, 155, 88, 127 },
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

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2020, 1, 27, 10, 46, 21, 77, DateTimeKind.Local).AddTicks(2195)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            OrderDate = new DateTime(2020, 1, 27, 10, 46, 21, 80, DateTimeKind.Local).AddTicks(3974)
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.OrderRows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShoeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ShoeId");

                    b.HasIndex("SizeId");

                    b.ToTable("OrderRows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorId = 101,
                            OrderId = 1,
                            Qty = 1,
                            ShoeId = 111,
                            SizeId = 101
                        },
                        new
                        {
                            Id = 2,
                            ColorId = 101,
                            OrderId = 2,
                            Qty = 1,
                            ShoeId = 111,
                            SizeId = 101
                        },
                        new
                        {
                            Id = 3,
                            ColorId = 101,
                            OrderId = 1,
                            Qty = 1,
                            ShoeId = 113,
                            SizeId = 101
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Shoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            Id = 111,
                            Brand = "Nike",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_101_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 1299m,
                            ProductDescription = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 112,
                            Brand = "ASICS",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284449_101_ASICS_M%20GEL-PULSE%2011.png",
                            Name = "M Gel-Pulse 11",
                            Price = 1099m,
                            ProductDescription = "GEL-Pulse 11 från Asics är lätta löparskor för ett neutralt löpsteg. De passar för långdistanslöpning och är utformade för dig som föredrar att träna på landsväg. Skorna är designade med stötdämpande GEL i hälen för mjukare känsla, och är även försedda med Guidance Line-teknologi som hjälper foten hela vägen från hälisättning till frånskjut för en mer effektiv löpstil."
                        },
                        new
                        {
                            Id = 113,
                            Brand = "BROKS",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/276629_101_BROOKS_M%20ADURO%206.png",
                            Name = "M Aduro 6",
                            Price = 999m,
                            ProductDescription = "Löparskor för ett neutralt löpsteg. Utrustade med BioMoGo DNA-dämpning som anpassar sig efter din hastighet och vikt för maximal effekt. De har också Segmented Crash Pad som ger ytterligare stötdämpning och en jämnare övergång från häl till tå. Skorna är även utrustade med stödjande ovandel i ventilerande mesh samt med flexibelt framfotsparti och med reflexdetaljer för ökad synlighet."
                        },
                        new
                        {
                            Id = 114,
                            Brand = "Nike",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_110_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 799m,
                            ProductDescription = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 115,
                            Brand = "Nike",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_108_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 1299m,
                            ProductDescription = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 116,
                            Brand = "Adidas",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284541_101_ADIDAS_M%20SENSEBOOST%20GO.png",
                            Name = "M Senseboost Go",
                            Price = 899m,
                            ProductDescription = "Senseboost Go är bekväma löparskor för ett neutralt löpsteg. Designade med stretchig stickad ovandel som andas och som formar sig efter fotens rörelser när du springer. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget. Skorna har en tajt passform och är konstruerade med ett särskilt stöd över mellanfoten, samt har en bred plattform som ger extra stöd vid sidoförflyttningar. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons."
                        },
                        new
                        {
                            Id = 117,
                            Brand = "Adidas",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284351_105_ADIDAS_M%20ULTRABOOST%2019.png",
                            Name = "M Ultraboost 19",
                            Price = 1799m,
                            ProductDescription = "Ultraboost 19 är löparskor för ett neutralt löpsteg. Skorna har en stretchig stickad ovandel som formar sig efter foten och som har få sömmar för att minimera risken för skav. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget, samt en formgjuten hälkopp som ger en naturlig passform och optimal rörelse vid hälen. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons, och är gjord i Continental-gummi som ger bra grepp på både vått och torrt underlag. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget."
                        },
                        new
                        {
                            Id = 118,
                            Brand = "Nike",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_111_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png",
                            Name = "Nike Air Zoom Pegasus 36",
                            Price = 1399m,
                            ProductDescription = "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget."
                        },
                        new
                        {
                            Id = 119,
                            Brand = "ASICS",
                            ImageUrl = "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284454_101_ASICS_M%20ROADHAWK%20FF%202%20SHINE.png",
                            Name = "M Roadhawk Ff 2 Shine",
                            Price = 849m,
                            ProductDescription = "Lätta löparskor för ett neutralt löpsteg. Shine-versionen av Roadhawk FF 2 är utrustad med extra många reflekterande detaljer för att du ska synas bättre under löprundor i mörker. Skorna är även försedda med Asics nya mellansula FlyteFoam Propel som ger responsiv stötdämpning för extra skjuts i steget. Modellen har också sömlös och ventilerande ovandel som formar sig efter foten för bra komfort och stabil passform. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget."
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SizeDescription")
                        .HasColumnType("decimal(4, 1)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            SizeDescription = 36.0m
                        },
                        new
                        {
                            Id = 102,
                            SizeDescription = 36.5m
                        },
                        new
                        {
                            Id = 103,
                            SizeDescription = 37.0m
                        },
                        new
                        {
                            Id = 104,
                            SizeDescription = 37.5m
                        },
                        new
                        {
                            Id = 105,
                            SizeDescription = 38.0m
                        },
                        new
                        {
                            Id = 106,
                            SizeDescription = 38.5m
                        },
                        new
                        {
                            Id = 107,
                            SizeDescription = 39.0m
                        },
                        new
                        {
                            Id = 108,
                            SizeDescription = 39.5m
                        },
                        new
                        {
                            Id = 109,
                            SizeDescription = 40.0m
                        });
                });

            modelBuilder.Entity("WebbShop_API.Models.Order", b =>
                {
                    b.HasOne("WebbShop_API.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebbShop_API.Models.OrderRows", b =>
                {
                    b.HasOne("WebbShop_API.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebbShop_API.Models.Order", "Order")
                        .WithMany("OrderRows")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebbShop_API.Models.Shoe", "Shoe")
                        .WithMany()
                        .HasForeignKey("ShoeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebbShop_API.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
