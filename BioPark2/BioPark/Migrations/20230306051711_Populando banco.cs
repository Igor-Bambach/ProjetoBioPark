using Microsoft.EntityFrameworkCore.Migrations;

namespace BioPark.Migrations
{
    public partial class Populandobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Edificios",
                columns: new[] { "Id", "ApartamentoId", "Nome" },
                values: new object[] { 1, 1, "A" });

            migrationBuilder.InsertData(
                table: "Edificios",
                columns: new[] { "Id", "ApartamentoId", "Nome" },
                values: new object[] { 2, 3, "B" });

            migrationBuilder.InsertData(
                table: "Apartamentos",
                columns: new[] { "ID", "Disponibilidade", "EdificioId", "Locador", "Locatario", "Numero", "Valor" },
                values: new object[,]
                {
                    { 1, false, 1, "Bruno", "BioPark", "25", 560.0 },
                    { 16, false, 2, "Marcio", "BioPark", "16", 945.0 },
                    { 15, true, 2, null, "BioPark", "15", 945.0 },
                    { 14, false, 2, "Maicon", "BioPark", "14", 999.0 },
                    { 13, false, 2, "Aurelio", "BioPark", "13", 905.0 },
                    { 12, true, 2, null, "BioPark", "12", 560.0 },
                    { 11, false, 2, "Bruna", "BioPark", "11", 560.0 },
                    { 10, true, 2, null, "BioPark", "10", 900.0 },
                    { 9, true, 1, null, "BioPark", "13", 400.0 },
                    { 8, true, 1, null, "BioPark", "12", 400.0 },
                    { 7, false, 1, "Marcelo", "BioPark", "77", 650.0 },
                    { 6, true, 1, null, "BioPark", "56", 600.0 },
                    { 5, false, 1, "Antonio", "BioPark", "65", 625.0 },
                    { 4, false, 1, "Gabriela", "BioPark", "110", 800.0 },
                    { 3, false, 1, "Luiza", "BioPark", "84", 700.0 },
                    { 2, false, 1, "Felipe", "BioPark", "55", 600.0 },
                    { 17, false, 2, "Marcio", "BioPark", "17", 330.0 },
                    { 18, true, 2, null, "BioPark", "18", 901.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Apartamentos",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Edificios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Edificios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
