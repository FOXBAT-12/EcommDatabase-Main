﻿// <auto-generated />
using Ecomm_Database_Class.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecomm_Database_Class.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250406195403_f6")]
    partial class f6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecomm_Database_Class.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Luxury"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Casual"
                        });
                });

            modelBuilder.Entity("Ecomm_Database_Class.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SoldCount")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoryId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CategoryId1");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("SubCategoryId1");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Omega",
                            CategoryId = 1,
                            Description = "Luxury dive watch",
                            ImageUrl = "",
                            Name = "Omega Seamaster",
                            Price = 2999.99m,
                            Quantity = 0,
                            SoldCount = 120,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Casio",
                            CategoryId = 2,
                            Description = "Rugged digital watch",
                            ImageUrl = "",
                            Name = "Casio G-Shock",
                            Price = 149.99m,
                            Quantity = 0,
                            SoldCount = 500,
                            SubCategoryId = 2
                        });
                });

            modelBuilder.Entity("Ecomm_Database_Class.Model.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Analog"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "Digital"
                        });
                });

            modelBuilder.Entity("Ecomm_Database_Class.Model.Product", b =>
                {
                    b.HasOne("Ecomm_Database_Class.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecomm_Database_Class.Model.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId1");

                    b.HasOne("Ecomm_Database_Class.Model.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ecomm_Database_Class.Model.SubCategory", null)
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId1");

                    b.Navigation("Category");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Ecomm_Database_Class.Model.SubCategory", b =>
                {
                    b.HasOne("Ecomm_Database_Class.Model.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ecomm_Database_Class.Model.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Ecomm_Database_Class.Model.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
