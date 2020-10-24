using System;

namespace projek.api.Entidades
{
    public class Linguagem
    {
        protected Linguagem() 
        {
            
        }
        public Linguagem(string nome)
        {
            this.Nome = nome;           

        }
        public string Id { get; private set; }
        public string Nome { get; private set; } 
        
    }
}