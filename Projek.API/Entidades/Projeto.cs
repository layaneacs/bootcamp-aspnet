using System;
using System.Collections.Generic;
using projek.api.Enums;

namespace projek.api.Entidades
{
    public class Projeto
    {
        protected Projeto()
        {
            
        }
        public Projeto(string nome)
        {
            this.Nome = nome;
            this.CriadoEm = DateTime.Now;
            Usuarios = new List<Usuario>();
            Linguagens = new List<Linguagem>();
            Status = StatusProjetoEnum.Ativo;
        }
        public string Id { get; private set; }
        public string Nome { get; private set; }        
        public DateTime CriadoEm { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public List<Linguagem> Linguagens { get; private set; }

        public StatusProjetoEnum Status  { get; private set; }
    }
}