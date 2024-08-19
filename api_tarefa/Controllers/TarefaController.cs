using api_tarefa.Dtos;
using APITarefas.Model;
using Microsoft.AspNetCore.Mvc;

namespace api_tarefa.Controllers
{
    public class TarefaController : Controller
    {
        List<Tarefa> listaTarefas = new List<Tarefa>();

        public TarefaController()
        {
            var tarefa1 = new Tarefa
            {
                Id = 1,
                Name = "bolo",
                Descricao = "fazer bolo de choco",
                Feito = false
            };
            var tarefa2 = new Tarefa
            {
                Id = 2,
                Name = "ler",
                Descricao = "ler livro 'Vidas Secas'",
                Feito = false
            };
            listaTarefas.Add(tarefa1);
            listaTarefas.Add(tarefa2);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(listaTarefas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tarefa = listaTarefas.Where(item => item.Id == id).FirstOrDefault();
            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Tarefa item)
        {
            var contador = listaTarefas.Count();
            var tarefa = new Tarefa
            {
                Id = contador + 1,
                Name = item.Name,
                Descricao = item.Descricao,
                Feito = item.Feito
            };

            listaTarefas.Add(tarefa);
            return StatusCode(StatusCodes.Status201Created, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TarefaDTO item) 
        { 
            var tarefa = listaTarefas.Where(item => item.Id == id).FirstOrDefault();

            if (tarefa == null)
            {
                return NotFound();
            }

            tarefa.Descricao = item.Descricao;
            tarefa.Feito = item.Feito;

            return Ok(listaTarefas);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarefa = listaTarefas.Where(item =>item.Id == id).FirstOrDefault();

            if(tarefa == null)
            {
                return NotFound();
            }

            listaTarefas.Remove(tarefa);

            return Ok(tarefa);
        }
    }
}
