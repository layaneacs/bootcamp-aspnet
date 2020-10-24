using System;
using System.Collections.Generic;

namespace projek.api.Entidades
{
    public class Usuario
    {
        protected Usuario()
        {
            
        }
        public Usuario(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.CriadoEm = DateTime.Now;
            this.Projetos = new List<Projeto>();
            this.Linguagens = new List<Linguagem>();
        }   

        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime CriadoEm { get; private set; }
        public List<Projeto> Projetos { get; private set; }
        public List<Linguagem> Linguagens { get; private set; }
    }
}