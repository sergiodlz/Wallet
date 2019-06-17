using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Data.Migrations
{
    public partial class FixAccountRecordRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Record",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Record_AccountId",
                table: "Record",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Account_AccountId",
                table: "Record",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Account",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Record_Account_AccountId",
                table: "Record");

            migrationBuilder.DropIndex(
                name: "IX_Record_AccountId",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Record");
        }
    }
}
