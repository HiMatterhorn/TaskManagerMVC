using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerMVC.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
