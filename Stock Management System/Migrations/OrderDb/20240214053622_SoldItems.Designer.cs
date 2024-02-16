﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock_Management_System.Controllers.Data;

#nullable disable

namespace Stock_Management_System.Migrations.OrderDb
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20240214053622_SoldItems")]
    partial class SoldItems
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Stock_Management_System.Models.SellItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Address")
                        .HasColumnType("int");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Items")
                        .HasColumnType("int");

                    b.Property<long>("Phone_Number")
                        .HasColumnType("bigint");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Product_Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SoldItems");
                });
#pragma warning restore 612, 618
        }
    }
}