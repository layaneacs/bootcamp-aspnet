using System.Collections.Generic;

using projek.api.Entidades;
using projek.api.Interfaces;
using projek.api.Persistence;

namespace projek.api.Repository
{
    public class LinguagemRepository : ILinguagem
    {
        private readonly ProjekDbContext _context;

        public LinguagemRepository(ProjekDbContext context)
        {
            _context = context;
        }
        public Linguagem Create(Linguagem usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Linguagem usuario)
        {
            throw new System.NotImplementedException();
        }

        public List<Linguagem> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Linguagem GetId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Linguagem usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}