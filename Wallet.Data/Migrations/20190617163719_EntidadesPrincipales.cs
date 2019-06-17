using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Data.Migrations
{
    public partial class EntidadesPrincipales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    AccountType = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.AccountType);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Label = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Label);
                });

            migrationBuilder.CreateTable(
                name: "RecordType",
                columns: table => new
                {
                    RecordType = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordType", x => x.RecordType);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 1000, nullable: true),
                    Password = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    SubCategory = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.SubCategory);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Category",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Account = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    TypeId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    UserId1 = table.Column<Guid>(nullable: true),
                    InitialBalance = table.Column<double>(nullable: false, defaultValueSql: "0"),
                    Icon = table.Column<byte[]>(nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Account);
                    table.ForeignKey(
                        name: "FK_Account_AccountType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AccountType",
                        principalColumn: "AccountType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "User",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    Record = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastMdifiedBy = table.Column<string>(maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    TypeId = table.Column<Guid>(nullable: false),
                    SubCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.Record);
                    table.ForeignKey(
                        name: "FK_Record_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "SubCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Record_RecordType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "RecordType",
                        principalColumn: "RecordType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecordLabel",
                columns: table => new
                {
                    RecordId = table.Column<Guid>(nullable: false),
                    LabelId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordLabel", x => new { x.RecordId, x.LabelId });
                    table.ForeignKey(
                        name: "FK_RecordLabel_Label_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Label",
                        principalColumn: "Label",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecordLabel_Record_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Record",
                        principalColumn: "Record",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_TypeId",
                table: "Account",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserId",
                table: "Account",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserId1",
                table: "Account",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Record_SubCategoryId",
                table: "Record",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Record_TypeId",
                table: "Record",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordLabel_LabelId",
                table: "RecordLabel",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "RecordLabel");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "RecordType");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
