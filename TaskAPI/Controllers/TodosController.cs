using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;
        public TodosController()
        {
            _todoService = new TodoService();
        }
        [HttpGet("{id?}")]
        public IActionResult GetToDos(int? id)
        {
            var mytodos = _todoService.AllTodos();
            if(id is null)
            {
                return Ok(mytodos);
            }
            mytodos = mytodos.Where(t => t.Id == id).ToList();
            return Ok(mytodos);
        }

        
    }
}
