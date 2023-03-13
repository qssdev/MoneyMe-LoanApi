using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoanApplication.Migrations
{
    /// <inheritdoc />
    public partial class add_new_table_to_save_product_appdata_seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EstablishmentFee",
                table: "Applications",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "AppDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    APRPeriod = table.Column<int>(type: "int", nullable: false),
                    MinimumDuration = table.Column<int>(type: "int", nullable: false),
                    NoInterestFree = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppDatas",
                columns: new[] { "Id", "CreatedDate", "DataType", "Name", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6351), "string", "Title", new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6352), "Mr." },
                    { 2, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6355), "string", "Title", new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6355), "Ms." },
                    { 3, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6357), "string", "Title", new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6358), "Mrs." },
                    { 4, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6360), "decimal", "EstablishmentFee", new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6361), "300" }
                });

            migrationBuilder.InsertData(
                table: "BlackLists",
                columns: new[] { "Id", "CreatedDate", "Type", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6089), "Mobile", new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6101), "09191111222" },
                    { 2, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6103), "Domain", new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6104), "mail" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "APRPeriod", "CreatedDate", "Description", "InterestRate", "MinimumDuration", "Name", "NoInterestFree", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6390), "The loan is interest-free", 0m, 0, "Product A", false, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6391) },
                    { 2, 2, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6399), "The first 2 months is free", 6m, 6, "ProductB", false, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6400) },
                    { 3, 0, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6402), "No Interest Free", 6m, 0, "ProductC", true, new DateTime(2023, 3, 5, 19, 39, 43, 930, DateTimeKind.Local).AddTicks(6403) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppDatas");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlackLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "EstablishmentFee",
                table: "Applications");
        }
    }
}
