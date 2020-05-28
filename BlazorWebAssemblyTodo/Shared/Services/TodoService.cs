using Shared.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Shared.Services
{
    public class TodoService : ITodoService
    {
        private List<TodoItem> todos;

        public TodoService()
        {
            todos = new List<TodoItem>();
        }

        public void Add(TodoItem todo)
        {
            todos.Add(todo);
        }

        public IEnumerator<TodoItem> GetEnumerator()
        {
            return todos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
