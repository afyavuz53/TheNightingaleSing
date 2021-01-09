using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNightingalesSing.DAL.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Stock",
                table: "Album",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 2, 12, 54, 1, 419, DateTimeKind.Local).AddTicks(8816), new byte[] { 21, 80, 51, 26, 117, 207, 156, 96, 158, 35, 44, 226, 196, 224, 228, 64, 65, 164, 31, 204, 251, 186, 25, 104, 192, 51, 172, 54, 255, 132, 204, 42, 55, 168, 11, 252, 117, 229, 151, 129, 166, 132, 138, 147, 226, 77, 106, 135, 181, 5, 60, 12, 32, 147, 27, 75, 61, 157, 194, 195, 242, 179, 161, 9 }, new byte[] { 16, 233, 248, 63, 207, 14, 253, 158, 206, 239, 128, 180, 234, 199, 81, 237, 21, 187, 163, 182, 98, 168, 170, 63, 44, 100, 202, 4, 93, 255, 33, 165, 87, 31, 223, 116, 180, 86, 126, 14, 8, 108, 56, 179, 5, 17, 151, 68, 142, 191, 223, 126, 96, 81, 112, 219, 233, 80, 32, 132, 29, 221, 113, 110, 36, 179, 216, 162, 153, 216, 123, 215, 23, 225, 125, 126, 250, 160, 178, 14, 139, 149, 228, 108, 88, 17, 239, 28, 88, 81, 95, 0, 156, 253, 3, 30, 127, 255, 35, 213, 245, 101, 165, 204, 161, 118, 106, 119, 155, 25, 41, 117, 36, 116, 0, 98, 137, 14, 23, 61, 14, 118, 202, 123, 33, 242, 170, 230 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Album");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 2, 12, 46, 5, 851, DateTimeKind.Local).AddTicks(7829), new byte[] { 238, 140, 172, 45, 37, 161, 153, 191, 44, 201, 161, 244, 204, 38, 135, 110, 25, 254, 105, 150, 196, 94, 15, 7, 171, 178, 167, 167, 89, 169, 192, 80, 241, 113, 70, 27, 200, 56, 180, 218, 9, 29, 130, 120, 162, 128, 155, 52, 145, 220, 108, 191, 38, 191, 133, 24, 67, 228, 164, 101, 33, 165, 149, 217 }, new byte[] { 89, 10, 0, 228, 90, 186, 32, 240, 155, 74, 123, 58, 139, 11, 188, 169, 110, 11, 204, 90, 97, 151, 188, 130, 14, 139, 244, 37, 165, 207, 28, 138, 196, 98, 244, 30, 12, 187, 47, 252, 60, 232, 166, 26, 31, 68, 255, 201, 89, 185, 28, 108, 92, 233, 200, 66, 244, 154, 127, 110, 130, 162, 239, 17, 194, 225, 115, 223, 140, 55, 195, 93, 99, 53, 160, 116, 1, 240, 27, 141, 38, 147, 62, 51, 190, 126, 118, 58, 15, 132, 32, 33, 64, 216, 68, 134, 109, 200, 110, 210, 179, 172, 65, 162, 108, 33, 156, 139, 224, 120, 234, 101, 85, 218, 141, 185, 167, 112, 219, 149, 142, 67, 159, 16, 143, 209, 145, 67 } });
        }
    }
}
