﻿// <auto-generated />
using System;
using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpenseTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ExpenseTracker.Models.ExpenseCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("expense_category", (string)null);
                });

            modelBuilder.Entity("ExpenseTracker.Models.IncomeCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("income_category", (string)null);
                });

            modelBuilder.Entity("ExpenseTracker.Models.Store", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("store", (string)null);
                });

            modelBuilder.Entity("ExpenseTracker.Models.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amout")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("amount");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("record_date");

                    b.HasKey("ID");

                    b.ToTable("transaction", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("ExpenseTracker.Models.Expense", b =>
                {
                    b.HasBaseType("ExpenseTracker.Models.Transaction");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("StoreID")
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("StoreID");

                    b.ToTable("expense", (string)null);
                });

            modelBuilder.Entity("ExpenseTracker.Models.Income", b =>
                {
                    b.HasBaseType("ExpenseTracker.Models.Transaction");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.HasIndex("CategoryID");

                    b.ToTable("income", (string)null);
                });

            modelBuilder.Entity("ExpenseTracker.Models.Expense", b =>
                {
                    b.HasOne("ExpenseTracker.Models.ExpenseCategory", "ExpenseCategory")
                        .WithMany("Expenses")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseTracker.Models.Transaction", null)
                        .WithOne()
                        .HasForeignKey("ExpenseTracker.Models.Expense", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseTracker.Models.Store", "Store")
                        .WithMany("Expenses")
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseCategory");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("ExpenseTracker.Models.Income", b =>
                {
                    b.HasOne("ExpenseTracker.Models.IncomeCategory", "IncomeCategory")
                        .WithMany("Incomes")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseTracker.Models.Transaction", null)
                        .WithOne()
                        .HasForeignKey("ExpenseTracker.Models.Income", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomeCategory");
                });

            modelBuilder.Entity("ExpenseTracker.Models.ExpenseCategory", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("ExpenseTracker.Models.IncomeCategory", b =>
                {
                    b.Navigation("Incomes");
                });

            modelBuilder.Entity("ExpenseTracker.Models.Store", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
