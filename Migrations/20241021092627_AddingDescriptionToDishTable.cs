using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoNaObiadAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingDescriptionToDishTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), new Guid("f350e1a0-38de-42fe-ada5-ae436378ee5b") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("40563e5b-e538-4084-9587-3df74fae21d4") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("8d5a1b40-6677-4545-b6e8-5ba93efda0a1") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("b5f336e2-c226-4389-aac3-2499325a3de9") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("c22bec27-a880-4f2a-b380-12dcd99c61fe") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), new Guid("b5f336e2-c226-4389-aac3-2499325a3de9") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") });

            migrationBuilder.DeleteData(
                table: "DishTag",
                keyColumns: new[] { "DishesId", "TagsId" },
                keyValues: new object[] { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), new Guid("fef8b722-664d-403f-ae3c-05f8ed7d7a1f") });

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("fd630a57-2352-4731-b25c-db9cc7601b16"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aab31c70-57ce-4b6d-a66c-9c1b094e915d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40563e5b-e538-4084-9587-3df74fae21d4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8d5a1b40-6677-4545-b6e8-5ba93efda0a1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b5f336e2-c226-4389-aac3-2499325a3de9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c22bec27-a880-4f2a-b380-12dcd99c61fe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f350e1a0-38de-42fe-ada5-ae436378ee5b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fef8b722-664d-403f-ae3c-05f8ed7d7a1f"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dishes",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dishes");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), "Quesadilla z kurczakiem i warzywami" },
                    { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), "Zupa pomidorowa" },
                    { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), "Zapiekanka z kurczaka i brokulow" },
                    { new Guid("fd630a57-2352-4731-b25c-db9cc7601b16"), "Gulasz wieprzowo-wolowy" },
                    { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), "Makaron penne z cukinią i szparagami" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"), "caly rok" },
                    { new Guid("40563e5b-e538-4084-9587-3df74fae21d4"), "pomidory" },
                    { new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc"), "dla gosci" },
                    { new Guid("8d5a1b40-6677-4545-b6e8-5ba93efda0a1"), "zupa" },
                    { new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6"), "dla dzieci" },
                    { new Guid("aab31c70-57ce-4b6d-a66c-9c1b094e915d"), "zdrowo" },
                    { new Guid("b5f336e2-c226-4389-aac3-2499325a3de9"), "makaron" },
                    { new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40"), "jesien" },
                    { new Guid("c22bec27-a880-4f2a-b380-12dcd99c61fe"), "zapiekanka" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "lato" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "wiosna" },
                    { new Guid("f350e1a0-38de-42fe-ada5-ae436378ee5b"), "comfort food" },
                    { new Guid("fef8b722-664d-403f-ae3c-05f8ed7d7a1f"), "wege" }
                });

            migrationBuilder.InsertData(
                table: "DishTag",
                columns: new[] { "DishesId", "TagsId" },
                values: new object[,]
                {
                    { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b") },
                    { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc") },
                    { new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"), new Guid("f350e1a0-38de-42fe-ada5-ae436378ee5b") },
                    { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b") },
                    { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("40563e5b-e538-4084-9587-3df74fae21d4") },
                    { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("8d5a1b40-6677-4545-b6e8-5ba93efda0a1") },
                    { new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"), new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6") },
                    { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6") },
                    { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("b5f336e2-c226-4389-aac3-2499325a3de9") },
                    { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("c22bec27-a880-4f2a-b380-12dcd99c61fe") },
                    { new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35") },
                    { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), new Guid("b5f336e2-c226-4389-aac3-2499325a3de9") },
                    { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") },
                    { new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), new Guid("fef8b722-664d-403f-ae3c-05f8ed7d7a1f") }
                });
        }
    }
}
