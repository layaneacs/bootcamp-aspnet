using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using projek.api.Persistence;
using System.Collections.Generic;
using System.Linq;
using System;
using projek.api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Projek.API.Services;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        [AllowAnonymous]
        public IActionResult Get(){
            var usuarios = _usuario.GetAll();
            return Ok(usuarios);
        }
          
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetById(int id){   
            //var usuario = _usuario.Usuarios.SingleOrDefault(x => x.UsuarioId == id);
            var usuario = _usuario.GetId(id);

            if(usuario == null) {
                return NotFound();
            }         
            return Ok(usuario);            
        }
        
        [HttpPost]
        [AllowAnonymous]
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
        
        //-- Rota para autentificacao
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Authenticate(Usuario model){
            try
            {
                var usuario = _usuario.Authenticate(model);  
                if(usuario == null){
                    return StatusCode(404, "Usuário ou senha inválidos");
                }

                var token = TokenService.GerarToken(model);
                model.Password = ""; 
                
                return Ok ( new 
                {                    
                    user = model, 
                    token = token 
                });
                
            }
            catch (System.Exception err)
            {                
                return StatusCode(500, "Falha na autenticação");
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