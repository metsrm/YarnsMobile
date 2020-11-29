﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YarnsMobile.Database;

namespace YarnsMobile.Migrations
{
    [DbContext(typeof(YarnsMobileContext))]
    [Migration("20201128204749_BookUpdates")]
    partial class BookUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YarnsMobile.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressName")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("UnitNumber");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("YarnsMobile.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<int>("CopyrightYear");

                    b.Property<decimal>("CurrentPrice");

                    b.Property<string>("ISBN")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("ImageMimeType");

                    b.Property<byte[]>("PhotoFile");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("YarnsMobile.Models.Member", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AccountNumberPrefix");

                    b.Property<int>("AccountNumberSuffix");

                    b.Property<int?>("AddressId");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("YarnsMobile.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MemberId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("YarnsMobile.Models.PurchasedBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId");

                    b.Property<string>("MemberId");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<decimal>("PurchasePrice");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("PurchasedBooks");
                });

            modelBuilder.Entity("YarnsMobile.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("MemberId");

                    b.Property<int>("Rating");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("YarnsMobile.Models.Member", b =>
                {
                    b.HasOne("YarnsMobile.Models.Address", "Address")
                        .WithMany("Members")
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("YarnsMobile.Models.Phone", b =>
                {
                    b.HasOne("YarnsMobile.Models.Member", "Member")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("YarnsMobile.Models.PurchasedBook", b =>
                {
                    b.HasOne("YarnsMobile.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("YarnsMobile.Models.Member", "Member")
                        .WithMany("PurchasedBooks")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("YarnsMobile.Models.Review", b =>
                {
                    b.HasOne("YarnsMobile.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId");

                    b.HasOne("YarnsMobile.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");
                });
#pragma warning restore 612, 618
        }
    }
}
