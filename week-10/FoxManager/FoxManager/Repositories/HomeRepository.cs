using FoxManager.Entities;
using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoxManager.Repositories
{
    public class HomeRepository
    {
        private FoxContext foxContext;

        public HomeRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }

        public List<TaskClass> GetCurrentStudentsTasks(string name)
        {
            return foxContext.Tasks.Where(t => t.Student.Name == name)
                .ToList();
        }

        public List<TaskClass> CurrentStudentsTeamsTasks(string name)
        {
            return foxContext.Tasks.Where(t => t.Student == GetCurrentStudent(name)).ToList();
        }

        public Student GetCurrentStudent(string name)
        {
            return foxContext.Students.FirstOrDefault(s => s.Name == name);
        }

        ////can't get team, relations??
        //public Team GetCurrentStudentsTeam(string name)
        //{
        //    return foxContext.Teams.FirstOrDefault(t=>t.Students.Contains(GetCurrentStudent(name)));
        //}

        public void AddTask(string name, TaskClass task)
        {
            foxContext.Tasks.Add(new TaskClass()
            {
                TaskName = task.TaskName,
                DueDate = task.DueDate,
                PriorityLevel = task.PriorityLevel,
                Student = GetCurrentStudent(name),
                Team = GetCurrentStudent(name).Team
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
