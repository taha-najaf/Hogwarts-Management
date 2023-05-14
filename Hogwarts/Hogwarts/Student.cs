using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Student : AllowedPersons
    {
        public List<string> PassedUnits { get; set; }
        public int Term { get; set; }
        public int DormitoryNumbere { get; set; }
        public string letterToDumbledor { get; set; }
        public static List<Student> StusentsList { get; set; }=new List<Student>();
        public void SendLetterToDumbledor(string name, string family, string father, List<Student> student)
        {
        }
        public void SelectUnits(List<Lesson> lessons, List<Student> students, string name, String family)
        {
        }

    }
}
