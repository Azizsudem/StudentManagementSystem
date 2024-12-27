using StudentManagementSystemApp.Models;
using System.Linq;

namespace StudentManagementSystemApp.Repositories
{
    public class LoginRepository
    {
        private readonly ApplicationDbContext _context;

        public LoginRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Kullanıcıyı ID ve şifreye göre getir
        public Login GetUserByIdAndPassword(int id, string password)
        {
            return _context.Logins.FirstOrDefault(u => u.Id == id && u.Password == password);
        }

        // Yeni kullanıcı ekle
        public void AddUser(Login user)
        {
            _context.Logins.Add(user);
            _context.SaveChanges();
        }

        internal object GetUserByIdAndPassword(object id, string password)
        {
            throw new NotImplementedException();
        }
    }
}
