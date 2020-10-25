using System;
using System.ComponentModel.DataAnnotations;

namespace projek.api.Entidades
{
    public class Linguagem
    {
        protected Linguagem()
        {
            
        }
        public Linguagem(string nome)
        {
            Nome = nome;
        }
        public int LinguagemId { get; set; }
        public string Nome { get; set; } 
        
    }
}