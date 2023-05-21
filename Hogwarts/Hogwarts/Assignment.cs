using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Assignment
    {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Deadline { get; set; }
        public static List<Assignment> AllAssignments { get; set; }= new List<Assignment>();
        public Assignment(string title, string description, DateTime deadline)
        {
            Title = title;
            Description = description;
            Deadline = deadline;
        }
    }

}
