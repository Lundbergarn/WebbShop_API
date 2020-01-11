using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbShop_API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

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
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
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
                columns: new[] { "Id", "Address", "Email", "First_Name", "Last_Name", "Password", "Phone" },
                values: new object[] { 1, "vattholvaägen 5c", "lundbergarn2@hotmail.com", "Christoffer", "Lundberg", "password", "9739874" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "First_Name", "Last_Name", "Password", "Phone" },
                values: new object[] { 2, "vattholvaägen 5c", "sara@hotmail.com", "Sara", "Larsson", "password", "9739874" });

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
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Order_Date" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 11, 14, 57, 50, 341, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Order_Date" },
                values: new object[] { 2, 2, new DateTime(2020, 1, 11, 14, 57, 50, 344, DateTimeKind.Local).AddTicks(1521) });

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
                name: "Admins");

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
