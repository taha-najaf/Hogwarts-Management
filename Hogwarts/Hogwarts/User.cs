using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public  class User:AllowedPersons
    {
        public static int FindUser(string Username,string Password)
        {
            
            if (Username == Dumbledore.Username && Password == Dumbledore.Password)
                return 1;
            else if (Student.StudentsList.Any(person => Username == person.Username && Password == person.Password))//Linq Query
                return 2;
            else if (Teacher.TeacherList.Any(teacher => Username == teacher.Username && Password == teacher.Password))//Linq Query
                return 3;
            else
                return 0;

        }
        public static Student TakeStudentObject(string Username,string Password)
        {
             if (Student.StudentsList.Any(person => Username == person.Username && Password == person.Password))
             {
                var student = Student.StudentsList.FirstOrDefault(person => Username == person.Username && Password == person.Password);
                return student;
             }
             return null;
        }
        public static Teacher TakeTeacherObject(string Username,string Password)
        {
            if(Teacher.TeacherList.Any(person => Username == person.Username && Password == person.Password))
            {
                var teacher = Teacher.TeacherList.FirstOrDefault(person => Username == person.Username && Password == person.Password);
                return teacher;
            }
            return null;
        }
    }
}
