using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Dumbledore : AllowedPersons
    {
        public List<string> letterFromStudents { get; set; }
        public string Username="Admin";
        public string Password="****";
        
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
