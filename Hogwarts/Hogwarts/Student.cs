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
        public Student(string Firstname, string Lastname, string birthday, string gender, string fathername, string username, string password
          , BreedType breedType, Role role, int term)
        {
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Birthday = birthday;
            this.Birthday = birthday;
            this.Gender = gender;
            this.FatherName = fathername;
            this.Username = username;
            this.Password = password;
            this.breedType = breedType;
            this.Role = role;
            this.Term = term;
        }
        public void SendLetterToDumbledor(string name, string family, string father, List<Student> student)
        {
        }
        public void SelectUnits(List<Lesson> lessons, List<Student> students, string name, String family)
        {
        }

    }
}
