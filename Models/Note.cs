using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemApp.Models
{
    public class Note
    {
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public int? ExamNote { get; set; }  
    }

}
