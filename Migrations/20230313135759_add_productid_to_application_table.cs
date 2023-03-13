using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanApplication.Migrations
{
    /// <inheritdoc />
    public partial class add_productid_to_application_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2679), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 3, 13, 21, 57, 59, 570, DateTimeKind.Local).AddTicks(2710) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5295), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5298), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5302), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5325), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5331), new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5332) });
        }
    }
}
