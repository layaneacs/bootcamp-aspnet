using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projek.api.Entidades
{
    public class Usuario
    {   
        protected Usuario ()
        {

        }
        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
            CriadoEm = DateTime.Now;
            Projetos = new List<Projeto>();
            Linguagens = new List<Linguagem>();
        }        
        public int UsuarioId { get;  set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<Projeto> Projetos { get; set; }       
        public List<Linguagem> Linguagens { get; set; }
    }
}