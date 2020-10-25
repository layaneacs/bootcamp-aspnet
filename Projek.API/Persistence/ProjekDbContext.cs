using Microsoft.EntityFrameworkCore;
using projek.api.Entidades;

namespace projek.api.Persistence
{
    public class ProjekDbContext: DbContext
    {
        public ProjekDbContext(DbContextOptions<ProjekDbContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Linguagem> Linguagens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                    .HasKey(a => a.Id);

            builder.Entity<Usuario>()
                    .HasMany(a => a.Projetos)
                    .WithMany(a => a.Usuarios); 

            builder.Entity<Projeto>()                
                    .HasKey(a => a.Id);

            builder.Entity<Projeto>()
                   .HasMany(a => a.Usuarios)
                   .WithMany(a => a.Projetos);                   

            builder.Entity<Linguagem>()                
                    .HasKey(a => a.Id);
        }
    }
}