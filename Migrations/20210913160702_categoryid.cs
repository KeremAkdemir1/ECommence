using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commence.Migrations
{
    public partial class categoryid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeverageCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeverageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeverageCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writing = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "VegetableCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VegetableCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VegetableCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Beverages",
                columns: table => new
                {
                    BeverageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeverageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeveragePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeveragePhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alcohol = table.Column<bool>(type: "bit", nullable: false),
                    BeveragesCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverages", x => x.BeverageId);
                    table.ForeignKey(
                        name: "FK_Beverages_BeverageCategories_BeveragesCategoryId",
                        column: x => x.BeveragesCategoryId,
                        principalTable: "BeverageCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    FoodPhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_FoodCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "FoodCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vegetables",
                columns: table => new
                {
                    VegetableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VegetableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VegetablePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VegetablePhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VegetablesCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetables", x => x.VegetableId);
                    table.ForeignKey(
                        name: "FK_Vegetables_VegetableCategories_VegetablesCategoryId",
                        column: x => x.VegetablesCategoryId,
                        principalTable: "VegetableCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_BeveragesCategoryId",
                table: "Beverages",
                column: "BeveragesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Vegetables_VegetablesCategoryId",
                table: "Vegetables",
                column: "VegetablesCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beverages");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vegetables");

            migrationBuilder.DropTable(
                name: "BeverageCategories");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "VegetableCategories");
        }
    }
}
