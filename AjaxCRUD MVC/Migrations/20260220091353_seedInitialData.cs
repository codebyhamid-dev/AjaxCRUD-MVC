using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AjaxCRUD_MVC.Migrations
{
    /// <inheritdoc />
    public partial class seedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountNumber", "Amount", "BankName", "BeneficiaryName", "Date", "SwiftCode" },
                values: new object[,]
                {
                    { 1, "PK00123456789", 5000m, "HBL", "Ali Khan", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HBLBPKKA" },
                    { 2, "PK00987654321", 12000m, "UBL", "Sara Ahmed", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNILPKKA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
