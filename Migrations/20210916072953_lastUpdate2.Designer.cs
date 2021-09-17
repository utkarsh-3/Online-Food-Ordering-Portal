﻿// <auto-generated />
using System;
using EatFit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EatFit.Migrations
{
    [DbContext(typeof(FoodItemDbContext))]
    [Migration("20210916072953_lastUpdate2")]
    partial class lastUpdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EatFit.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Breakfast",
                            Description = "The most important meal of the day !"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Lunch",
                            Description = "The most heaviest meal of the day !"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Dinner",
                            Description = "The most light meal of the day !"
                        });
                });

            modelBuilder.Entity("EatFit.Models.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("FoodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVeg")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ratings")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Dinner",
                            Cost = 150,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Popcorn.jpg",
                            IsVeg = true,
                            LongDescription = "Available with add-on of cheese salt and other flavours",
                            Name = "Popcorn",
                            Ratings = 3.3999999999999999,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Lunch",
                            Cost = 100,
                            FoodType = "Dessert",
                            ImageUrl = "/img/Doughnut.jpg",
                            IsVeg = true,
                            LongDescription = "Available in all flavours and customized as per request",
                            Name = "Doughnut",
                            Ratings = 4.4000000000000004,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Dinner",
                            Cost = 600,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Pizza.jpg",
                            IsVeg = true,
                            LongDescription = "Prepared with this and that",
                            Name = "Pizza",
                            Ratings = 4.0,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Lunch",
                            Cost = 300,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Burger.jpg",
                            IsVeg = false,
                            LongDescription = "Prepared with this and that",
                            Name = "Burger",
                            Ratings = 3.7999999999999998,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Lunch",
                            Cost = 140,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Ribs.jpg",
                            IsVeg = false,
                            LongDescription = "Prepared with this and that",
                            Name = "Ribs",
                            Ratings = 5.0,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Breakfast",
                            Cost = 200,
                            FoodType = "Drink",
                            ImageUrl = "/img/Milkshake.jpg",
                            IsVeg = true,
                            LongDescription = "Number of healthy fruits like Kiwi, apple etc",
                            Name = "Milkshake",
                            Ratings = 4.9000000000000004,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Lunch",
                            Cost = 240,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Oyster.jpg",
                            IsVeg = false,
                            LongDescription = "Prepared with this and that",
                            Name = "Oyster",
                            Ratings = 4.5999999999999996,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Lunch",
                            Cost = 340,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Soup.jpg",
                            IsVeg = true,
                            LongDescription = "Prepared with this and that",
                            Name = "Soup",
                            Ratings = 3.5,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Dinner",
                            Cost = 340,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Spagetti.jpg",
                            IsVeg = true,
                            LongDescription = "Prepared with this and that",
                            Name = "Spagetti",
                            Ratings = 2.5,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 10,
                            CategoryName = "Lunch",
                            Cost = 540,
                            FoodType = "Lunch",
                            ImageUrl = "/img/Shrimps.jpg",
                            IsVeg = false,
                            LongDescription = "Prepared with this and that",
                            Name = "Shrimp Noodles",
                            Ratings = 3.7000000000000002,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 11,
                            CategoryName = "Breakfast",
                            Cost = 360,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Rolls.jpg",
                            IsVeg = false,
                            LongDescription = "Prepared with this and that",
                            Name = "Rolls",
                            Ratings = 5.0,
                            ShortDescription = " Delicious and Awsome !"
                        },
                        new
                        {
                            Id = 12,
                            CategoryName = "Lunch",
                            Cost = 140,
                            FoodType = "Snacks",
                            ImageUrl = "/img/Noodles.jpg",
                            IsVeg = false,
                            LongDescription = "Customize the dish",
                            Name = "Noodles",
                            Ratings = 4.0999999999999996,
                            ShortDescription = " Delicious and Awsome !"
                        });
                });

            modelBuilder.Entity("EatFit.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EatFit.Models.ShoppingCartItems", b =>
                {
                    b.Property<int>("ShoppingCartItemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("foodItemId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemid");

                    b.HasIndex("foodItemId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("EatFit.Models.FoodItem", b =>
                {
                    b.HasOne("EatFit.Models.Category", "Category")
                        .WithMany("FoodItems")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("EatFit.Models.ShoppingCartItems", b =>
                {
                    b.HasOne("EatFit.Models.FoodItem", "foodItem")
                        .WithMany()
                        .HasForeignKey("foodItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
