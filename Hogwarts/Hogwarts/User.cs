﻿using System;
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
            else if (Student.StusentsList.Any(person => Username == person.Username && Password == person.Password))//Linq Query
                return 2;
            else if (Teacher.TeacherList.Any(teacher => Username == teacher.Username && Password == teacher.Password))//Linq Query
                return 3;
            else
                return 0;

        }
    }
}