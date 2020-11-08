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
        //--Criar
        public Usuario Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;

        }
        //--Deletar
        public void Delete(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
        //--Listar todos
        public List<Usuario> GetAll()
        {
            var usuarios = _context.Usuarios
                .Include(c => c.Projetos)
                .Include(c => c.Linguagens)
                .ToList();

            return usuarios;
        }
        //- Buscar por id
        public Usuario GetId(int id)
        {
            var usuario = _context.Usuarios
                .Include(c => c.Projetos)
                .Include(c => c.Linguagens)
                .SingleOrDefault(c => c.UsuarioId == id);
                
            return usuario;            
        }

        public void Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}