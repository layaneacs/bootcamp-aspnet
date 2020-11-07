using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using projek.api.Enums;

namespace projek.api.Entidades
{
    public class Projeto
    {    
        [Key]
        public int ProjetoId { get;  set; }

        //--OK
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public string Nome { get;  set; }    

        public string Descricao { get; set; }

        public DateTime CriadoEm { get;  set; }
        
        
        public List<Linguagem> Linguagens { get; set; }

        public StatusProjetoEnum Status  { get;  set; }
    }
}