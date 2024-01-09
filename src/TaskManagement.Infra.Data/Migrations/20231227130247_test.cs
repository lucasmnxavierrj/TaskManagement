using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(9074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 12, 40, 32, 372, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(5978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 12, 40, 32, 372, DateTimeKind.Local).AddTicks(1849));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 12, 40, 32, 372, DateTimeKind.Local).AddTicks(4894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 12, 40, 32, 372, DateTimeKind.Local).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 27, 10, 2, 47, 71, DateTimeKind.Local).AddTicks(5978));
        }
    }
}
