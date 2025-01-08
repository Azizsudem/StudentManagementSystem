//using studentmanagementsystemapp.view;
//using system.componentmodel.dataannotations;

//namespace studentmanagementsystemapp.models
//{
//    public class login
//    {
//        [key]
//        public int ıd { get; set; }

//        [required]
//        public string password { get; set; }

//        public static implicit operator login(login v)
//        {
//            throw new notımplementedexception();
//        }
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystemApp.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
