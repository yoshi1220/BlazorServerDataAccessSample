using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerDataAccessSample.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDay", "MailAddress", "UserName" },
                values: new object[] { 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yamada@mail.com", "山田太郎" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDay", "MailAddress", "UserName" },
                values: new object[] { 2, new DateTime(2009, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "takanashi@mail.com", "小鳥遊咲" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDay", "MailAddress", "UserName" },
                values: new object[] { 3, new DateTime(2004, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "anri@mail.com", "山本杏里" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
