using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNightingalesSing.DAL.Migrations
{
    public partial class april24a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReDate",
                table: "Album",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 4, 24, 22, 40, 41, 914, DateTimeKind.Local).AddTicks(1714), new byte[] { 245, 83, 59, 19, 28, 185, 4, 132, 16, 10, 12, 19, 3, 85, 12, 175, 71, 124, 40, 49, 210, 127, 198, 57, 27, 76, 151, 247, 186, 25, 154, 10, 195, 60, 195, 30, 245, 64, 140, 189, 30, 98, 5, 220, 123, 116, 64, 99, 225, 38, 38, 145, 105, 84, 5, 243, 45, 63, 152, 15, 116, 32, 15, 6 }, new byte[] { 127, 96, 242, 106, 219, 198, 32, 167, 243, 59, 66, 35, 174, 161, 204, 192, 160, 93, 160, 10, 226, 153, 175, 70, 173, 70, 80, 184, 46, 211, 229, 228, 186, 184, 15, 199, 228, 185, 182, 61, 118, 75, 64, 196, 78, 170, 33, 200, 49, 51, 245, 76, 195, 30, 121, 52, 157, 142, 40, 54, 217, 93, 83, 165, 217, 180, 43, 133, 252, 178, 165, 145, 164, 181, 164, 156, 214, 197, 79, 198, 197, 240, 101, 115, 137, 232, 207, 81, 101, 222, 173, 100, 67, 170, 137, 252, 88, 168, 39, 122, 115, 44, 32, 62, 118, 212, 175, 78, 206, 209, 36, 32, 94, 59, 255, 243, 181, 5, 81, 4, 59, 100, 17, 116, 25, 186, 92, 95 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReDate",
                table: "Album");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 7, 19, 18, 27, 883, DateTimeKind.Local).AddTicks(3290), new byte[] { 172, 232, 150, 203, 45, 121, 151, 122, 88, 218, 84, 12, 133, 0, 123, 232, 146, 46, 159, 121, 44, 246, 84, 27, 143, 144, 174, 6, 74, 7, 23, 15, 168, 174, 39, 200, 241, 155, 83, 246, 224, 226, 101, 238, 220, 62, 127, 98, 85, 106, 195, 89, 49, 4, 173, 233, 113, 104, 84, 39, 1, 55, 122, 67 }, new byte[] { 98, 98, 46, 189, 105, 172, 227, 59, 225, 71, 209, 239, 216, 137, 227, 252, 36, 151, 30, 85, 11, 31, 97, 206, 140, 192, 82, 179, 117, 225, 255, 102, 216, 10, 65, 127, 105, 67, 52, 228, 43, 38, 45, 190, 66, 216, 134, 60, 47, 103, 101, 31, 252, 245, 76, 179, 62, 178, 33, 86, 208, 134, 51, 230, 159, 165, 207, 8, 187, 59, 243, 74, 75, 91, 158, 54, 116, 213, 87, 64, 195, 96, 73, 206, 204, 239, 196, 231, 105, 210, 65, 237, 14, 67, 2, 253, 199, 176, 135, 119, 212, 24, 153, 169, 245, 127, 242, 202, 246, 249, 6, 140, 197, 226, 169, 31, 250, 185, 201, 175, 91, 49, 206, 76, 224, 173, 210, 36 } });
        }
    }
}
