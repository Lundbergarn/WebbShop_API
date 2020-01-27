using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbShop_API.Migrations
{
    public partial class EnglishCOlors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "white");

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
                value: "Red");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 105,
                column: "ColorDescription",
                value: "Pink");

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorDescription" },
                values: new object[] { 106, "Grey" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 129, 134, 165, 33, 161, 184, 128, 50, 203, 213, 232, 146, 36, 161, 109, 224, 132, 104, 167, 13, 197, 89, 158, 57, 0, 74, 82, 39, 138, 123, 212, 72, 97, 75, 22, 108, 69, 0, 226, 212, 108, 10, 216, 212, 149, 16, 225, 87, 114, 86, 217, 131, 129, 197, 181, 150, 217, 140, 231, 153, 241, 122, 175 }, new byte[] { 157, 151, 196, 162, 18, 13, 130, 104, 226, 47, 249, 71, 162, 201, 13, 220, 133, 118, 115, 246, 11, 50, 104, 195, 202, 73, 143, 245, 208, 170, 77, 182, 192, 244, 199, 102, 87, 140, 246, 75, 207, 81, 206, 182, 70, 157, 66, 34, 200, 48, 220, 108, 234, 214, 207, 16, 123, 216, 230, 13, 101, 41, 113, 12, 30, 11, 160, 103, 174, 58, 167, 101, 243, 62, 203, 205, 203, 181, 79, 64, 141, 82, 65, 71, 200, 102, 116, 28, 208, 202, 132, 86, 50, 220, 74, 192, 225, 252, 96, 103, 96, 8, 143, 210, 107, 252, 36, 104, 73, 113, 12, 130, 152, 27, 70, 132, 195, 45, 12, 40, 238, 78, 136, 193, 108, 54, 41, 114 } });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 129, 134, 165, 33, 161, 184, 128, 50, 203, 213, 232, 146, 36, 161, 109, 224, 132, 104, 167, 13, 197, 89, 158, 57, 0, 74, 82, 39, 138, 123, 212, 72, 97, 75, 22, 108, 69, 0, 226, 212, 108, 10, 216, 212, 149, 16, 225, 87, 114, 86, 217, 131, 129, 197, 181, 150, 217, 140, 231, 153, 241, 122, 175 }, new byte[] { 157, 151, 196, 162, 18, 13, 130, 104, 226, 47, 249, 71, 162, 201, 13, 220, 133, 118, 115, 246, 11, 50, 104, 195, 202, 73, 143, 245, 208, 170, 77, 182, 192, 244, 199, 102, 87, 140, 246, 75, 207, 81, 206, 182, 70, 157, 66, 34, 200, 48, 220, 108, 234, 214, 207, 16, 123, 216, 230, 13, 101, 41, 113, 12, 30, 11, 160, 103, 174, 58, 167, 101, 243, 62, 203, 205, 203, 181, 79, 64, 141, 82, 65, 71, 200, 102, 116, 28, 208, 202, 132, 86, 50, 220, 74, 192, 225, 252, 96, 103, 96, 8, 143, 210, 107, 252, 36, 104, 73, 113, 12, 130, 152, 27, 70, 132, 195, 45, 12, 40, 238, 78, 136, 193, 108, 54, 41, 114 } });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 1, 27, 16, 40, 46, 95, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 1, 27, 16, 40, 46, 102, DateTimeKind.Local).AddTicks(5449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 106);

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
    }
}
