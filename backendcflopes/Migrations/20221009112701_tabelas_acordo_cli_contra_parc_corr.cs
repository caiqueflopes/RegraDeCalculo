using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class tabelas_acordo_cli_contra_parc_corr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculo",
                table: "Calculo");

            migrationBuilder.RenameTable(
                name: "Calculo",
                newName: "Calculos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculos",
                table: "Calculos",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Acordos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_contrato = table.Column<int>(type: "INTEGER", nullable: false),
                    id_cliente = table.Column<int>(type: "INTEGER", nullable: false),
                    id_calculo = table.Column<int>(type: "INTEGER", nullable: false),
                    ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    valor_acordo = table.Column<double>(type: "REAL", nullable: false),
                    valor_juros_acordo = table.Column<double>(type: "REAL", nullable: false),
                    valor_desconto_acordo = table.Column<double>(type: "REAL", nullable: false),
                    data_criado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    data_fechado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acordos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    cpf = table.Column<bool>(type: "INTEGER", nullable: false),
                    telefone = table.Column<string>(type: "TEXT", nullable: true),
                    cep = table.Column<string>(type: "TEXT", nullable: true),
                    uf = table.Column<string>(type: "TEXT", nullable: true),
                    cidade = table.Column<string>(type: "TEXT", nullable: true),
                    data_inserido = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    numero_contrato = table.Column<string>(type: "TEXT", nullable: true),
                    baixado = table.Column<bool>(type: "INTEGER", nullable: false),
                    valor_contrato_cheio = table.Column<double>(type: "REAL", nullable: false),
                    valor_contrato_desconto = table.Column<double>(type: "REAL", nullable: false),
                    id_cliente = table.Column<int>(type: "INTEGER", nullable: false),
                    id_parcela = table.Column<int>(type: "INTEGER", nullable: false),
                    qtd_parcela = table.Column<int>(type: "INTEGER", nullable: false),
                    cep = table.Column<string>(type: "TEXT", nullable: true),
                    uf = table.Column<string>(type: "TEXT", nullable: true),
                    cidade = table.Column<string>(type: "TEXT", nullable: true),
                    telefone = table.Column<string>(type: "TEXT", nullable: true),
                    data_vencimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    data_inserido = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parcela",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_contrato = table.Column<int>(type: "INTEGER", nullable: false),
                    id_cliente = table.Column<int>(type: "INTEGER", nullable: false),
                    numero_parcela = table.Column<string>(type: "TEXT", nullable: true),
                    baixado = table.Column<bool>(type: "INTEGER", nullable: false),
                    valor_parcela_cheio = table.Column<double>(type: "REAL", nullable: false),
                    valor_parcela_desconto = table.Column<double>(type: "REAL", nullable: false),
                    qtd_parcela = table.Column<int>(type: "INTEGER", nullable: false),
                    data_vencimento_parcela = table.Column<DateTime>(type: "TEXT", nullable: false),
                    data_inserido = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcela", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acordos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Parcela");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculos",
                table: "Calculos");

            migrationBuilder.RenameTable(
                name: "Calculos",
                newName: "Calculo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculo",
                table: "Calculo",
                column: "id");
        }
    }
}
