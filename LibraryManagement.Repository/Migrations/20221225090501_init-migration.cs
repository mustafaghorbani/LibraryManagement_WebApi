using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.UniqueConstraint("AK_Book_ISBN", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    MemberName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.UniqueConstraint("AK_Member_MemberId", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "BookTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    DueTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookTransaction_Book_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Book",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTransaction_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "CreatedBy", "CreatedDate", "Description", "ISBN", "IsActive", "IsAvailable", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1696897e-6865-41d0-bb06-b4e4c0a5bc55"), "R.F. Kuang", "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1585), "", "978-0-393-04052-9", true, true, "Babel", null, null },
                    { new Guid("2bcd531c-e476-47e5-8f3f-252e2c5dc6e9"), "Maud Newton", "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1564), "", "978-0-393-04022-9", true, true, "Ancestor Trouble", null, null },
                    { new Guid("b432d3cf-270c-4560-9e40-eb44c466532e"), "Abdulrazak Gurnah", "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1560), "", "978-0-393-04012-9 ", true, true, "Afterlives", null, null },
                    { new Guid("b4d58bf1-3279-4a8f-a846-c59be50465d3"), "Nuar Alsadir", "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1581), "", "978-0-393-04032-9", true, true, "Animal Joy", null, null },
                    { new Guid("ff079dc8-8790-49e7-b99a-257132fe4a78"), "Rob Delaney", "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1521), "", "978-0-393-04002-9", true, true, "A Heart That Works", null, null }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "MemberId", "MemberName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("09be3b87-6c38-4397-bf0f-afefc0ebd0b3"), "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1673), true, 61655157, "Yizlam Goney", null, null },
                    { new Guid("1384efb8-cc28-494c-a869-6f7739dbc135"), "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1625), true, 30942370, "Ali Koc", null, null },
                    { new Guid("f8f63b53-4306-4cba-be67-a0a6dcd2de8c"), "Mustafa", new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1649), true, 98716652, "Sara yilmaz", null, null }
                });

            migrationBuilder.InsertData(
                table: "BookTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DueTo", "ISBN", "IsActive", "MemberId", "ReturnDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("35d551d1-145a-4db2-89be-c4ce7d3d3bc7"), null, new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1697), new DateTime(2023, 2, 6, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1699), "978-0-393-04022-9", false, 98716652, null, null, null },
                    { new Guid("45ac38af-b8fa-4a59-a11f-bfc796e583dc"), null, new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1703), new DateTime(2023, 2, 6, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1705), "978-0-393-04052-9", false, 61655157, null, null, null },
                    { new Guid("e05f7702-d511-44ac-b87c-e57433f1b2ff"), null, new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1679), new DateTime(2023, 2, 6, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1682), "978-0-393-04002-9", false, 30942370, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_ISBN",
                table: "Book",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookTransaction_ISBN",
                table: "BookTransaction",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BookTransaction_MemberId",
                table: "BookTransaction",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberId",
                table: "Member",
                column: "MemberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTransaction");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
