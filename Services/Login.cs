using StudentManagementSystemApp.Models;
using StudentManagementSystemApp.Repositories;

namespace StudentManagementSystemApp.Services
{
    public class LoginService
    {
        private readonly LoginRepository _loginRepository;

        public LoginService(LoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool AuthenticateUser(string username, string password)
        {
            //var user = _loginRepository.GetUserByIdAndPassword(id, password);
            //return user != null;
            return true;
        }

        public void RegisterUser(string id, string password)
        {
            //var user = new Login { Id = id, Password = password };
            //_loginRepository.AddUser(user);
        }
    }
}
