using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EatFit.Models
{
    public class FoodItemDbContext : DbContext
    {
        public FoodItemDbContext(DbContextOptions<FoodItemDbContext> options) : base(options)
        {

        }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Breakfast", Description = "The most important meal of the day !" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Lunch", Description = "The most heaviest meal of the day !" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Dinner", Description = "The most light meal of the day !" });
            modelBuilder.Entity<FoodItem>().HasData(
                new FoodItem
                {
                    Id = 1,
                    Name = "Popcorn",
                    Cost = 150,
                    IsVeg = true,
                    FoodType="Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Available with add-on of cheese salt and other flavours",
                    CategoryName = "Dinner",
                    Ratings = 3.4,
                    ImageUrl = "/img/Popcorn.jpg"
                },
                new FoodItem
                {
                    Id = 2,
                    Name = "Doughnut",
                    Cost = 100,
                    IsVeg = true,
                    FoodType="Dessert",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Available in all flavours and customized as per request",
                    CategoryName = "Lunch",
                    Ratings = 4.4,
                    ImageUrl = "/img/Doughnut.jpg"
                },

                new FoodItem
                {
                    Id = 3,
                    Name = "Pizza",
                    Cost = 600,
                    IsVeg = true,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Dinner",
                    Ratings = 4,
                    ImageUrl = "/img/Pizza.jpg"
                },

                new FoodItem
                {
                    Id = 4,
                    Name = "Burger",
                    Cost = 300,
                    IsVeg = false,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Lunch",
                    Ratings = 3.8,
                    ImageUrl = "/img/Burger.jpg"
                },
                new FoodItem
                {
                    Id = 5,
                    Name = "Ribs",
                    Cost = 140,
                    IsVeg = false,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Lunch",
                    Ratings = 5,
                    ImageUrl = "/img/Ribs.jpg"
                },
                new FoodItem
                {
                    Id = 6,
                    Name = "Milkshake",
                    Cost = 200,
                    IsVeg = true,
                    FoodType = "Drink",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Number of healthy fruits like Kiwi, apple etc",
                    CategoryName = "Breakfast",
                    Ratings = 4.9,
                    ImageUrl = "/img/Milkshake.jpg"
                },
                new FoodItem
                {
                    Id = 7,
                    Name = "Oyster",
                    Cost = 240,
                    IsVeg = false,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Lunch",
                    Ratings = 4.6,
                    ImageUrl = "/img/Oyster.jpg"
                },
                new FoodItem
                {
                    Id = 8,
                    Name = "Soup",
                    Cost = 340,
                    IsVeg = true,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Lunch",
                    Ratings = 3.5,
                    ImageUrl = "/img/Soup.jpg"
                },
                new FoodItem
                {
                    Id = 9,
                    Name = "Spagetti",
                    Cost = 340,
                    IsVeg = true,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Dinner",
                    Ratings = 2.5,
                    ImageUrl = "/img/Spagetti.jpg"
                },
                new FoodItem
                {
                    Id = 10,
                    Name = "Shrimp Noodles",
                    Cost = 540,
                    IsVeg = false,
                    FoodType = "Lunch",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Lunch",
                    Ratings = 3.7,
                    ImageUrl = "/img/Shrimps.jpg"
                },
                new FoodItem
                {
                    Id =11,
                    Name = "Rolls",
                    Cost = 360,
                    IsVeg = false,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Prepared with this and that",
                    CategoryName = "Breakfast",
                    Ratings = 5,
                    ImageUrl = "/img/Rolls.jpg"
                },
                new FoodItem
                {
                    Id = 12,
                    Name = "Noodles",
                    Cost = 140,
                    IsVeg = false,
                    FoodType = "Snacks",
                    ShortDescription = " Delicious and Awsome !",
                    LongDescription = "Customize the dish",
                    CategoryName = "Lunch",
                    Ratings = 4.1,
                    ImageUrl = "/img/Noodles.jpg"

                });
            
        }
    }
}