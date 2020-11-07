using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projek.api.Entidades;
using projek.api.Interfaces;
using projek.api.Persistence;

namespace projek.api.Repository
{
    public class UsuarioRepository : IUsuario
    {
        private readonly ProjekDbContext _context;

        public UsuarioRepository(ProjekDbContext context)
        {
            _context = context;
        }

        public Usuario Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;

        }

        public void Delete(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            var usuarios = _context.Usuarios
                .Include(c => c.Projetos)
                .Include(c => c.Linguagens)
                .ToList();

            return usuarios;
        }

        public Usuario GetId(int id)
        {
            var usuario = _context.Usuarios.SingleOrDefault(c => c.UsuarioId == id);
            return usuario;            
        }

        public void Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}