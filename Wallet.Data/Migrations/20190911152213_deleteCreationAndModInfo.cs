using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Data.Migrations
{
    public partial class deleteCreationAndModInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RecordType");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "RecordType");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "RecordType");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "RecordType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AccountType");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "AccountType");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "AccountType");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "AccountType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "LastMdifiedBy",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Account");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "User",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "SubCategory",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "RecordType",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Record",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Label",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Category",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "AccountType",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Account",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "User",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "User",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "User",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "User",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "User",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "SubCategory",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SubCategory",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SubCategory",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "SubCategory",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "SubCategory",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "RecordType",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RecordType",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "RecordType",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "RecordType",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "RecordType",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Record",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Record",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Record",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "Record",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Record",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Label",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Label",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Label",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "Label",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Label",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Category",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Category",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Category",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "Category",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Category",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "AccountType",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AccountType",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "AccountType",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "AccountType",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "AccountType",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "Account",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Account",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Account",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "LastMdifiedBy",
                table: "Account",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Account",
                nullable: false,
                defaultValueSql: "GetDate()");
        }
    }
}
