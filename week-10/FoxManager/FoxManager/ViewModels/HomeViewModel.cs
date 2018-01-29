using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoxManager.ViewModels
{
    public class HomeViewModel
    {
        public List<TaskClass> CurrentStudentTasks { get; set; }
        public List<TaskClass> CurrentStudentsTeamsTasks { get; set; }
        public Student CurrentStudent { get; set; }
        public Team StudentsTeam { get; set; }
    }
}
