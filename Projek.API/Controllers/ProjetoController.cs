using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using projek.api.Interfaces;
using projek.api.Persistence;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/projetos")]
    public class ProjetoController: ControllerBase
    {
        //private readonly ProjekDbContext _context;
        private readonly IProjeto _context;
        public ProjetoController(IProjeto context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        [Authorize]
        public IActionResult Get(){
            try
            {
                var user = User.Identity.Name ?? "";
                var projetos = _context.GetAll();
               
                return Ok(projetos);
            }
            catch (System.Exception)
            {
               return StatusCode(500,"Não foi posssível listar os projetos");            
            }
           
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            //var projeto = _context.Projetos.SingleOrDefault(x => x.ProjetoId == id);
            string projeto = null;
            if(projeto == null){
                return NotFound();
            }
            return Ok(projeto);
            
        }


        //--Criar projeto
        [HttpPost]
        [Route("")]
        [Authorize]
        public IActionResult Create(Projeto model){
            
            if(!ModelState.IsValid) BadRequest(ModelState);
            try
            {              
                model.Username = User.Identity.Name;    
                       
                _context.Create(model);

                
                
                return Ok(model);
            }
            catch (System.Exception)
            {                
                return BadRequest("Não foi possível criar o projeto");
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