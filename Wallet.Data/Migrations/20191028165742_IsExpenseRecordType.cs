using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Data.Migrations
{
    public partial class IsExpenseRecordType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExpense",
                table: "RecordType",
                nullable: false,
                defaultValueSql: "0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExpense",
                table: "RecordType");
        }
    }
}
