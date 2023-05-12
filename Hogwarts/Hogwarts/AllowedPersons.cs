using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class AllowedPersons:Person
    {
        public string Curriculum { get; set; }
        public Pet Pet { get; set; }
        public GroupType GroupName { get; set; }
        public bool HaveBaggage { get; set; }
        public Role Role { get; set; }
        public string ReceivedLetter = " ";
    }
}
