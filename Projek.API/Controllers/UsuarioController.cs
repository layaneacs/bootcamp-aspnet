using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using projek.api.Persistence;
using System.Collections.Generic;
using System.Linq;
using System;
using projek.api.Interfaces;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {        
        private readonly IUsuario _usuario;
        public UsuarioController(IUsuario context)
        {
            _usuario = context;            
        }
        
        [HttpGet]
        public IActionResult Get(){
            var usuarios = _usuario.GetAll();
            return Ok(usuarios);
        }
          
        [HttpGet("{id}")]
        public IActionResult GetById(int id){   
            //var usuario = _usuario.Usuarios.SingleOrDefault(x => x.UsuarioId == id);
            var usuario = _usuario.GetId(id);

            if(usuario == null) {
                return NotFound();
            }         
            return Ok(usuario);            
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario){
            try
            {
                _usuario.Create(usuario);
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