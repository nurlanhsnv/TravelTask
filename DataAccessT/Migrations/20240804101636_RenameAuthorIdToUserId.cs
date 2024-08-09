using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessT.Migrations
{
    /// <inheritdoc />
    public partial class RenameAuthorIdToUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Blogs",
                newName: "UserID");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Blogs",
                newName: "AuthorID");
        }
    }
}
