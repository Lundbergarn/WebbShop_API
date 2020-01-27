using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbShop_API.Migrations
{
    public partial class SwedishColorNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 101,
                column: "ColorDescription",
                value: "Svart");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 102,
                column: "ColorDescription",
                value: "Vit");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 103,
                column: "ColorDescription",
                value: "Blå");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 104,
                column: "ColorDescription",
                value: "Röd");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 105,
                column: "ColorDescription",
                value: "Grå");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 151, 118, 43, 22, 134, 35, 51, 110, 94, 204, 224, 97, 200, 42, 88, 51, 110, 12, 217, 163, 44, 14, 52, 153, 156, 37, 242, 212, 31, 101, 61, 46, 136, 238, 125, 77, 12, 154, 38, 192, 23, 174, 239, 253, 179, 18, 134, 169, 145, 174, 47, 78, 97, 32, 20, 95, 1, 33, 69, 240, 246, 59, 56 }, new byte[] { 45, 83, 5, 46, 195, 57, 253, 126, 97, 104, 116, 135, 183, 95, 73, 152, 169, 121, 236, 244, 55, 237, 132, 132, 113, 237, 53, 238, 74, 192, 77, 83, 244, 37, 20, 147, 88, 15, 83, 62, 236, 92, 71, 250, 225, 85, 91, 166, 128, 50, 31, 184, 56, 177, 85, 203, 125, 17, 22, 29, 179, 160, 117, 211, 199, 3, 113, 31, 224, 4, 97, 130, 125, 80, 105, 119, 164, 86, 126, 204, 187, 16, 73, 125, 109, 76, 128, 215, 141, 117, 254, 191, 28, 244, 225, 181, 155, 18, 208, 165, 35, 164, 127, 95, 227, 187, 118, 9, 44, 13, 156, 21, 186, 189, 201, 162, 159, 241, 102, 185, 32, 104, 148, 47, 154, 155, 88, 127 } });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 151, 118, 43, 22, 134, 35, 51, 110, 94, 204, 224, 97, 200, 42, 88, 51, 110, 12, 217, 163, 44, 14, 52, 153, 156, 37, 242, 212, 31, 101, 61, 46, 136, 238, 125, 77, 12, 154, 38, 192, 23, 174, 239, 253, 179, 18, 134, 169, 145, 174, 47, 78, 97, 32, 20, 95, 1, 33, 69, 240, 246, 59, 56 }, new byte[] { 45, 83, 5, 46, 195, 57, 253, 126, 97, 104, 116, 135, 183, 95, 73, 152, 169, 121, 236, 244, 55, 237, 132, 132, 113, 237, 53, 238, 74, 192, 77, 83, 244, 37, 20, 147, 88, 15, 83, 62, 236, 92, 71, 250, 225, 85, 91, 166, 128, 50, 31, 184, 56, 177, 85, 203, 125, 17, 22, 29, 179, 160, 117, 211, 199, 3, 113, 31, 224, 4, 97, 130, 125, 80, 105, 119, 164, 86, 126, 204, 187, 16, 73, 125, 109, 76, 128, 215, 141, 117, 254, 191, 28, 244, 225, 181, 155, 18, 208, 165, 35, 164, 127, 95, 227, 187, 118, 9, 44, 13, 156, 21, 186, 189, 201, 162, 159, 241, 102, 185, 32, 104, 148, 47, 154, 155, 88, 127 } });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 1, 27, 10, 46, 21, 77, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 1, 27, 10, 46, 21, 80, DateTimeKind.Local).AddTicks(3974));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 101,
                column: "ColorDescription",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 102,
                column: "ColorDescription",
                value: "White");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 103,
                column: "ColorDescription",
                value: "Blue");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 104,
                column: "ColorDescription",
                value: "Green");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 105,
                column: "ColorDescription",
                value: "Grey");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 227, 13, 125, 71, 215, 44, 217, 217, 56, 136, 128, 207, 222, 61, 18, 213, 6, 16, 91, 63, 124, 240, 157, 18, 156, 16, 70, 84, 254, 164, 0, 136, 86, 22, 20, 196, 52, 167, 0, 70, 44, 208, 222, 191, 14, 107, 227, 217, 147, 109, 229, 118, 90, 236, 168, 141, 36, 230, 87, 90, 254, 91, 8 }, new byte[] { 92, 58, 180, 200, 33, 18, 89, 206, 142, 228, 51, 73, 43, 16, 108, 88, 215, 2, 1, 63, 243, 178, 140, 218, 47, 110, 237, 77, 53, 165, 68, 155, 231, 158, 169, 59, 90, 219, 239, 107, 11, 16, 178, 106, 174, 55, 179, 148, 117, 67, 207, 179, 86, 60, 180, 66, 146, 46, 65, 45, 39, 139, 111, 113, 114, 53, 246, 9, 192, 60, 237, 34, 218, 155, 41, 51, 57, 211, 217, 90, 9, 212, 194, 155, 81, 62, 216, 241, 35, 116, 1, 92, 242, 122, 104, 221, 0, 206, 10, 12, 235, 202, 178, 8, 190, 223, 56, 55, 20, 101, 30, 100, 98, 43, 40, 17, 137, 47, 30, 152, 95, 237, 227, 227, 183, 10, 194, 165 } });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 227, 13, 125, 71, 215, 44, 217, 217, 56, 136, 128, 207, 222, 61, 18, 213, 6, 16, 91, 63, 124, 240, 157, 18, 156, 16, 70, 84, 254, 164, 0, 136, 86, 22, 20, 196, 52, 167, 0, 70, 44, 208, 222, 191, 14, 107, 227, 217, 147, 109, 229, 118, 90, 236, 168, 141, 36, 230, 87, 90, 254, 91, 8 }, new byte[] { 92, 58, 180, 200, 33, 18, 89, 206, 142, 228, 51, 73, 43, 16, 108, 88, 215, 2, 1, 63, 243, 178, 140, 218, 47, 110, 237, 77, 53, 165, 68, 155, 231, 158, 169, 59, 90, 219, 239, 107, 11, 16, 178, 106, 174, 55, 179, 148, 117, 67, 207, 179, 86, 60, 180, 66, 146, 46, 65, 45, 39, 139, 111, 113, 114, 53, 246, 9, 192, 60, 237, 34, 218, 155, 41, 51, 57, 211, 217, 90, 9, 212, 194, 155, 81, 62, 216, 241, 35, 116, 1, 92, 242, 122, 104, 221, 0, 206, 10, 12, 235, 202, 178, 8, 190, 223, 56, 55, 20, 101, 30, 100, 98, 43, 40, 17, 137, 47, 30, 152, 95, 237, 227, 227, 183, 10, 194, 165 } });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 1, 21, 13, 2, 56, 817, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 1, 21, 13, 2, 56, 821, DateTimeKind.Local).AddTicks(2768));
        }
    }
}
