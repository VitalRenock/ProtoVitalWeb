using Microsoft.EntityFrameworkCore.Migrations;

namespace VitalWeb.Migrations
{
    public partial class TagTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "PostTitle");

            migrationBuilder.RenameColumn(
                name: "DatePost",
                table: "Posts",
                newName: "PostDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Posts",
                newName: "PostContent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "PostId");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagName = table.Column<string>(type: "TEXT", nullable: true),
                    TagCategory = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.RenameColumn(
                name: "PostTitle",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "PostDate",
                table: "Posts",
                newName: "DatePost");

            migrationBuilder.RenameColumn(
                name: "PostContent",
                table: "Posts",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Posts",
                newName: "Id");
        }
    }
}
