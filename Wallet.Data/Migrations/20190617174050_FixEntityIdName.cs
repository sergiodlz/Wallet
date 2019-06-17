using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Data.Migrations
{
    public partial class FixEntityIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "User",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "SubCategory",
                table: "SubCategory",
                newName: "SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "RecordType",
                table: "RecordType",
                newName: "RecordTypeId");

            migrationBuilder.RenameColumn(
                name: "Record",
                table: "Record",
                newName: "RecordId");

            migrationBuilder.RenameColumn(
                name: "Label",
                table: "Label",
                newName: "LabelId");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Category",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "AccountType",
                table: "AccountType",
                newName: "AccountTypeId");

            migrationBuilder.RenameColumn(
                name: "Account",
                table: "Account",
                newName: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "SubCategory",
                newName: "SubCategory");

            migrationBuilder.RenameColumn(
                name: "RecordTypeId",
                table: "RecordType",
                newName: "RecordType");

            migrationBuilder.RenameColumn(
                name: "RecordId",
                table: "Record",
                newName: "Record");

            migrationBuilder.RenameColumn(
                name: "LabelId",
                table: "Label",
                newName: "Label");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Category",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "AccountTypeId",
                table: "AccountType",
                newName: "AccountType");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Account",
                newName: "Account");
        }
    }
}
