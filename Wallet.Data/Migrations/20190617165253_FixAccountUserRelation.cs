using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Data.Migrations
{
    public partial class FixAccountUserRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_User_UserId1",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_UserId1",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Account");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "Account",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserId1",
                table: "Account",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_User_UserId1",
                table: "Account",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "User",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
