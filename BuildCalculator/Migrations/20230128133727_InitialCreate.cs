using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildCalculator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "itemClasses",
                columns: table => new
                {
                    itemClassId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemClasses", x => x.itemClassId);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    itemClassId = table.Column<int>(type: "INTEGER", nullable: false),
                    nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    sila = table.Column<int>(type: "INTEGER", nullable: true),
                    zreka = table.Column<int>(type: "INTEGER", nullable: true),
                    moc = table.Column<int>(type: "INTEGER", nullable: true),
                    wiedza = table.Column<int>(type: "INTEGER", nullable: true),
                    hp = table.Column<int>(type: "INTEGER", nullable: true),
                    mana = table.Column<int>(type: "INTEGER", nullable: true),
                    konda = table.Column<int>(type: "INTEGER", nullable: true),
                    sieczne = table.Column<int>(type: "INTEGER", nullable: true),
                    obuch = table.Column<int>(type: "INTEGER", nullable: true),
                    klute = table.Column<int>(type: "INTEGER", nullable: true),
                    ogien = table.Column<int>(type: "INTEGER", nullable: true),
                    energia = table.Column<int>(type: "INTEGER", nullable: true),
                    zimno = table.Column<int>(type: "INTEGER", nullable: true),
                    urok = table.Column<int>(type: "INTEGER", nullable: true),
                    dmg = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_items_itemClasses_itemClassId",
                        column: x => x.itemClassId,
                        principalTable: "itemClasses",
                        principalColumn: "itemClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 1, "zbroja" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 2, "helm" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 3, "naszyjnik" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 4, "rekawice" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 5, "bron" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 6, "tarcza" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 7, "pas" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 8, "buty" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 9, "pierscien" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 10, "spodnie" });

            migrationBuilder.InsertData(
                table: "itemClasses",
                columns: new[] { "itemClassId", "name" },
                values: new object[] { 11, "peleryna" });

            migrationBuilder.CreateIndex(
                name: "IX_items_itemClassId",
                table: "items",
                column: "itemClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "itemClasses");
        }
    }
}
