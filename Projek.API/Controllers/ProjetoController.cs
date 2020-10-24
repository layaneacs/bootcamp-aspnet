using Microsoft.AspNetCore.Mvc;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/projetos")]
    public class ProjetoController: ControllerBase
    {
        public ProjetoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get(){
            return Ok("ok");
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