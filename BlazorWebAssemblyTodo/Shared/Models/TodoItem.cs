using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
