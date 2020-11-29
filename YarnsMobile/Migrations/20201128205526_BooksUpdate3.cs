using Microsoft.EntityFrameworkCore.Migrations;

namespace YarnsMobile.Migrations
{
    public partial class BooksUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CurrentPrice",
                table: "Books",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "CopyrightYear",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentPrice",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CopyrightYear",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
