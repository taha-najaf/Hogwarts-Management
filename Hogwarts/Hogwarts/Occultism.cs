using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Occultism : Lesson
    {
        public Occultism(string cname, string cday, string ctime, int term, int capacity, int studentnum, string tfirst, string tlastname) : base(cname, cday, ctime, term, capacity, studentnum, tfirst, tlastname)
        {
        }

        public List<string> Spell { get; set; }
    }
}
