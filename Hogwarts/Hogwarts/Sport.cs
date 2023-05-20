using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Sport : Lesson
    {
        public Sport(string cname, string cday, string ctime, int term, int capacity, int studentnum, string tfirst, string tlastname) : base(cname, cday, ctime, term, capacity, studentnum, tfirst, tlastname)
        {
        }

        public string SportType { get; set; }
    }
}
