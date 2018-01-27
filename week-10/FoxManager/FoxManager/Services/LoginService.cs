using FoxManager.Models;
using FoxManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class LoginService
    {
        private LoginRepository loginRepository;

        public LoginService(LoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public bool CheckInputs(string name, string password)
        {
            if(!loginRepository.GetStudentList().Contains(loginRepository.GetStudentByName(name)))
            {
                RegisterStudent(name, password);
            }
            
            if(loginRepository.GetStudentByName(name).Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegisterStudent(string name, string password)
        {
            loginRepository.AddStudent(name, password);
        }
    }
}
