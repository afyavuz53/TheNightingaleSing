using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNightingalesSing.DAL.Migrations
{
    public partial class thirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Artist",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)",
                oldMaxLength: 25);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 2, 12, 46, 5, 851, DateTimeKind.Local).AddTicks(7829), new byte[] { 238, 140, 172, 45, 37, 161, 153, 191, 44, 201, 161, 244, 204, 38, 135, 110, 25, 254, 105, 150, 196, 94, 15, 7, 171, 178, 167, 167, 89, 169, 192, 80, 241, 113, 70, 27, 200, 56, 180, 218, 9, 29, 130, 120, 162, 128, 155, 52, 145, 220, 108, 191, 38, 191, 133, 24, 67, 228, 164, 101, 33, 165, 149, 217 }, new byte[] { 89, 10, 0, 228, 90, 186, 32, 240, 155, 74, 123, 58, 139, 11, 188, 169, 110, 11, 204, 90, 97, 151, 188, 130, 14, 139, 244, 37, 165, 207, 28, 138, 196, 98, 244, 30, 12, 187, 47, 252, 60, 232, 166, 26, 31, 68, 255, 201, 89, 185, 28, 108, 92, 233, 200, 66, 244, 154, 127, 110, 130, 162, 239, 17, 194, 225, 115, 223, 140, 55, 195, 93, 99, 53, 160, 116, 1, 240, 27, 141, 38, 147, 62, 51, 190, 126, 118, 58, 15, 132, 32, 33, 64, 216, 68, 134, 109, 200, 110, 210, 179, 172, 65, 162, 108, 33, 156, 139, 224, 120, 234, 101, 85, 218, 141, 185, 167, 112, 219, 149, 142, 67, 159, 16, 143, 209, 145, 67 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Artist",
                type: "character varying(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 2, 12, 22, 57, 202, DateTimeKind.Local).AddTicks(8681), new byte[] { 38, 66, 67, 202, 120, 148, 47, 12, 15, 28, 18, 235, 224, 32, 138, 133, 138, 217, 27, 41, 145, 8, 108, 149, 2, 147, 130, 183, 218, 155, 55, 59, 124, 229, 61, 158, 240, 40, 76, 87, 84, 83, 189, 213, 176, 56, 29, 84, 24, 179, 73, 72, 246, 107, 143, 9, 117, 191, 56, 169, 96, 230, 227, 46 }, new byte[] { 94, 236, 27, 239, 91, 65, 31, 213, 219, 110, 132, 54, 168, 155, 58, 184, 247, 225, 176, 23, 39, 130, 31, 216, 219, 129, 40, 173, 231, 185, 189, 229, 40, 117, 202, 85, 103, 205, 12, 123, 168, 106, 248, 184, 88, 2, 62, 237, 180, 186, 83, 212, 204, 90, 223, 121, 47, 136, 107, 243, 159, 143, 140, 204, 198, 144, 131, 61, 99, 65, 164, 17, 32, 144, 115, 234, 130, 7, 25, 18, 85, 44, 24, 251, 13, 211, 33, 90, 59, 125, 236, 162, 45, 18, 72, 38, 127, 151, 230, 29, 100, 36, 82, 210, 147, 26, 229, 193, 0, 178, 26, 3, 172, 2, 142, 225, 175, 94, 217, 105, 64, 251, 233, 176, 63, 99, 209, 129 } });
        }
    }
}
