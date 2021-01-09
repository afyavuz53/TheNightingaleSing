using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNightingalesSing.DAL.Migrations
{
    public partial class aralikFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Album",
                type: "numeric(6,2)",
                precision: 6,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(3,2)",
                oldPrecision: 3,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 7, 19, 18, 27, 883, DateTimeKind.Local).AddTicks(3290), new byte[] { 172, 232, 150, 203, 45, 121, 151, 122, 88, 218, 84, 12, 133, 0, 123, 232, 146, 46, 159, 121, 44, 246, 84, 27, 143, 144, 174, 6, 74, 7, 23, 15, 168, 174, 39, 200, 241, 155, 83, 246, 224, 226, 101, 238, 220, 62, 127, 98, 85, 106, 195, 89, 49, 4, 173, 233, 113, 104, 84, 39, 1, 55, 122, 67 }, new byte[] { 98, 98, 46, 189, 105, 172, 227, 59, 225, 71, 209, 239, 216, 137, 227, 252, 36, 151, 30, 85, 11, 31, 97, 206, 140, 192, 82, 179, 117, 225, 255, 102, 216, 10, 65, 127, 105, 67, 52, 228, 43, 38, 45, 190, 66, 216, 134, 60, 47, 103, 101, 31, 252, 245, 76, 179, 62, 178, 33, 86, 208, 134, 51, 230, 159, 165, 207, 8, 187, 59, 243, 74, 75, 91, 158, 54, 116, 213, 87, 64, 195, 96, 73, 206, 204, 239, 196, 231, 105, 210, 65, 237, 14, 67, 2, 253, 199, 176, 135, 119, 212, 24, 153, 169, 245, 127, 242, 202, 246, 249, 6, 140, 197, 226, 169, 31, 250, 185, 201, 175, 91, 49, 206, 76, 224, 173, 210, 36 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Album",
                type: "numeric(3,2)",
                precision: 3,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(6,2)",
                oldPrecision: 6,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 2, 12, 54, 1, 419, DateTimeKind.Local).AddTicks(8816), new byte[] { 21, 80, 51, 26, 117, 207, 156, 96, 158, 35, 44, 226, 196, 224, 228, 64, 65, 164, 31, 204, 251, 186, 25, 104, 192, 51, 172, 54, 255, 132, 204, 42, 55, 168, 11, 252, 117, 229, 151, 129, 166, 132, 138, 147, 226, 77, 106, 135, 181, 5, 60, 12, 32, 147, 27, 75, 61, 157, 194, 195, 242, 179, 161, 9 }, new byte[] { 16, 233, 248, 63, 207, 14, 253, 158, 206, 239, 128, 180, 234, 199, 81, 237, 21, 187, 163, 182, 98, 168, 170, 63, 44, 100, 202, 4, 93, 255, 33, 165, 87, 31, 223, 116, 180, 86, 126, 14, 8, 108, 56, 179, 5, 17, 151, 68, 142, 191, 223, 126, 96, 81, 112, 219, 233, 80, 32, 132, 29, 221, 113, 110, 36, 179, 216, 162, 153, 216, 123, 215, 23, 225, 125, 126, 250, 160, 178, 14, 139, 149, 228, 108, 88, 17, 239, 28, 88, 81, 95, 0, 156, 253, 3, 30, 127, 255, 35, 213, 245, 101, 165, 204, 161, 118, 106, 119, 155, 25, 41, 117, 36, 116, 0, 98, 137, 14, 23, 61, 14, 118, 202, 123, 33, 242, 170, 230 } });
        }
    }
}
