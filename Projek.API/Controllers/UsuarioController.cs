using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace projek.api.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController()
        {
            
        }
        [HttpGet]
        public IActionResult Get(){
            return Ok("ok");
        }
    }
}