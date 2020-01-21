using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbShop_API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColorDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SizeDescription = table.Column<decimal>(type: "decimal(4, 1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderRows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Qty = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    ShoeId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderRows_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorDescription" },
                values: new object[] { 101, "Black" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorDescription" },
                values: new object[] { 102, "White" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorDescription" },
                values: new object[] { 103, "Blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorDescription" },
                values: new object[] { 104, "Green" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorDescription" },
                values: new object[] { 105, "Grey" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Phone", "Role", "UserName" },
                values: new object[] { 1, "vattholvaägen 5c", "lundbergarn2@hotmail.com", "Christoffer", "Lundberg", new byte[] { 221, 227, 13, 125, 71, 215, 44, 217, 217, 56, 136, 128, 207, 222, 61, 18, 213, 6, 16, 91, 63, 124, 240, 157, 18, 156, 16, 70, 84, 254, 164, 0, 136, 86, 22, 20, 196, 52, 167, 0, 70, 44, 208, 222, 191, 14, 107, 227, 217, 147, 109, 229, 118, 90, 236, 168, 141, 36, 230, 87, 90, 254, 91, 8 }, new byte[] { 92, 58, 180, 200, 33, 18, 89, 206, 142, 228, 51, 73, 43, 16, 108, 88, 215, 2, 1, 63, 243, 178, 140, 218, 47, 110, 237, 77, 53, 165, 68, 155, 231, 158, 169, 59, 90, 219, 239, 107, 11, 16, 178, 106, 174, 55, 179, 148, 117, 67, 207, 179, 86, 60, 180, 66, 146, 46, 65, 45, 39, 139, 111, 113, 114, 53, 246, 9, 192, 60, 237, 34, 218, 155, 41, 51, 57, 211, 217, 90, 9, 212, 194, 155, 81, 62, 216, 241, 35, 116, 1, 92, 242, 122, 104, 221, 0, 206, 10, 12, 235, 202, 178, 8, 190, 223, 56, 55, 20, 101, 30, 100, 98, 43, 40, 17, 137, 47, 30, 152, 95, 237, 227, 227, 183, 10, 194, 165 }, "9739874", "Customer", "lundberg" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Phone", "Role", "UserName" },
                values: new object[] { 2, "vattholvaägen 5c", "sara@hotmail.com", "Sara", "Larsson", new byte[] { 221, 227, 13, 125, 71, 215, 44, 217, 217, 56, 136, 128, 207, 222, 61, 18, 213, 6, 16, 91, 63, 124, 240, 157, 18, 156, 16, 70, 84, 254, 164, 0, 136, 86, 22, 20, 196, 52, 167, 0, 70, 44, 208, 222, 191, 14, 107, 227, 217, 147, 109, 229, 118, 90, 236, 168, 141, 36, 230, 87, 90, 254, 91, 8 }, new byte[] { 92, 58, 180, 200, 33, 18, 89, 206, 142, 228, 51, 73, 43, 16, 108, 88, 215, 2, 1, 63, 243, 178, 140, 218, 47, 110, 237, 77, 53, 165, 68, 155, 231, 158, 169, 59, 90, 219, 239, 107, 11, 16, 178, 106, 174, 55, 179, 148, 117, 67, 207, 179, 86, 60, 180, 66, 146, 46, 65, 45, 39, 139, 111, 113, 114, 53, 246, 9, 192, 60, 237, 34, 218, 155, 41, 51, 57, 211, 217, 90, 9, 212, 194, 155, 81, 62, 216, 241, 35, 116, 1, 92, 242, 122, 104, 221, 0, 206, 10, 12, 235, 202, 178, 8, 190, 223, 56, 55, 20, 101, 30, 100, 98, 43, 40, 17, 137, 47, 30, 152, 95, 237, 227, 227, 183, 10, 194, 165 }, "9739874", "Customer", "sara" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 119, "ASICS", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284454_101_ASICS_M%20ROADHAWK%20FF%202%20SHINE.png", "M Roadhawk Ff 2 Shine", 849m, "Lätta löparskor för ett neutralt löpsteg. Shine-versionen av Roadhawk FF 2 är utrustad med extra många reflekterande detaljer för att du ska synas bättre under löprundor i mörker. Skorna är även försedda med Asics nya mellansula FlyteFoam Propel som ger responsiv stötdämpning för extra skjuts i steget. Modellen har också sömlös och ventilerande ovandel som formar sig efter foten för bra komfort och stabil passform. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 118, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_111_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 1399m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 117, "Adidas", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284351_105_ADIDAS_M%20ULTRABOOST%2019.png", "M Ultraboost 19", 1799m, "Ultraboost 19 är löparskor för ett neutralt löpsteg. Skorna har en stretchig stickad ovandel som formar sig efter foten och som har få sömmar för att minimera risken för skav. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget, samt en formgjuten hälkopp som ger en naturlig passform och optimal rörelse vid hälen. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons, och är gjord i Continental-gummi som ger bra grepp på både vått och torrt underlag. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 115, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_108_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 1299m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 116, "Adidas", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284541_101_ADIDAS_M%20SENSEBOOST%20GO.png", "M Senseboost Go", 899m, "Senseboost Go är bekväma löparskor för ett neutralt löpsteg. Designade med stretchig stickad ovandel som andas och som formar sig efter fotens rörelser när du springer. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget. Skorna har en tajt passform och är konstruerade med ett särskilt stöd över mellanfoten, samt har en bred plattform som ger extra stöd vid sidoförflyttningar. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 113, "BROKS", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/276629_101_BROOKS_M%20ADURO%206.png", "M Aduro 6", 999m, "Löparskor för ett neutralt löpsteg. Utrustade med BioMoGo DNA-dämpning som anpassar sig efter din hastighet och vikt för maximal effekt. De har också Segmented Crash Pad som ger ytterligare stötdämpning och en jämnare övergång från häl till tå. Skorna är även utrustade med stödjande ovandel i ventilerande mesh samt med flexibelt framfotsparti och med reflexdetaljer för ökad synlighet." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 112, "ASICS", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284449_101_ASICS_M%20GEL-PULSE%2011.png", "M Gel-Pulse 11", 1099m, "GEL-Pulse 11 från Asics är lätta löparskor för ett neutralt löpsteg. De passar för långdistanslöpning och är utformade för dig som föredrar att träna på landsväg. Skorna är designade med stötdämpande GEL i hälen för mjukare känsla, och är även försedda med Guidance Line-teknologi som hjälper foten hela vägen från hälisättning till frånskjut för en mer effektiv löpstil." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 111, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_101_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 1299m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "ImageUrl", "Name", "Price", "ProductDescription" },
                values: new object[] { 114, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_110_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 799m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 108, 39.5m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 101, 36.0m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 102, 36.5m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 103, 37.0m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 104, 37.5m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 105, 38.0m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 106, 38.5m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 107, 39.0m });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeDescription" },
                values: new object[] { 109, 40.0m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 21, 13, 2, 56, 817, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate" },
                values: new object[] { 2, 2, new DateTime(2020, 1, 21, 13, 2, 56, 821, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "Qty", "ShoeId", "SizeId" },
                values: new object[] { 1, 101, 1, 1, 111, 101 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "Qty", "ShoeId", "SizeId" },
                values: new object[] { 3, 101, 1, 1, 113, 101 });

            migrationBuilder.InsertData(
                table: "OrderRows",
                columns: new[] { "Id", "ColorId", "OrderId", "Qty", "ShoeId", "SizeId" },
                values: new object[] { 2, 101, 2, 1, 111, 101 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ColorId",
                table: "OrderRows",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ShoeId",
                table: "OrderRows",
                column: "ShoeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_SizeId",
                table: "OrderRows",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderRows");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
