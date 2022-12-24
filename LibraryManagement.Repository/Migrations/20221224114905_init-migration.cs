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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_BookTransaction", x => new { x.MemberId, x.ISBN });
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
                    { new Guid("158bd420-7e23-4123-afcb-b75e789ff869"), "Nuar Alsadir", "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5883), "", "978-0-393-04032-9", true, true, "Animal Joy", null, null },
                    { new Guid("60e81967-cf9c-4307-91b9-9d2133abda76"), "Abdulrazak Gurnah", "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5860), "", "978-0-393-04012-9 ", true, true, "Afterlives", null, null },
                    { new Guid("6de3d52b-fd3f-4d76-9adb-1cbc8a66d8af"), "Rob Delaney", "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5822), "", "978-0-393-04002-9", true, true, "A Heart That Works", null, null },
                    { new Guid("8e92d8e4-3d03-4109-9edb-c470c6f5cb1a"), "Maud Newton", "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5873), "", "978-0-393-04022-9", true, true, "Ancestor Trouble", null, null },
                    { new Guid("e9ae8c4b-8b5f-4246-8eca-1db8a7c4068f"), "R.F. Kuang", "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5886), "", "978-0-393-04052-9", true, true, "Babel", null, null }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "MemberId", "MemberName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("821ef394-d003-4964-a16c-4c93d782b9d5"), "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5948), true, 29182029, "Sara yilmaz", null, null },
                    { new Guid("8b2811b2-c80f-497d-b1cc-1b223cd506f8"), "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5923), true, 42323190, "Ali Koc", null, null },
                    { new Guid("b192a145-8b90-4148-8ba8-1478dbc8cfaf"), "Mustafa", new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5968), true, 26598171, "Yizlam Goney", null, null }
                });

            migrationBuilder.InsertData(
                table: "BookTransaction",
                columns: new[] { "ISBN", "MemberId", "CreatedBy", "CreatedDate", "DueTo", "Id", "IsActive", "ReturnDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "978-0-393-04052-9", 26598171, null, new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(6001), new DateTime(2023, 2, 6, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(6003), new Guid("fae5dd3d-6cb3-4bd3-9f5b-d3607dfc4561"), false, null, null, null },
                    { "978-0-393-04022-9", 29182029, null, new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 2, 6, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5996), new Guid("c505c6e1-c0cb-4692-a463-5395618324f8"), false, null, null, null },
                    { "978-0-393-04002-9", 42323190, null, new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5974), new DateTime(2023, 2, 6, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5977), new Guid("a31302d4-cc44-4775-919e-9d3aa389629b"), false, null, null, null }
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
