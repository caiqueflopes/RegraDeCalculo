using backendcflopes.Models;
using Microsoft.EntityFrameworkCore;

namespace backendcflopes.Data
{
    //Representação do Banco
    public class AppDbContext: DbContext
    {
        //Representação das Tabelas
        public DbSet<Calculo> Calculos { get; set; }
        public DbSet<Acordo> Acordos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }
        


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");

    }


}
