using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
        //===========================database
        DBconnect connect =new DBconnect();
        //create function to add students to database
        public bool insertStudent(string firstname, string lastname, string fathername,DateTime dob,string gender,string pet,string breedtype,string username,string password,string term,byte[]img)
        {
            MySqlCommand command= new MySqlCommand("INSERT INTO `student`(`FirstName`, `LastName`, `FatherName`, `DOB`, `Gender`, `Pet`, `Blood`, `Username`, `Password`, `Term`, `Photo`) VALUES(@fn, @ln, @fan, @db, @ge, @pe, @br, @un, @pa, @te, @img)",connect.GetConnection);
            //VALUES(@fn, @ln, @fan, @db, @ge, @pe, @br, @un, @pa, @te, @img
            command.Parameters.Add("@fn",MySqlDbType.VarChar).Value= firstname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@fan", MySqlDbType.VarChar).Value = fathername;
            command.Parameters.Add("@db", MySqlDbType.Date).Value = dob;
            command.Parameters.Add("@ge", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@pe", MySqlDbType.VarChar).Value = pet;
            command.Parameters.Add("@br", MySqlDbType.VarChar).Value = breedtype;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@te", MySqlDbType.Int32).Value = term;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            connect.openConnect();
            if(command.ExecuteNonQuery()==1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }

    }
}
