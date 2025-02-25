using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlaylistApi.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Album", "Artist", "Category", "Length", "Title" },
                values: new object[,]
                {
                    { 1, "Currents", "Tame Impala", "Indie", 216, "The Less I Know The Better" },
                    { 2, "Rumours", "Fleetwood Mac", "Rock", 256, "Dreams" },
                    { 3, "Arrival", "ABBA", "Pop", 227, "Dancing Queen" },
                    { 4, "A Night at the Opera", "Queen", "Rock", 354, "Bohemian Rhapsody" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
