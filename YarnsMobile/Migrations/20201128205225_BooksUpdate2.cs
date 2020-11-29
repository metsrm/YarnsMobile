using Microsoft.EntityFrameworkCore.Migrations;

namespace YarnsMobile.Migrations
{
    public partial class BooksUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CopyrightYear",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CopyrightYear",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
