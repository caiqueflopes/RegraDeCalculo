using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class incert_incert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incerts",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data_vencimento = table.Column<string>(type: "TEXT", nullable: true),
                    valor_original = table.Column<string>(type: "TEXT", nullable: true),
                    valor_juros = table.Column<string>(type: "TEXT", nullable: true),
                    quantidade_parcela = table.Column<string>(type: "TEXT", nullable: true),
                    numero_contrato = table.Column<string>(type: "TEXT", nullable: true),
                    data_inserido = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incerts", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incerts");
        }
    }
}
