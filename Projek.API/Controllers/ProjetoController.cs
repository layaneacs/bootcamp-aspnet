using System.Linq;
using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using projek.api.Persistence;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/projetos")]
    public class ProjetoController: ControllerBase
    {
        private readonly ProjekDbContext _context;
        public ProjetoController(ProjekDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(){
            var projetos = _context.Projetos.ToList();
            return Ok(projetos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            var projeto = _context.Projetos.SingleOrDefault(x => x.ProjetoId == id);
            if(projeto == null){
                return NotFound();
            }
            return Ok(projeto);
            
        }

        [HttpPost]
        public IActionResult Create(Projeto projeto){
             try
            {
                _context.Projetos.Add(projeto);
                _context.SaveChanges();
                
                return Ok(projeto);
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