using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projek.api.Entidades
{
    public class Usuario
    {   
        [Key]                
        public int UsuarioId { get;  set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<Projeto> Projetos { get; set; }       
        public List<Linguagem> Linguagens { get; set; }
    }
}