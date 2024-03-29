﻿// <auto-generated />
using System;
using LibraryManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagement.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221225090501_init-migration")]
    partial class initmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagement.Domain.Domain.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ISBN")
                        .IsUnique();

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ff079dc8-8790-49e7-b99a-257132fe4a78"),
                            Author = "Rob Delaney",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1521),
                            Description = "",
                            ISBN = "978-0-393-04002-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "A Heart That Works"
                        },
                        new
                        {
                            Id = new Guid("b432d3cf-270c-4560-9e40-eb44c466532e"),
                            Author = "Abdulrazak Gurnah",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1560),
                            Description = "",
                            ISBN = "978-0-393-04012-9 ",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Afterlives"
                        },
                        new
                        {
                            Id = new Guid("2bcd531c-e476-47e5-8f3f-252e2c5dc6e9"),
                            Author = "Maud Newton",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1564),
                            Description = "",
                            ISBN = "978-0-393-04022-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Ancestor Trouble"
                        },
                        new
                        {
                            Id = new Guid("b4d58bf1-3279-4a8f-a846-c59be50465d3"),
                            Author = "Nuar Alsadir",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1581),
                            Description = "",
                            ISBN = "978-0-393-04032-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Animal Joy"
                        },
                        new
                        {
                            Id = new Guid("1696897e-6865-41d0-bb06-b4e4c0a5bc55"),
                            Author = "R.F. Kuang",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1585),
                            Description = "",
                            ISBN = "978-0-393-04052-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Babel"
                        });
                });

            modelBuilder.Entity("LibraryManagement.Domain.Domain.BookTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ISBN");

                    b.HasIndex("MemberId");

                    b.ToTable("BookTransaction", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e05f7702-d511-44ac-b87c-e57433f1b2ff"),
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1679),
                            DueTo = new DateTime(2023, 2, 6, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1682),
                            ISBN = "978-0-393-04002-9",
                            IsActive = false,
                            MemberId = 30942370
                        },
                        new
                        {
                            Id = new Guid("35d551d1-145a-4db2-89be-c4ce7d3d3bc7"),
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1697),
                            DueTo = new DateTime(2023, 2, 6, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1699),
                            ISBN = "978-0-393-04022-9",
                            IsActive = false,
                            MemberId = 98716652
                        },
                        new
                        {
                            Id = new Guid("45ac38af-b8fa-4a59-a11f-bfc796e583dc"),
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1703),
                            DueTo = new DateTime(2023, 2, 6, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1705),
                            ISBN = "978-0-393-04052-9",
                            IsActive = false,
                            MemberId = 61655157
                        });
                });

            modelBuilder.Entity("LibraryManagement.Domain.Domain.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("Member", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1384efb8-cc28-494c-a869-6f7739dbc135"),
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1625),
                            IsActive = true,
                            MemberId = 30942370,
                            MemberName = "Ali Koc"
                        },
                        new
                        {
                            Id = new Guid("f8f63b53-4306-4cba-be67-a0a6dcd2de8c"),
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1649),
                            IsActive = true,
                            MemberId = 98716652,
                            MemberName = "Sara yilmaz"
                        },
                        new
                        {
                            Id = new Guid("09be3b87-6c38-4397-bf0f-afefc0ebd0b3"),
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 25, 12, 35, 0, 952, DateTimeKind.Local).AddTicks(1673),
                            IsActive = true,
                            MemberId = 61655157,
                            MemberName = "Yizlam Goney"
                        });
                });

            modelBuilder.Entity("LibraryManagement.Domain.Domain.BookTransaction", b =>
                {
                    b.HasOne("LibraryManagement.Domain.Domain.Book", "Book")
                        .WithMany("BookTransactions")
                        .HasForeignKey("ISBN")
                        .HasPrincipalKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement.Domain.Domain.Member", "Member")
                        .WithMany("BookTransactions")
                        .HasForeignKey("MemberId")
                        .HasPrincipalKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("LibraryManagement.Domain.Domain.Book", b =>
                {
                    b.Navigation("BookTransactions");
                });

            modelBuilder.Entity("LibraryManagement.Domain.Domain.Member", b =>
                {
                    b.Navigation("BookTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
