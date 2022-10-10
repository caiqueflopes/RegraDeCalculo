using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class novastabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Calculos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Calculos",
                newName: "nome_campanha");

            migrationBuilder.RenameColumn(
                name: "Done",
                table: "Calculos",
                newName: "comissao_pasch");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Calculos",
                newName: "data_inserido");

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "Calculos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "juros_simples",
                table: "Calculos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "juros_total",
                table: "Calculos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "porcentagem_desconto_permitido",
                table: "Calculos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo",
                table: "Calculos");

            migrationBuilder.DropColumn(
                name: "juros_simples",
                table: "Calculos");

            migrationBuilder.DropColumn(
                name: "juros_total",
                table: "Calculos");

            migrationBuilder.DropColumn(
                name: "porcentagem_desconto_permitido",
                table: "Calculos");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Calculos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome_campanha",
                table: "Calculos",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "data_inserido",
                table: "Calculos",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "comissao_pasch",
                table: "Calculos",
                newName: "Done");
        }
    }
}
