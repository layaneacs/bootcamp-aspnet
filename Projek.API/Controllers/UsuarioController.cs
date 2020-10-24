using Microsoft.AspNetCore.Mvc;
using projek.api.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {        
        public UsuarioController()
        {
            
        }
        [HttpGet]
        public IActionResult Get(){
            return Ok(new List<Usuario>{
                new Usuario("Layane", "150" ),
                new Usuario("Layane2", "150" ),
                new Usuario("Layane3", "150" )
            });
        }
          
        [HttpGet("{id}")]
        public IActionResult GetById(string id){            
            return Ok("ok");
        }

        [HttpPost]
        public IActionResult Create(){
            return Ok();
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