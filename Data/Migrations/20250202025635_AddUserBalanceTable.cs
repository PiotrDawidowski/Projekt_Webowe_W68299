using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektKrypto2.Migrations
{
    /// <inheritdoc />
    public partial class AddUserBalanceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_UserBalances_AspNetUsers_UserId",
                table: "UserBalances",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBalances_AspNetUsers_UserId",
                table: "UserBalances");
        }
    }
}
