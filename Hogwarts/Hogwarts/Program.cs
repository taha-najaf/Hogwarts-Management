using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts
{

    public static class Program
    { 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //****************************************************************all instances
            Dumbledore dumbledore = new Dumbledore();
            Teacher teacher = new Teacher();
            Student student = new Student();
            List<AllowedPersons> persons = new List<AllowedPersons>();
            Plant plant = new Plant();
            List<Lesson> lessons = new List<Lesson>();
            //List<teacher> ListOfTeachers = new List<teacher>();
            //List<Student> ListOfStudents = new List<Student>();
            Random random = new Random();
            int SlytherinDormitoryCode = 110;
            int RavenclawDormitoryCode = 110;
            int GryffindorDormitoryCode = 110;
            int HufflepuffDormitoryCode = 110;
            //**************************************************************for reading file

            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    AllowedPersons AllowedPersons = new AllowedPersons();
                    student = new Student();
                    teacher = new Teacher();
                    string[] human = ln.Split('\t').ToArray<string>();
                    AllowedPersons.FirstName = human[0];
                    AllowedPersons.LastName = human[1];
                    AllowedPersons.Birthday = human[2];
                    AllowedPersons.Gender = human[3];
                    AllowedPersons.FatherName = human[4];
                    AllowedPersons.Username = human[5];
                    AllowedPersons.Password = human[6];
                    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~for blood type
                    if (human[7] == "Pure blood")
                        AllowedPersons.breedType = BreedType.PureBlood;
                    else if (human[7] == "Half blood")
                        AllowedPersons.breedType = BreedType.HalfBlood;
                    else if (human[7] == "Muggle blood")
                        AllowedPersons.breedType = BreedType.MuggleBlood;
                    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~for role type
                    if (human[8] == "teacher")
                    {
                        int baggage = random.Next(2);//for baggage
                        if (baggage == 0)
                            AllowedPersons.HaveBaggage = true;
                        else
                            AllowedPersons.HaveBaggage = false;
                        AllowedPersons.Pet = (Pet)random.Next(0, 3);//for pet
                        AllowedPersons.GroupName = (GroupType)random.Next(0, 4);//for group name
                        AllowedPersons.Role = Role.teacher;
                        teacher.Role = Role.teacher;
                        teacher.FirstName = AllowedPersons.FirstName;
                        teacher.LastName = AllowedPersons.LastName;
                        teacher.Birthday = AllowedPersons.Birthday;
                        teacher.Gender = AllowedPersons.Gender;
                        teacher.FatherName = AllowedPersons.FatherName;
                        teacher.Username = AllowedPersons.Username;
                        teacher.Password = AllowedPersons.Password;
                        teacher.Pet = AllowedPersons.Pet;
                        teacher.HaveBaggage = AllowedPersons.HaveBaggage;
                        teacher.GroupName = AllowedPersons.GroupName;
                      //  ListOfTeachers.Add(teacher);
                      Teacher.TeacherList.Add(teacher);
                    }
                    else if (human[8] == "student")
                    {
                        int baggage = random.Next(2);//for baggage
                        if (baggage == 0)
                            AllowedPersons.HaveBaggage = true;
                        else
                            AllowedPersons.HaveBaggage = false;
                        AllowedPersons.Pet = (Pet)random.Next(0, 3);//for pet
                        AllowedPersons.GroupName = (GroupType)random.Next(0, 4);//for group name
                        AllowedPersons.Role = Role.student;
                        student.Role = Role.student;
                        student.FirstName = AllowedPersons.FirstName;
                        student.LastName = AllowedPersons.LastName;
                        student.Birthday = AllowedPersons.Birthday;
                        student.Gender = AllowedPersons.Gender;
                        student.FatherName = AllowedPersons.FatherName;
                        student.Username = AllowedPersons.Username;
                        student.Password = AllowedPersons.Password;
                        student.Pet = AllowedPersons.Pet;
                        student.HaveBaggage = AllowedPersons.HaveBaggage;
                        student.GroupName = AllowedPersons.GroupName;
                       
                       // ListOfStudents.Add(student);
                       Student.StusentsList.Add(student);
                    }
                    persons.Add(AllowedPersons);
                }
                file.Close();
            }
            //foreach (Student x in ListOfStudents)
            //{
            //    Student.StusentsList.Add(x);
            //}
            //Student.StusentsList = ListOfStudents;
            //teacher.TeacherList = ListOfTeachers;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProfessorPanel());


        }
       
    }
}
