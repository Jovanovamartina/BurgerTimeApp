﻿// <auto-generated />
using System;
using BurgerTimeApp.DataAccsess.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerTimeApp.DataAccsess.Migrations
{
    [DbContext(typeof(BurgerDbContext))]
    partial class BurgerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Burgers");
                });

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BurgerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelievered")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Burger", b =>
                {
                    b.HasOne("BurgerTimeApp.Domain.Entities.Order", null)
                        .WithMany("Burgers")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Ingredient", b =>
                {
                    b.HasOne("BurgerTimeApp.Domain.Entities.Burger", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("BurgerId");
                });

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Burger", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("BurgerTimeApp.Domain.Entities.Order", b =>
                {
                    b.Navigation("Burgers");
                });
#pragma warning restore 612, 618
        }
    }
}
