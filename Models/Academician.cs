using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemApp.Models
{
    public class Academician
    {
        public int AcadId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Section { get; set; }
        public string? Status { get; set; }
        public string? Role { get; set; }
        public string? Password { get; set; }

    }
}
