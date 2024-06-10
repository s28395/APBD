using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Muzyk",
                columns: new[] { "IdMuzyk", "Imie", "Nazwisko", "Pseudonim" },
                values: new object[,]
                {
                    { 1, "Yehor", "Vasylenko", "ews" },
                    { 2, "Alex", "Jaronkiewic", "awic" },
                    { 3, "Oliwia", "Mazur", "olizur" }
                });

            migrationBuilder.InsertData(
                table: "Utwor",
                columns: new[] { "IdUtwor", "CzasTrwania", "IdAlbum", "NazwaUtworu" },
                values: new object[,]
                {
                    { 1, 999999f, null, "Pan Tadeusz" },
                    { 2, 1.5f, null, "1984" },
                    { 3, 4f, null, "Jane Eir" },
                    { 4, 14.5f, null, "Harry Potter" },
                    { 5, 7.8f, null, "The Ford" },
                    { 6, 3.4f, null, "The Return" },
                    { 7, 2.1f, null, "Lord of the rings" },
                    { 8, 2.5f, null, "Pure and Rich Dad" },
                    { 9, 7.9f, null, "Pluca Zlepione Topami" },
                    { 10, 12.7f, null, "Wonderfull Day" }
                });

            migrationBuilder.InsertData(
                table: "WykonawcaUtworu",
                columns: new[] { "IdMuzyk", "IdUtwor" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Muzyk",
                keyColumn: "IdMuzyk",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Muzyk",
                keyColumn: "IdMuzyk",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Muzyk",
                keyColumn: "IdMuzyk",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 10);
        }
    }
}
