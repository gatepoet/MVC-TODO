using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_TODO.Models
{
    public class TodoListViewModel
    {
        public IList<TodoItem> TodoItems { get; set; }
        public TodoItem NewItem { get; set; }
    }
}