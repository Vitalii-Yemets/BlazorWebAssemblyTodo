using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface ITodoService : IEnumerable<TodoItem>
    {
        void Add(TodoItem todo);
    }
}
