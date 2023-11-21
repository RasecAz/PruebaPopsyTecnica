using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PruebaCoopidrogas.Etityes;

namespace PruebaCoopidrogas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Vehiculo> Vehiculos => Set<Vehiculo>();
        public DbSet<Clientes> clientes => Set<Clientes>();
    }
}
