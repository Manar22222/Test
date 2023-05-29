using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabDay1.Models
{
    public class StudentsData
    {
        public static List<Students> students = new List<Students>()
        {
            new Students (){ ID= 1 , Name = "Asmaa" , GPA = 3.5f },
            new Students (){ ID= 2 , Name = "Alyaa" , GPA = 2.0f },
            new Students (){ ID= 3 , Name = "Amira" , GPA = 3.5f },
            new Students (){ ID= 4 , Name = "Huda" , GPA = 4.5f },
            new Students (){ ID= 5 , Name = "manar" , GPA = 1.5f }
        };
    }
}
