    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace StudentManagementSystemApp.Models
{
    public class Student
    {
        public static DataView DefaultView { get; internal set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }  
        public string? Email { get; set; }   
        public string? Phone { get; set; }   
        public string? Section { get; set; }  
        public string? Period { get; set; } 
        public string? Role { get; set; }   
        public string? Password { get; set; }
        public string ExamNote { get; internal set; }
        public int LessonId { get; internal set; }
    }
}
