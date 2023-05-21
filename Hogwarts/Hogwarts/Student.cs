using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace Hogwarts
{
    public class Student : AllowedPersons
    {
        public List<string> PassedUnits { get; set; }
        public int Term { get; set; }
        public int DormitoryNumber { get; set; }
        public string letterToDumbledor { get; set; }
        public static List<Student> StudentsList { get; set; }=new List<Student>();
        public  List<Lesson> Curriculum { get; set; } = new List<Lesson>();

        public void SendLetterToDumbledor(string name, string family)
        {
            string request = $"You have new message from student with this firstname {name} and lastname {family}\n" +
               "Dear Dumbledore\n" +
               "I am writing to request permission to return to the city. ";
            Dumbledore.letterFromStudents.Add(request);
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
        //to get student table from database
        public DataTable getStudentList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        } 
        //create a function to execute the count query total
        public string exeCount(string query)
        {
            MySqlCommand command1 = new MySqlCommand(query, connect.GetConnection);
            connect.openConnect();
            string count=command1.ExecuteScalar().ToString();
            connect.closeConnection();
            return count;
        }
        // to get total student 
        public string totalstudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }
        // To  get the male student count
        public string malestudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender`='Male'");
        }
        // To  get the female student count
        public string femalestudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender`='FeMale'");
        }
        //create a function to search for (student firstname,lastname)
        public DataTable SearchStudent(string data)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`FirstName`,`LastName`) LIKE '%"+ data +"%'", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //edit function
        public bool updateStudent(int id,string firstname, string lastname, string fathername, DateTime dob, string gender, string pet, string breedtype, string username, string password, string term, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET`FirstName`= @fn,`LastName`= @ln,`FatherName`= @fan,`DOB`= @db,`Gender`= @ge,`Pet`= @pe,`Blood`= @br,`Username`= @un,`Password`= @pa,`term`= @te,`Photo`= @img WHERE `stdId`= @id", connect.GetConnection);
            //VALUES(@fn, @ln, @fan, @db, @ge, @pe, @br, @un, @pa, @te, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstname;
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
            if (command.ExecuteNonQuery() == 1)
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
        // create a function for any command in studentDB
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
