using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Services
{
    public interface ITodoService : IEnumerable<TodoItem>
    {
        void Add(TodoItem todo);
    }
}
