using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNightingalesSing.DAL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "User",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "User",
                type: "bytea",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2020, 12, 2, 12, 22, 57, 202, DateTimeKind.Local).AddTicks(8681), new byte[] { 38, 66, 67, 202, 120, 148, 47, 12, 15, 28, 18, 235, 224, 32, 138, 133, 138, 217, 27, 41, 145, 8, 108, 149, 2, 147, 130, 183, 218, 155, 55, 59, 124, 229, 61, 158, 240, 40, 76, 87, 84, 83, 189, 213, 176, 56, 29, 84, 24, 179, 73, 72, 246, 107, 143, 9, 117, 191, 56, 169, 96, 230, 227, 46 }, new byte[] { 94, 236, 27, 239, 91, 65, 31, 213, 219, 110, 132, 54, 168, 155, 58, 184, 247, 225, 176, 23, 39, 130, 31, 216, 219, 129, 40, 173, 231, 185, 189, 229, 40, 117, 202, 85, 103, 205, 12, 123, 168, 106, 248, 184, 88, 2, 62, 237, 180, 186, 83, 212, 204, 90, 223, 121, 47, 136, 107, 243, 159, 143, 140, 204, 198, 144, 131, 61, 99, 65, 164, 17, 32, 144, 115, 234, 130, 7, 25, 18, 85, 44, 24, 251, 13, 211, 33, 90, 59, 125, 236, 162, 45, 18, 72, 38, 127, 151, 230, 29, 100, 36, 82, 210, 147, 26, 229, 193, 0, 178, 26, 3, 172, 2, 142, 225, 175, 94, 217, 105, 64, 251, 233, 176, 63, 99, 209, 129 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "Password" },
                values: new object[] { new DateTime(2020, 11, 30, 15, 44, 35, 412, DateTimeKind.Local).AddTicks(8572), "123" });
        }
    }
}
