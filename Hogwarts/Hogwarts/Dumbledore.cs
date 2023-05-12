using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Dumbledore : AllowedPersons
    {
        Dormitory DormitoryList;
        public List<string> letterFromStudents { get; set; }
        public static void SendLetterToStudents(List<Student> persons)//need cabin and sit number
        {
        }
        public static void Gardening(Plant plant)
        {
        }
        public void AnswerLetters(List<Student> students)
        {
        }
    }
}
