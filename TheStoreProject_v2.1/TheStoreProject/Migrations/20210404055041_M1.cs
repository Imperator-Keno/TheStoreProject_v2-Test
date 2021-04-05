using Microsoft.EntityFrameworkCore.Migrations;

namespace TheStoreProject.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CATEGORY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CATEGORY_ID);
                });

            migrationBuilder.CreateTable(
                name: "itemMasters",
                columns: table => new
                {
                    CATEGORY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_UPC = table.Column<int>(type: "int", nullable: false),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_CATEGORY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INNER_PACK_QTY = table.Column<int>(type: "int", nullable: false),
                    RETAIL_PRICE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DISCOUNT_PERCENTAGE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SUPPLIER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUPPLIER_ID = table.Column<int>(type: "int", nullable: false),
                    BUYER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUYER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemMasters", x => x.CATEGORY_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "itemMasters");
        }
    }
}
