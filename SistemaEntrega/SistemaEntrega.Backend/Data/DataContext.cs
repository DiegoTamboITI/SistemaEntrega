using Microsoft.EntityFrameworkCore;
using SistemaEntrega.Shared.Entitis;

namespace SistemaEntrega.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Coordinador> coordinadores { get; set; }
    }
}