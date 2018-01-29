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
        private StudentRepository studentRepository;

        public LoginService(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool CheckInputs(string name, string password)
        {
            if(!studentRepository.GetStudentList().Contains(studentRepository.GetCurrentStudent(name)))
            {
                RegisterStudent(name, password);
            }
            
            if(studentRepository.GetCurrentStudent(name).Password == password)
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
            studentRepository.AddStudent(name, password);
        }
    }
}
