using System.Collections.Generic;
using projek.api.Entidades;
using projek.api.Interfaces;
using projek.api.Persistence;

namespace projek.api.Repository
{
    public class ProjetoRepository : IProjeto
    {
        private readonly ProjekDbContext _context;
        public ProjetoRepository(ProjekDbContext context)
        {
            _context = context;
        }

        public Projeto Create(Projeto usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Projeto usuario)
        {
            throw new System.NotImplementedException();
        }

        public List<Projeto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Projeto GetId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Projeto usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}