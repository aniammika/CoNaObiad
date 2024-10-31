using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoNaObiadAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingseason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DishTag",
                table: "DishTag");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tags",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Dishes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "SeasonId",
                table: "Dishes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TagsId",
                table: "DishTag",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "DishesId",
                table: "DishTag",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DishTag",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishTag",
                table: "DishTag",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Season",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Zima" },
                    { 2, "Wiosna" },
                    { 3, "Lato" },
                    { 4, "Jesień" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_SeasonId",
                table: "Dishes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_DishTag_DishesId",
                table: "DishTag",
                column: "DishesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Season_SeasonId",
                table: "Dishes",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Season_SeasonId",
                table: "Dishes");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_SeasonId",
                table: "Dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishTag",
                table: "DishTag");

            migrationBuilder.DropIndex(
                name: "IX_DishTag_DishesId",
                table: "DishTag");

            migrationBuilder.DropColumn(
                name: "SeasonId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DishTag");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Tags",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Dishes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TagsId",
                table: "DishTag",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "DishesId",
                table: "DishTag",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishTag",
                table: "DishTag",
                columns: new[] { "DishesId", "TagsId" });
        }
    }
}
