using FoxManager.Entities;
using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class LoginRepository
    {
        private FoxContext foxContext;

        public LoginRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }

        public List<Student> GetStudentList()
        {
            return foxContext.Students.ToList();
        }

        public void AddStudent(string name, string password)
        {
            foxContext.Add(new Student()
            {
                Name = name,
                Password = password,
            });

            foxContext.SaveChanges();
        }

        public Student GetStudentByName(string name)
        {
            return foxContext.Students.FirstOrDefault(s => s.Name == name);
        }
    }
}
