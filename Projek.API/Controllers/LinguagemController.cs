using Microsoft.AspNetCore.Mvc;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/linguagens")]
    public class LinguagemController: ControllerBase
    {
        public LinguagemController()
        {
            
        }   

        [HttpGet]
        public IActionResult Get(){
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
    }
}