using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BlazorApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public bool IsDone { get; set; }
    }
}
