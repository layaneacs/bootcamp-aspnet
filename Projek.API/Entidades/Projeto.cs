using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            Nome = nome;
            CriadoEm = DateTime.Now;                   
            Linguagens = new List<Linguagem>();  
            Status = StatusProjetoEnum.Ativo;                 
        }
        public int ProjetoId { get;  set; }
        public string Nome { get;  set; }        
        public DateTime CriadoEm { get;  set; }
        public List<Linguagem> Linguagens { get; set; }
        public StatusProjetoEnum Status  { get;  set; }
    }
}