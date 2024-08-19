using APITarefas.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace APITarefas.Controllers
{
    [Route("tarefas")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        [HttpGet("Api")]
        public IActionResult get()
        {
            return Ok("API Tarefas: online");
        }

        [HttpGet("hello-word")]

        public IActionResult GetHelloWorld()
        {
            return Ok("Hello world de Pedro");
        }
        [HttpGet("autor")]
        public IActionResult GetAutor() 
        {
            return Ok("Desenvolvido por Pedro");
        }
    }
}