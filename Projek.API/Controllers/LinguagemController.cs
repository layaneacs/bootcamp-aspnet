using System.Linq;
using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using projek.api.Persistence;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/linguagens")]
    public class LinguagemController: ControllerBase
    {
        private readonly ProjekDbContext _context;
        public LinguagemController(ProjekDbContext context)
        {
            _context = context;
        }   

        [HttpGet]
        public IActionResult Get(){
            var linguagens = _context.Linguagens.ToList();
            return Ok(linguagens);
        }

        [HttpPost]
        public IActionResult Create(Linguagem linguagem){
            try
            {                
                _context.Linguagens.Add(linguagem);
                _context.SaveChanges();
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest("Não foi possível incluir a linguagem");
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id){
            return Ok();
        }      
    }
}