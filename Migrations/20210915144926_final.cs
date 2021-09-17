using Microsoft.EntityFrameworkCore.Migrations;

namespace EatFit.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FoodType",
                table: "FoodItems",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "FoodType", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 150, "Snack", "/img/Popcorn.jpg", "Available with add-on of cheese salt and other flavours", "Popcorn", "Crispy and Cheesy !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "Cost", "FoodType", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { "Lunch", 100, "Dessert", "/img/Doughnut.jpg", "Available in all flavours and customized as per request", "Doughnut", "Sweet and Delicious ! " });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cost", "FoodType", "ImageUrl", "ShortDescription" },
                values: new object[] { 600, "Snacks", "/img/Pizza.jpg", "Spicy, Cheesy and mouthful !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cost", "FoodType", "ImageUrl" },
                values: new object[] { 300, "Snacks", "/img/Burger.jpg" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CategoryId", "CategoryName", "Cost", "FoodType", "ImageUrl", "IsVeg", "LongDescription", "Name", "Ratings", "ShortDescription" },
                values: new object[,]
                {
                    { 5, null, "Lunch", 1400, "Main Course", "/img/Ribs.jpg", false, "Prepared with this and that", "Ribs", 5.0, " Spicy, crunchy and delicious !" },
                    { 6, null, "Breakfast", 200, "Drink", "/img/Milkshake.jpg", true, "Number of healthy fruits like Kiwi, apple etc", "Milkshake", 4.5, " Sweet, Delicous and healthy !" },
                    { 7, null, "Lunch", 2400, "Lunch", "/img/Oyster.jpg", false, "Prepared with this and that", "Oyster", 4.5, " Spicy, tasty and crunchy !" },
                    { 8, null, "Lunch", 340, "Starter", "/img/Soup.jpg", true, "Prepared with this and that", "Soup", 3.5, " Tasty, yummy and delicious !" },
                    { 9, null, "Dinner", 3400, "Snacks", "/img/Spagetti.jpg", true, "Prepared with this and that", "Spagetti", 2.5, " Spicy, tasty and delicious !" },
                    { 10, null, "Lunch", 5400, "Lunch", "/img/Shrimps.jpg", false, "Prepared with this and that", "Shrimp Noodles", 3.7000000000000002, " Spicy, tasty and delicious !" },
                    { 11, null, "Breakfast", 360, "Snacks", "/img/Rolls.jpg", false, "Prepared with this and that", "Rolls", 5.0, " Spicy and tasty !" },
                    { 12, null, "Lunch", 1400, "Snacks", "/img/Noodles.jpg", false, "Customize the dish", "Noodles", 4.0999999999999996, "Delicious and awsome !" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "FoodType",
                table: "FoodItems");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 140, "/img/pasta.jpg", "Prepared with this and that", "Pasta", "Crispy and Spicy" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "Cost", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { "Breakfast", 400, "/img/poha.jpg", "Prepared with this and that", "Poha", "Yummy " });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cost", "ImageUrl", "ShortDescription" },
                values: new object[] { 1000, "/img/pizza.jpg", "Spicy" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cost", "ImageUrl" },
                values: new object[] { 3400, "/img/burger.jpg" });
        }
    }
}
