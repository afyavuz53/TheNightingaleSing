using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNightingalesSing.DAL.Migrations
{
    public partial class april24 : Migration
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
                values: new object[] { new DateTime(2021, 4, 24, 22, 36, 9, 867, DateTimeKind.Local).AddTicks(7624), new byte[] { 12, 9, 14, 66, 48, 54, 33, 140, 83, 152, 156, 52, 188, 86, 243, 156, 16, 158, 99, 1, 12, 243, 230, 209, 109, 249, 250, 193, 193, 133, 80, 128, 23, 46, 118, 82, 251, 205, 184, 72, 146, 25, 38, 143, 10, 104, 137, 14, 106, 72, 68, 198, 231, 59, 1, 215, 218, 55, 95, 175, 87, 0, 154, 68 }, new byte[] { 169, 59, 146, 114, 42, 39, 133, 175, 83, 40, 53, 194, 101, 145, 173, 135, 106, 200, 220, 193, 184, 151, 193, 221, 48, 180, 42, 62, 78, 7, 69, 102, 231, 150, 75, 202, 249, 106, 160, 206, 193, 164, 255, 102, 14, 126, 56, 12, 30, 63, 124, 32, 224, 179, 160, 106, 56, 149, 207, 10, 57, 11, 155, 218, 232, 169, 189, 10, 254, 49, 107, 22, 248, 207, 219, 58, 249, 74, 222, 107, 72, 105, 217, 177, 219, 73, 255, 149, 135, 84, 202, 179, 59, 3, 44, 210, 218, 117, 137, 48, 120, 239, 67, 155, 131, 128, 133, 123, 224, 90, 8, 232, 134, 167, 150, 29, 73, 128, 204, 72, 11, 229, 76, 129, 240, 216, 118, 92 } });
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
