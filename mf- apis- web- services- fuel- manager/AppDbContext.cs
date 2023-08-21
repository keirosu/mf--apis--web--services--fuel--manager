using mf__apis__web__services__fuel__manager.Models;
using Microsoft.EntityFrameworkCore;

namespace mf__apis__web__services__fuel__manager
{
    public class AppDbContext  : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Veiculo>Veiculos  { get; set; }

        public DbSet<Consumo>Consumos { get; set; }
    }
}
