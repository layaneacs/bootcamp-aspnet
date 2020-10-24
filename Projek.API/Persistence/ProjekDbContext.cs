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

        protected override void OnModelCreating(ModelBuilder builder){
           
        }
    }
}