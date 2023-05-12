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
        public Teacher(string Firstname, string Lastname, string birthday, string gender, string fathername, string username, string password
           , BreedType breedType, Role role)
        {
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Birthday = birthday;
            this.Birthday = birthday;
            this.Gender = gender;
            this.FatherName = fathername;
            this.Username = username;
            this.Password = password;
        }
        public void DefineLesson(List<Lesson> lessons, List<Teacher> professor)
        {
        }
        public void SetScor(List<Student> students)
        {
        }
    }
}
