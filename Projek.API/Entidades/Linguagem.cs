using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projek.api.Entidades
{
    public class Linguagem
    {       
        [Key]
        public int LinguagemId { get; set; }       

        public string Nome { get; set; }   

       
        
    }
}