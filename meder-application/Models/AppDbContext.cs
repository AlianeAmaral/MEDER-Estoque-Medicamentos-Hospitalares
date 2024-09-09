using Microsoft.EntityFrameworkCore;

namespace MederApplication.Models

{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}


