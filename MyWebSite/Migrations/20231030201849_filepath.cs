using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.Migrations
{
    /// <inheritdoc />
    public partial class filepath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "Products",
                newName: "ProductRateFilePath");

            migrationBuilder.AddColumn<string>(
                name: "ProductImageFilePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImageFilePath",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductRateFilePath",
                table: "Products",
                newName: "FilePath");
        }
    }
}
