﻿// <auto-generated />
using System;
using LoanApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoanApplication.Migrations
{
    [DbContext(typeof(LoanAppDbContext))]
    [Migration("20230313130314_update_application_model")]
    partial class update_application_model
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoanApplication.Models.AppData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5295),
                            DataType = "string",
                            Name = "Title",
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5296),
                            Value = "Mr."
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5298),
                            DataType = "string",
                            Name = "Title",
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5298),
                            Value = "Ms."
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5300),
                            DataType = "string",
                            Name = "Title",
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5300),
                            Value = "Mrs."
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5302),
                            DataType = "decimal",
                            Name = "EstablishmentFee",
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5303),
                            Value = "300"
                        });
                });

            modelBuilder.Entity("LoanApplication.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("EstablishmentFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FinanceAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RepaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("LoanApplication.Models.BlackList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("BlackLists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5166),
                            Type = "Mobile",
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5174),
                            Value = "09191111222"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5176),
                            Type = "Domain",
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5176),
                            Value = "mail"
                        });
                });

            modelBuilder.Entity("LoanApplication.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("LoanApplication.Models.LoanInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountRequired")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("LoanInfos");
                });

            modelBuilder.Entity("LoanApplication.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("APRPeriod")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MinimumDuration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("NoInterestFree")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            APRPeriod = 0,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5325),
                            Description = "The loan is interest-free",
                            InterestRate = 0m,
                            MinimumDuration = 0,
                            Name = "Product A",
                            NoInterestFree = false,
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5326)
                        },
                        new
                        {
                            Id = 2,
                            APRPeriod = 2,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5329),
                            Description = "The first 2 months is free",
                            InterestRate = 6m,
                            MinimumDuration = 6,
                            Name = "ProductB",
                            NoInterestFree = false,
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5329)
                        },
                        new
                        {
                            Id = 3,
                            APRPeriod = 0,
                            CreatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5331),
                            Description = "No Interest Free",
                            InterestRate = 6m,
                            MinimumDuration = 0,
                            Name = "ProductC",
                            NoInterestFree = true,
                            UpdatedDate = new DateTime(2023, 3, 13, 21, 3, 14, 226, DateTimeKind.Local).AddTicks(5332)
                        });
                });

            modelBuilder.Entity("LoanApplication.Models.LoanInfo", b =>
                {
                    b.HasOne("LoanApplication.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
