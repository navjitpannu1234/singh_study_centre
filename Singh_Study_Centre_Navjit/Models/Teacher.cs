using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singh_Study_Centre_Navjit.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string TeacherName { get; set; }
        public List<Student> Students { get; set; }
    }
}
