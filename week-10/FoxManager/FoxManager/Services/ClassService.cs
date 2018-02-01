using FoxManager.Models;
using FoxManager.Repositories;
using FoxManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class ClassService
    {
        private ClassRepository classRepository;
        private StudentRepository studentRepository;

        public ClassService(ClassRepository classRepository, StudentRepository studentRepository)
        {
            this.classRepository = classRepository;
            this.studentRepository = studentRepository;
        }

        public BaseViewModel GetClassView(string name)
        {
            return new BaseViewModel()
            {
                ClassViewModel = GetClassViewModel(name),
                CurrentStudent = studentRepository.GetCurrentStudent(name)
            };
        }

        public ClassViewModel GetClassViewModel(string name)
        {
            return new ClassViewModel()
            {
                AllClass = classRepository.GetAllClass(),
                CurrentStudent = studentRepository.GetCurrentStudent(name),
                AllStudent = studentRepository.GetAllStudent()
            };
        }

        public void AddClass(string name, Class foxClass)
        {
            classRepository.AddClass(name, foxClass);
        }

        public void DeleteClass(string name, long id)
        {
            classRepository.DeleteClass(name, id);
        }

        public void UpdateClass(string name, Class foxClass)
        {
            classRepository.UpdateClass(name, foxClass);
        }
    }
}
