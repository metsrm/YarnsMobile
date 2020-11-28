using Microsoft.EntityFrameworkCore.Migrations;

namespace YarnsMobile.Migrations
{
    public partial class InitialUpdates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Addresses_AddressId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Members",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Addresses_AddressId",
                table: "Members",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Addresses_AddressId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Members",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Addresses_AddressId",
                table: "Members",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
