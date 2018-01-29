using FoxManager.Models;
using FoxManager.Repositories;
using FoxManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class TeamService
    {
        private TeamRepository teamRepository;
        private TaskRepository homeRepository;
        private StudentRepository studentRepository;

        public TeamService(TeamRepository teamRepository, TaskRepository homeRepository, StudentRepository studentRepository)
        {
            this.teamRepository = teamRepository;
            this.homeRepository = homeRepository;
            this.studentRepository = studentRepository;
        }

        public TeamViewModel GetTeamView(string name)
        {
            return new TeamViewModel()
            {
                AllTeams = teamRepository.GetAllTeams(),
                CurrentStudent = studentRepository.GetCurrentStudent(name)
            };
        }

        public void AddTeam(string name, Team team)
        {
            teamRepository.AddTeam(name, team);
        }

        public void DeleteTeam(string name, long id)
        {
            teamRepository.DeleteTeam(name, id);
        }

        public void UpdateTeam(string name, Team team)
        {
            teamRepository.UpdateTeam(name, team);
        }
    }
}
