using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsSuccess { get; set; }
    }
}
