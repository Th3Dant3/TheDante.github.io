using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LevelUpInventorySystem.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Inventory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Inventory", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Explore incredible places far from the Mushroom Kingdom", 10, "Super Mario Odyssey", 49.99m },
                    { 2, "Discover Hyrule like never before", 8, "The Legend of Zelda: Breath of the Wild", 59.99m },
                    { 3, "Join Kratos on a deep and reflective journey", 12, "God of War", 39.99m },
                    { 4, "Experience an epic tale of life in America's unforgiving heartland", 6, "Red Dead Redemption 2", 49.99m },
                    { 5, "Drop into a massive online battle with up to 100 players", 15, "Fortnite: Battle Royale", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
