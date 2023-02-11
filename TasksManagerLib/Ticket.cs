using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManagerLib
{
    public class Ticket
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public List<Task> Tasks { get; set; } = new();
        public TimeSpan TimeSpan
        {
            get
            {
                var timeSpan = new TimeSpan(0);
                foreach (var task in Tasks) 
                {
                    timeSpan.Add(task.TimeSpan);
                }
                return timeSpan;
            }
        }
        public bool Done
        {
            get
            {
               return Tasks.All(x=> x.Done); 
            }
        }
    }
}
