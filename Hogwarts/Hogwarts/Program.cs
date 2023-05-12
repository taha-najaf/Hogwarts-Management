using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //================================================================start by read from file
            List<AllowedPersons> ListOfAllowedPersons = new List<AllowedPersons>();
            int slytherinDorm = 110, ravenclawDorm = 110, gryffindorDorm = 110, hufflepuffDorm = 110;
            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    AllowedPersons allowedPersons = new AllowedPersons();
                    string[] human = ln.Split('\t').ToArray<string>();

                    allowedPersons.FirstName = human[0];
                    allowedPersons.LastName = human[1];
                    allowedPersons.Birthday = human[2];
                    allowedPersons.Gender = human[3];
                    allowedPersons.FatherName = human[4];
                    allowedPersons.Username = human[5];
                    allowedPersons.Password = human[6];
                    //----------------------for breed or race type
                    if (human[7] == "HalfBlood")
                        allowedPersons.breedType = BreedType.HalfBlood;
                    else if (human[7] == "PureBlood")
                        allowedPersons.breedType = BreedType.PureBlood;
                    else if (human[7] == "MuggleBlood")
                        allowedPersons.breedType = BreedType.MuggleBlood;
                    //----------------------for role
                    if (human[8] == "teacher")
                    {
                        Random random = new Random();
                        allowedPersons.Role = Role.teacher;
                        int baggage = random.Next(2);//for baggage
                        if (baggage == 0)
                            allowedPersons.HaveBaggage = true;
                        else
                            allowedPersons.HaveBaggage = false;
                        allowedPersons.Pet = (Pet)random.Next(0, 3);//for pet
                        allowedPersons.GroupName = (GroupType)random.Next(0, 4);
                    }
                    else if (human[8] == "student")
                    {
                        Random random = new Random();
                        allowedPersons.Role = Role.student;
                        int baggage = random.Next(2);//for baggage
                        if (baggage == 0)
                            allowedPersons.HaveBaggage = true;
                        else
                            allowedPersons.HaveBaggage = false;
                        allowedPersons.Pet = (Pet)random.Next(0, 3);//for pet
                        allowedPersons.GroupName = (GroupType)random.Next(0, 4);

                    }

                    ListOfAllowedPersons.Add(allowedPersons);
                }
                file.Close();
            }
            //==========================find teachers
            List<Teacher> teachers = new List<Teacher>();
            foreach (var AllowPerson in ListOfAllowedPersons)
            {
                if (AllowPerson.Role == Role.teacher)
                {
                    Teacher teacher = new Teacher(AllowPerson.FirstName, AllowPerson.LastName, AllowPerson.Birthday, AllowPerson.Gender, AllowPerson.FatherName
                        , AllowPerson.Username, AllowPerson.Password, AllowPerson.breedType, Role.teacher);
                    teachers.Add(teacher);
                }
            }
            //=========================find student
            List<Student> students = new List<Student>();
            foreach (var AllowPerson in ListOfAllowedPersons)
            {
                if (AllowPerson.Role == Role.student)
                {
                    Random random = new Random();
                    int term = random.Next(1, 9);
                    Student student = new Student(AllowPerson.FirstName, AllowPerson.LastName, AllowPerson.Birthday, AllowPerson.Gender, AllowPerson.FatherName
                        , AllowPerson.Username, AllowPerson.Password, AllowPerson.breedType, Role.student, term);

                    students.Add((student));
                }
            }
        }
    }
}
