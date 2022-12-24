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
    [Migration("20221224114905_init-migration")]
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("6de3d52b-fd3f-4d76-9adb-1cbc8a66d8af"),
                            Author = "Rob Delaney",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5822),
                            Description = "",
                            ISBN = "978-0-393-04002-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "A Heart That Works"
                        },
                        new
                        {
                            Id = new Guid("60e81967-cf9c-4307-91b9-9d2133abda76"),
                            Author = "Abdulrazak Gurnah",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5860),
                            Description = "",
                            ISBN = "978-0-393-04012-9 ",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Afterlives"
                        },
                        new
                        {
                            Id = new Guid("8e92d8e4-3d03-4109-9edb-c470c6f5cb1a"),
                            Author = "Maud Newton",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5873),
                            Description = "",
                            ISBN = "978-0-393-04022-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Ancestor Trouble"
                        },
                        new
                        {
                            Id = new Guid("158bd420-7e23-4123-afcb-b75e789ff869"),
                            Author = "Nuar Alsadir",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5883),
                            Description = "",
                            ISBN = "978-0-393-04032-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Animal Joy"
                        },
                        new
                        {
                            Id = new Guid("e9ae8c4b-8b5f-4246-8eca-1db8a7c4068f"),
                            Author = "R.F. Kuang",
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5886),
                            Description = "",
                            ISBN = "978-0-393-04052-9",
                            IsActive = true,
                            IsAvailable = true,
                            Title = "Babel"
                        });
                });

            modelBuilder.Entity("LibraryManagement.Domain.Domain.BookTransaction", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueTo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MemberId", "ISBN");

                    b.HasIndex("ISBN");

                    b.ToTable("BookTransaction", (string)null);

                    b.HasData(
                        new
                        {
                            MemberId = 42323190,
                            ISBN = "978-0-393-04002-9",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5974),
                            DueTo = new DateTime(2023, 2, 6, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5977),
                            Id = new Guid("a31302d4-cc44-4775-919e-9d3aa389629b"),
                            IsActive = false
                        },
                        new
                        {
                            MemberId = 29182029,
                            ISBN = "978-0-393-04022-9",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5993),
                            DueTo = new DateTime(2023, 2, 6, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5996),
                            Id = new Guid("c505c6e1-c0cb-4692-a463-5395618324f8"),
                            IsActive = false
                        },
                        new
                        {
                            MemberId = 26598171,
                            ISBN = "978-0-393-04052-9",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(6001),
                            DueTo = new DateTime(2023, 2, 6, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(6003),
                            Id = new Guid("fae5dd3d-6cb3-4bd3-9f5b-d3607dfc4561"),
                            IsActive = false
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
                            Id = new Guid("8b2811b2-c80f-497d-b1cc-1b223cd506f8"),
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5923),
                            IsActive = true,
                            MemberId = 42323190,
                            MemberName = "Ali Koc"
                        },
                        new
                        {
                            Id = new Guid("821ef394-d003-4964-a16c-4c93d782b9d5"),
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5948),
                            IsActive = true,
                            MemberId = 29182029,
                            MemberName = "Sara yilmaz"
                        },
                        new
                        {
                            Id = new Guid("b192a145-8b90-4148-8ba8-1478dbc8cfaf"),
                            CreatedBy = "Mustafa",
                            CreatedDate = new DateTime(2022, 12, 24, 15, 19, 5, 323, DateTimeKind.Local).AddTicks(5968),
                            IsActive = true,
                            MemberId = 26598171,
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
