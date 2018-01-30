using FoxManager.Entities;
using FoxManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoxManager.Repositories
{
    public class TaskRepository
    {
        private FoxContext foxContext;
        private StudentRepository studentRepository;

        public TaskRepository(FoxContext foxContext, StudentRepository studentRepository)
        {
            this.foxContext = foxContext;
            this.studentRepository = studentRepository;
        }

        public List<TaskClass> GetCurrentStudentsTasks(string name)
        {
            return foxContext.Tasks.Where(t => t.Student.Name == name)
                .ToList();
        }

        public List<TaskClass> CurrentStudentsTeamsTasks(string name)
        {
            foxContext.Students.Load();
            return foxContext.Tasks.Where(t => t.Team.TeamName.Equals(studentRepository.GetCurrentStudent(name).Team.TeamName))
                .ToList();
        }

        public void AddTask(string name, TaskClass task)
        {
            foxContext.Tasks.Add(new TaskClass()
            {
                TaskName = task.TaskName,
                DueDate = task.DueDate,
                PriorityLevel = task.PriorityLevel,
                Student = studentRepository.GetCurrentStudent(name),
                Team = studentRepository.GetCurrentStudent(name).Team
            });

            foxContext.SaveChanges();
        }

        public void DeleteStudentsTask(string name, long id)
        {
            foxContext.Tasks.Remove(GetTask(id));
            foxContext.SaveChanges();
        }

        public TaskClass GetTask(long id)
        {
            return foxContext.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateTask(string name, TaskClass task)
        {
            foxContext.Tasks.Update(task);
            foxContext.SaveChanges();
        }
    }
}
