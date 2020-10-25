using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using projek.api.Persistence;
using System.Collections.Generic;
using System.Linq;
using System;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {        
        private readonly ProjekDbContext _context;
        public UsuarioController(ProjekDbContext context)
        {
            _context = context;            
        }
        [HttpGet]
        public IActionResult Get(){
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }
          
        [HttpGet("{id}")]
        public IActionResult GetById(int id){   
            var usuario = _context.Usuarios.SingleOrDefault(x => x.UsuarioId == id);
            if(usuario == null) {
                return NotFound();
            }         
            return Ok(usuario);            
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario){
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                
                return Ok(usuario);
            }
            catch (System.Exception err)
            {                
                return BadRequest("Não foi possível criar o usuário: Error: " + err);
            } 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id){
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id){
            return Ok();
        }

    }
}