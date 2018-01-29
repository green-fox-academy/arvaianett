using FoxManager.Entities;
using FoxManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class StudentRepository
    {
        private FoxContext foxContext;

        public StudentRepository(FoxContext foxContext)
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

        public Student GetCurrentStudent(string name)
        {
            foxContext.Teams.Load();
            return foxContext.Students.FirstOrDefault(s => s.Name == name);
        }

        public List<Student> GetAllStudent()
        {
            return foxContext.Students.ToList();
        }
    }
}
