using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbShop_API.Migrations
{
    public partial class AddedMoreShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Order_Date",
                value: new DateTime(2020, 1, 11, 18, 0, 15, 236, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Order_Date",
                value: new DateTime(2020, 1, 11, 18, 0, 15, 239, DateTimeKind.Local).AddTicks(5397));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Order_Date",
                value: new DateTime(2020, 1, 11, 14, 57, 50, 341, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Order_Date",
                value: new DateTime(2020, 1, 11, 14, 57, 50, 344, DateTimeKind.Local).AddTicks(1521));
        }
    }
}
