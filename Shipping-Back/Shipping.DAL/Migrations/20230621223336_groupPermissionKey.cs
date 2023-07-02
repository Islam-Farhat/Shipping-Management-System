using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shipping.DAL.Migrations
{
    /// <inheritdoc />
    public partial class groupPermissionKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupPermissions",
                table: "GroupPermissions");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "GroupPermissions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupPermissions",
                table: "GroupPermissions",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPermissions_GroupId",
                table: "GroupPermissions",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupPermissions",
                table: "GroupPermissions");

            migrationBuilder.DropIndex(
                name: "IX_GroupPermissions_GroupId",
                table: "GroupPermissions");

            migrationBuilder.DropColumn(
                name: "id",
                table: "GroupPermissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupPermissions",
                table: "GroupPermissions",
                columns: new[] { "GroupId", "PermissionId" });
        }
    }
}
