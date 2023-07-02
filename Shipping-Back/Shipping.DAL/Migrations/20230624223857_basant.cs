using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shipping.DAL.Migrations
{
    /// <inheritdoc />
    public partial class basant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeliverToVillages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdditionalCost",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdditionalPrice",
                value: 5.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeliverToVillages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdditionalCost",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdditionalPrice",
                value: 30.0);
        }
    }
}
