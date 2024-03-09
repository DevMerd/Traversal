using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traversal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDestinatinIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "Destinations",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Destinations",
                newName: "DestinationId");
        }
    }
}
