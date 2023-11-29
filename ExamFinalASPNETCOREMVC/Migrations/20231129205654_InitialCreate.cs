using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamFinalASPNETCOREMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Powerful laptop for work and entertainment", "Laptop", 999.99000000000001 },
                    { 2, "High-end smartphone with advanced features", "Smartphone", 699.99000000000001 },
                    { 3, "Noise-canceling headphones for immersive audio experience", "Headphones", 149.99000000000001 },
                    { 4, "Futuristic backpack equipped with anti-gravity technology", "Rocket Backpack", 249.99000000000001 },
                    { 5, "Magical cloak that renders the wearer invisible", "Invisibility Cloak", 599.99000000000001 },
                    { 6, "Levitating skateboard for an effortless commute", "Hoverboard", 129.99000000000001 },
                    { 7, "AI-powered robotic butler for personalized assistance", "Robot Butler", 1999.99 },
                    { 8, "Immersive VR glasses for virtual adventures", "Virtual Reality Glasses", 299.99000000000001 },
                    { 9, "A self-refilling and infinitely warm bath inspired by Archimedes' principles", "Archimedes' Infinite Bath", 129.99000000000001 },
                    { 10, "A pen that translates your thoughts into Shakespearean sonnets as you write", "Shakespearean Smart Pen", 49.990000000000002 },
                    { 11, "Watch that lets you travel through time and explore different eras", "Time-Traveling Watch", 999.99000000000001 }
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
