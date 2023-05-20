using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Dumbledore : AllowedPersons
    {
        public static List<string> letterFromStudents { get; set; }= new List<string>();
        public static string Username="Admin";
        public static string Password="****";
       
        public static void SendLetterToStudents(List<Student> persons)//need cabin and sit number
        {
            int i = 1;
            int trainNumber = 1;
            int trainHour = 8;
            int code = 110;
            foreach (AllowedPersons p in persons)
            {
                TrainManagement trainManagement = new TrainManagement(code);
                p.traincode = trainManagement.ManageTrain(code);
                code=p.traincode;
                if (i % 50 == 0)
                {
                    trainNumber++;
                    trainHour++;
                }
                if (p.Role != Role.teacher)
                {
                    p.ReceivedLetter = $"hello dear {p.FirstName},{p.LastName}\n" +
                        $"welcome to the Hagwarts \n" +
                        $"your train information:\nTrain Number:{trainNumber}\nTrain Departure Time:{trainHour}:00\n" +
                        $"Train Cabin+Wagon+Bed {p.traincode}\n" +
                        $"Origin city:London Destination:Hogwarts\n" +
                        $"remember If you don't get to the train, you have to wait an hour for the next train";
                }
                ++i;
            }
        }
        
      
        public void AnswerLetters(List<Student> students)
        {
        }
    }
}
