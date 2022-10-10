using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class ajuste_parcela_err : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "valor_parcela_original",
                table: "Parcelas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor_parcela_original",
                table: "Parcelas");
        }
    }
}
