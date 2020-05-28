using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class TodoItem
    {
        public TodoItem(string title, string description)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
