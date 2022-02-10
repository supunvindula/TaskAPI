using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper; 
        public TodosController(ITodoRepository repository,IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetToDos(int authorId)
        {
            var mytodos = _todoService.AllTodos(authorId);
            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(mytodos);
            return Ok(mappedTodos);
        }

        [HttpGet("{id}",Name ="GetTodo")]
        public ActionResult<TodoDto> GetTodo(int authorId,int id)
        {
            var todo = _todoService.GetTodo(authorId,id);
            if (todo is null)
                return NotFound();
            var mappedTodos = _mapper.Map<TodoDto>(todo);
            return Ok(mappedTodos);

        }
        [HttpPost]
        public ActionResult CreateTodo(int authorId,CreateTodoDto todo)
        {
            var todoEntity = _mapper.Map<Todo>(todo);
            var newTodo = _todoService.AddTodo(authorId, todoEntity);
            var todoForReturn = _mapper.Map<TodoDto>(newTodo);
            return CreatedAtRoute("GetTodo",new { authorId=authorId,id=todoForReturn.Id},todoForReturn);
        }
        [HttpPut("{todoId}")]
        public ActionResult UpdateTodo(int authorId,int todoId,UpdateTodoDto todo)
        {
            var updatingTodo = _todoService.GetTodo(authorId, todoId);
            if (updatingTodo is null)
                return NotFound();
            _mapper.Map(todo, updatingTodo);
            _todoService.updateTodo(updatingTodo);
            return NoContent();
        }
        [HttpDelete("{todoId}")]
        public ActionResult DeleteTodo(int authorId, int todoId)
        {
            var deletingTodo = _todoService.GetTodo(authorId, todoId);
            if (deletingTodo is null)
                return NotFound();
            _todoService.deleteTodo(deletingTodo);
            return NoContent();
        }

        
    }
}
