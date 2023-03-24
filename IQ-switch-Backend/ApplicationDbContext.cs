using IQ_switch_Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IQ_switch_Backend
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Elemento> Elementos { get; set; }
    }
}
