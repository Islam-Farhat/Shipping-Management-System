using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shipping.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addreplationbetweenRepresentativeandorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RepresentativeId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RepresentativeId",
                table: "Orders",
                column: "RepresentativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_RepresentativeId",
                table: "Orders",
                column: "RepresentativeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_RepresentativeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RepresentativeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RepresentativeId",
                table: "Orders");
        }
    }
}
