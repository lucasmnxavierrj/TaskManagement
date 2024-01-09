using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class remove_pass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 27, 18, 28, 14, 35, DateTimeKind.Local).AddTicks(6939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 27, 18, 28, 14, 35, DateTimeKind.Local).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(5978));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(9074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 27, 18, 28, 14, 35, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(5978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 27, 18, 28, 14, 35, DateTimeKind.Local).AddTicks(3282));
        }
    }
}
