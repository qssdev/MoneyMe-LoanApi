using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanApplication.Migrations
{
    /// <inheritdoc />
    public partial class update_application_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Customers_CustomerId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_CustomerId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "AppDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CustomerId",
                table: "Applications",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Customers_CustomerId",
                table: "Applications",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
