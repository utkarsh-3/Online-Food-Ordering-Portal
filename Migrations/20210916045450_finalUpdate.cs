using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EatFit.Migrations
{
    public partial class finalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 10, nullable: false),
                    LastName = table.Column<string>(maxLength: 10, nullable: false),
                    Address1 = table.Column<string>(maxLength: 10, nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(maxLength: 6, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 25, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FoodType", "ShortDescription" },
                values: new object[] { "Snacks", " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: " Delicious and Awsome !");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: " Delicious and Awsome !");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ratings", "ShortDescription" },
                values: new object[] { 3.7999999999999998, " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cost", "FoodType", "ShortDescription" },
                values: new object[] { 140, "Snacks", " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Ratings", "ShortDescription" },
                values: new object[] { 4.9000000000000004, " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cost", "FoodType", "Ratings", "ShortDescription" },
                values: new object[] { 240, "Snacks", 4.5999999999999996, " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FoodType", "ShortDescription" },
                values: new object[] { "Snacks", " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cost", "ShortDescription" },
                values: new object[] { 340, " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cost", "ShortDescription" },
                values: new object[] { 540, " Delicious and Awsome !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShortDescription",
                value: " Delicious and Awsome !");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cost", "ShortDescription" },
                values: new object[] { 140, " Delicious and Awsome !" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FoodType", "ShortDescription" },
                values: new object[] { "Snack", "Crispy and Cheesy !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: "Sweet and Delicious ! ");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: "Spicy, Cheesy and mouthful !");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ratings", "ShortDescription" },
                values: new object[] { 5.0, " Spicy" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cost", "FoodType", "ShortDescription" },
                values: new object[] { 1400, "Main Course", " Spicy, crunchy and delicious !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Ratings", "ShortDescription" },
                values: new object[] { 4.5, " Sweet, Delicous and healthy !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cost", "FoodType", "Ratings", "ShortDescription" },
                values: new object[] { 2400, "Lunch", 4.5, " Spicy, tasty and crunchy !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FoodType", "ShortDescription" },
                values: new object[] { "Starter", " Tasty, yummy and delicious !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cost", "ShortDescription" },
                values: new object[] { 3400, " Spicy, tasty and delicious !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cost", "ShortDescription" },
                values: new object[] { 5400, " Spicy, tasty and delicious !" });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShortDescription",
                value: " Spicy and tasty !");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cost", "ShortDescription" },
                values: new object[] { 1400, "Delicious and awsome !" });
        }
    }
}
