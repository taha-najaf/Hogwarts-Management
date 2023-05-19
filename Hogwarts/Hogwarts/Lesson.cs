using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Hogwarts
{
    public class Lesson
    {
        public string CourseDay { get; set; }
        public string CourseHour { get; set; }
        public string CourseName { get; set; }
        public int NumberOfStudents { get; set; }
        public int Capacity { get; set; }
        public int PresentationSemester { get; set; }
        public string ProfessorFirstName { get; set; }
        public string ProfessorLastName { get; set; }
        public double StudentGrade { get; set; }
        public Lesson(string cname,string cday,string ctime, int term, int capacity,int studentnum,string tfirst,string tlastname) 
        {
            this.CourseName = cname;
            this.CourseDay = cday;
            this.CourseHour = ctime;
            this.PresentationSemester = term;
            this.Capacity = capacity;
            this.NumberOfStudents = studentnum;
            this.ProfessorFirstName = tfirst;
            this.ProfessorLastName = tlastname;
        }
        public static List<Lesson> AllLessons { get; set; }=new List<Lesson>();
        ////database
        //DBconnect connect = new DBconnect();
        //// function to insert course
        //public bool insertcourse(string coursename,string courseday,string coursetime,string courseterm,int coursecapacity,string teacherfirstname,string teacherlastname)
        //{
        //    MySqlCommand command = new MySqlCommand("INSERT INTO `courses`(`CourseName`, `CourseDay`, `CourseTime`, `CourseTerm`, `CourseCapacity`, `TeacherFirstName`, `TeacherLastName`) VALUES (@Cn,@Cd,@Ct,@Cte,@Cc,@Tfn,@Tln)",connect.GetConnection);
        //    //@Cn,@Cd,@Ct,@Cte,@Cc,@Tfn,@Tln
        //    command.Parameters.Add("@Cn",MySqlDbType.VarChar).Value = coursename;
        //    command.Parameters.Add("@Cd", MySqlDbType.VarChar).Value = courseday;
        //    command.Parameters.Add("@Ct", MySqlDbType.VarChar).Value = coursetime;
        //    command.Parameters.Add("@Cte", MySqlDbType.VarChar).Value = courseterm;
        //    command.Parameters.Add("@Cc", MySqlDbType.Int32).Value = coursecapacity;
        //    command.Parameters.Add("@Tfn", MySqlDbType.VarChar).Value = teacherfirstname;
        //    command.Parameters.Add("@Tln", MySqlDbType.VarChar).Value = teacherlastname;
        //    connect.openConnect();
        //    if(command.ExecuteNonQuery()==1)
        //    {
        //        connect.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        connect.closeConnection();
        //        return false;
        //    }
        //}
    }
}
