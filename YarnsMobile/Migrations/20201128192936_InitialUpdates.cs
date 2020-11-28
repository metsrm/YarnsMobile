using Microsoft.EntityFrameworkCore.Migrations;

namespace YarnsMobile.Migrations
{
    public partial class InitialUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Members_MemberId1",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedBooks_Books_BookId",
                table: "PurchasedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedBooks_Members_MemberId1",
                table: "PurchasedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Members_MemberId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MemberId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_PurchasedBooks_MemberId1",
                table: "PurchasedBooks");

            migrationBuilder.DropIndex(
                name: "IX_Phones_MemberId1",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "PurchasedBooks");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "Phones");

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "PurchasedBooks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "PurchasedBooks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "Phones",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MemberId",
                table: "Reviews",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedBooks_MemberId",
                table: "PurchasedBooks",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_MemberId",
                table: "Phones",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Members_MemberId",
                table: "Phones",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedBooks_Books_BookId",
                table: "PurchasedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedBooks_Members_MemberId",
                table: "PurchasedBooks",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Members_MemberId",
                table: "Reviews",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Members_MemberId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedBooks_Books_BookId",
                table: "PurchasedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedBooks_Members_MemberId",
                table: "PurchasedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Members_MemberId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MemberId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_PurchasedBooks_MemberId",
                table: "PurchasedBooks");

            migrationBuilder.DropIndex(
                name: "IX_Phones_MemberId",
                table: "Phones");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberId1",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "PurchasedBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "PurchasedBooks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberId1",
                table: "PurchasedBooks",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberId1",
                table: "Phones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MemberId1",
                table: "Reviews",
                column: "MemberId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedBooks_MemberId1",
                table: "PurchasedBooks",
                column: "MemberId1");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_MemberId1",
                table: "Phones",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Members_MemberId1",
                table: "Phones",
                column: "MemberId1",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedBooks_Books_BookId",
                table: "PurchasedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedBooks_Members_MemberId1",
                table: "PurchasedBooks",
                column: "MemberId1",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Members_MemberId1",
                table: "Reviews",
                column: "MemberId1",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
