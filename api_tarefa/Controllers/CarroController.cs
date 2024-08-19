using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api_tarefa.Dtos;
using api_tarefa.Models;
using System.Text.RegularExpressions;

namespace api_tarefa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        List<Carro> listcarros = new List<Carro>();

        [HttpPost]
        public IActionResult Post([FromBody] CarroDTO item)
        {
          

            if ((item.AnoModelo < item.AnoFabricacao) || (item.AnoFabricacao < 2000))
            {
                return BadRequest();
            }
            
            return Ok(item);
  
        }
    }
}
