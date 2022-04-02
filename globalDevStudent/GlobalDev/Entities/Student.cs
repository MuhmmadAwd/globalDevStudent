using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace globalDevStudent.GlobalDev.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? GraduatDate { get; set; }
        public string country { get; set; }
    }
}