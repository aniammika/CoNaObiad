using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoNaObiadAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingpreparationtime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreparationTimeId",
                table: "Dishes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PreparationTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreparationTime", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PreparationTime",
                columns: new[] { "Id", "Time" },
                values: new object[,]
                {
                    { 1, "Fast" },
                    { 2, "Medium" },
                    { 3, "Slow" },
                    { 4, "Extra-slow" }
                });

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Winter");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Spring");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Summer");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Autumn");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_PreparationTimeId",
                table: "Dishes",
                column: "PreparationTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_PreparationTime_PreparationTimeId",
                table: "Dishes",
                column: "PreparationTimeId",
                principalTable: "PreparationTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_PreparationTime_PreparationTimeId",
                table: "Dishes");

            migrationBuilder.DropTable(
                name: "PreparationTime");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_PreparationTimeId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "PreparationTimeId",
                table: "Dishes");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Zima");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Wiosna");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Lato");

            migrationBuilder.UpdateData(
                table: "Season",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Jesień");
        }
    }
}
