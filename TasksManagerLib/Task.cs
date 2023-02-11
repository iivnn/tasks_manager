using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManagerLib
{
    public class Task
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TimeSpan TimeSpan { get; set; } = TimeSpan.MinValue;
        public List<SubTask>? SubTasks { get; set; } = null;
    }
}
