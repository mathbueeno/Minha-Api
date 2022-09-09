using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controller
{

    // definição do API
    [ApiController]


    // Controller é uma classe que herda de Controller
    // ControllerBase possui algumas funções e métodos adicionais.
    public class HomeController : ControllerBase
    {

        [HttpGet("/")]

        // Todo método público dentro de um controller é chamado de Action
        // injeção de dependência
        public List<TodoModel> Get([FromServices] AppDbContext context)
        {

            return context.Todos.ToList();
        }

        [HttpPost("/")]
        public TodoModel Post(
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context)
        {
            context.Todos.Add(todo);
            context.SaveChanges();

            return todo;
        }

    }
}