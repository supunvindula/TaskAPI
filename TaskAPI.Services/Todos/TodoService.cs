using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get a headphone",
                Description = "Buy from Daraz",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New
            };
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Put a cover to the window",
                Description = "To protect from mosquitos",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.New
            };
            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(todo3);
            return todos;
        }
    }
}
