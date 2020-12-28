using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using projek.api.Entidades;
using projek.api.Interfaces;
using projek.api.Persistence;
using System.Linq;

namespace projek.api.Repository
{
    public class ProjetoRepository : IProjeto
    {
        private readonly ProjekDbContext _context;
        public ProjetoRepository(ProjekDbContext context)
        {
            _context = context;
        }


        //--Criar projeto
        public Projeto Create(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();

            return projeto;

        }

        public void Delete(Projeto usuario)
        {
            throw new System.NotImplementedException();
        }

        //--Get all
        public List<Projeto> GetAll()
        {
           return _context.Projetos.ToList();
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