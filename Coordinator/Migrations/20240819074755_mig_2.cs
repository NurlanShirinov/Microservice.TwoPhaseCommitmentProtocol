using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("73899f71-6e63-461e-b3b8-6b09cbdd73bf"), "Payment.API" },
                    { new Guid("ec31412f-faf3-40f2-a8f9-b989da108858"), "Stock.API" },
                    { new Guid("f6d4e3ab-1daa-436a-a6bc-e2f36f535818"), "Order.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("73899f71-6e63-461e-b3b8-6b09cbdd73bf"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("ec31412f-faf3-40f2-a8f9-b989da108858"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("f6d4e3ab-1daa-436a-a6bc-e2f36f535818"));
        }
    }
}
