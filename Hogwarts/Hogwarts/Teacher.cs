using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Teacher : AllowedPersons
    {
        public bool SimultaneousTeaching { get; set; }
        public Lesson Lesson { get; set; }
        public static List<Teacher> TeacherList { get; set; }=new List<Teacher>();
        
        public void DefineLesson(List<Lesson> lessons, List<Teacher> professor)
        {
        }
        public void SetScor(List<Student> students)
        {
        }
    }
}
