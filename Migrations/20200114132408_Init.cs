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
                    Color_Description = table.Column<string>(nullable: true)
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
                    Product_Description = table.Column<string>(nullable: true),
                    Image_Url = table.Column<string>(nullable: true)
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
                    Size_Description = table.Column<decimal>(type: "decimal(4, 1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Order_Date = table.Column<DateTime>(nullable: false),
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
                name: "Order_Rows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Qty = table.Column<int>(nullable: false),
                    ShoeId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Rows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Rows_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Rows_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Phone", "Role", "UserName" },
                values: new object[] { 1, "vattholvaägen 5c", "lundbergarn2@hotmail.com", "Christoffer", "Lundberg", new byte[] { 46, 96, 15, 2, 176, 90, 63, 139, 19, 71, 121, 42, 251, 54, 49, 93, 235, 232, 255, 143, 6, 232, 172, 109, 39, 151, 247, 115, 116, 176, 71, 96, 117, 202, 84, 99, 105, 126, 12, 140, 207, 152, 105, 160, 117, 202, 99, 42, 122, 166, 105, 226, 154, 172, 30, 1, 212, 98, 58, 102, 159, 5, 214, 237 }, new byte[] { 199, 110, 83, 95, 26, 98, 33, 202, 147, 125, 254, 12, 231, 120, 198, 112, 136, 68, 148, 238, 99, 98, 38, 63, 154, 107, 101, 166, 119, 115, 75, 61, 163, 244, 15, 251, 28, 107, 240, 95, 150, 231, 223, 219, 100, 134, 206, 226, 148, 163, 144, 238, 49, 214, 183, 126, 120, 169, 162, 195, 176, 227, 223, 150, 10, 146, 254, 8, 153, 229, 89, 112, 196, 15, 17, 145, 230, 77, 207, 171, 47, 2, 35, 244, 151, 101, 55, 90, 251, 9, 130, 41, 35, 142, 9, 54, 86, 74, 121, 181, 120, 88, 60, 184, 105, 55, 210, 65, 13, 117, 220, 139, 190, 166, 166, 18, 228, 161, 9, 108, 170, 118, 69, 69, 96, 103, 234, 216 }, "9739874", "Customer", "lundberg" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Phone", "Role", "UserName" },
                values: new object[] { 2, "vattholvaägen 5c", "sara@hotmail.com", "Sara", "Larsson", new byte[] { 46, 96, 15, 2, 176, 90, 63, 139, 19, 71, 121, 42, 251, 54, 49, 93, 235, 232, 255, 143, 6, 232, 172, 109, 39, 151, 247, 115, 116, 176, 71, 96, 117, 202, 84, 99, 105, 126, 12, 140, 207, 152, 105, 160, 117, 202, 99, 42, 122, 166, 105, 226, 154, 172, 30, 1, 212, 98, 58, 102, 159, 5, 214, 237 }, new byte[] { 199, 110, 83, 95, 26, 98, 33, 202, 147, 125, 254, 12, 231, 120, 198, 112, 136, 68, 148, 238, 99, 98, 38, 63, 154, 107, 101, 166, 119, 115, 75, 61, 163, 244, 15, 251, 28, 107, 240, 95, 150, 231, 223, 219, 100, 134, 206, 226, 148, 163, 144, 238, 49, 214, 183, 126, 120, 169, 162, 195, 176, 227, 223, 150, 10, 146, 254, 8, 153, 229, 89, 112, 196, 15, 17, 145, 230, 77, 207, 171, 47, 2, 35, 244, 151, 101, 55, 90, 251, 9, 130, 41, 35, 142, 9, 54, 86, 74, 121, 181, 120, 88, 60, 184, 105, 55, 210, 65, 13, 117, 220, 139, 190, 166, 166, 18, 228, 161, 9, 108, 170, 118, 69, 69, 96, 103, 234, 216 }, "9739874", "Customer", "sara" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 111, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_101_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 1299m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 112, "ASICS", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284449_101_ASICS_M%20GEL-PULSE%2011.png", "M Gel-Pulse 11", 1099m, "GEL-Pulse 11 från Asics är lätta löparskor för ett neutralt löpsteg. De passar för långdistanslöpning och är utformade för dig som föredrar att träna på landsväg. Skorna är designade med stötdämpande GEL i hälen för mjukare känsla, och är även försedda med Guidance Line-teknologi som hjälper foten hela vägen från hälisättning till frånskjut för en mer effektiv löpstil." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 113, "BROKS", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/276629_101_BROOKS_M%20ADURO%206.png", "M Aduro 6", 999m, "Löparskor för ett neutralt löpsteg. Utrustade med BioMoGo DNA-dämpning som anpassar sig efter din hastighet och vikt för maximal effekt. De har också Segmented Crash Pad som ger ytterligare stötdämpning och en jämnare övergång från häl till tå. Skorna är även utrustade med stödjande ovandel i ventilerande mesh samt med flexibelt framfotsparti och med reflexdetaljer för ökad synlighet." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 114, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_110_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 799m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 115, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_108_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 1299m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 116, "Adidas", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284541_101_ADIDAS_M%20SENSEBOOST%20GO.png", "M Senseboost Go", 899m, "Senseboost Go är bekväma löparskor för ett neutralt löpsteg. Designade med stretchig stickad ovandel som andas och som formar sig efter fotens rörelser när du springer. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget. Skorna har en tajt passform och är konstruerade med ett särskilt stöd över mellanfoten, samt har en bred plattform som ger extra stöd vid sidoförflyttningar. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 117, "Adidas", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284351_105_ADIDAS_M%20ULTRABOOST%2019.png", "M Ultraboost 19", 1799m, "Ultraboost 19 är löparskor för ett neutralt löpsteg. Skorna har en stretchig stickad ovandel som formar sig efter foten och som har få sömmar för att minimera risken för skav. De har även mellansula i Boost-foam för responsiv stötdämpning som ger extra skjuts i steget, samt en formgjuten hälkopp som ger en naturlig passform och optimal rörelse vid hälen. Skornas Stretchweb-yttersula böjer sig naturligt under foten för ännu mera respons, och är gjord i Continental-gummi som ger bra grepp på både vått och torrt underlag. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 118, "Nike", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/282111_111_NIKE_NIKE%20AIR%20ZOOM%20PEGASUS%2036.png", "Nike Air Zoom Pegasus 36", 1399m, "Löparskor för ett neutralt löpsteg. Utrustade med Zoom Air i fullängd för responsiv stötdämpning som ger extra skjuts i steget." });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Brand", "Image_Url", "Name", "Price", "Product_Description" },
                values: new object[] { 119, "ASICS", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/284454_101_ASICS_M%20ROADHAWK%20FF%202%20SHINE.png", "M Roadhawk Ff 2 Shine", 849m, "Lätta löparskor för ett neutralt löpsteg. Shine-versionen av Roadhawk FF 2 är utrustad med extra många reflekterande detaljer för att du ska synas bättre under löprundor i mörker. Skorna är även försedda med Asics nya mellansula FlyteFoam Propel som ger responsiv stötdämpning för extra skjuts i steget. Modellen har också sömlös och ventilerande ovandel som formar sig efter foten för bra komfort och stabil passform. Skornas drop (höjdskillnad mellan häl och tå) på 10 mm placerar kroppen i en bättre balanserad och mer bekväm position under hela steget." });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Order_Date" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 14, 14, 24, 7, 706, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Order_Date" },
                values: new object[] { 2, 2, new DateTime(2020, 1, 14, 14, 24, 7, 709, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.InsertData(
                table: "Order_Rows",
                columns: new[] { "Id", "OrderId", "Qty", "ShoeId" },
                values: new object[] { 1, 1, 1, 111 });

            migrationBuilder.InsertData(
                table: "Order_Rows",
                columns: new[] { "Id", "OrderId", "Qty", "ShoeId" },
                values: new object[] { 3, 1, 1, 113 });

            migrationBuilder.InsertData(
                table: "Order_Rows",
                columns: new[] { "Id", "OrderId", "Qty", "ShoeId" },
                values: new object[] { 2, 2, 1, 111 });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Rows_OrderId",
                table: "Order_Rows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Rows_ShoeId",
                table: "Order_Rows",
                column: "ShoeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Order_Rows");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
