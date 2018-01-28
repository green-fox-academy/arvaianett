﻿using FoxManager.Models;
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
        private HomeRepository homeRepository;

        public TeamService(TeamRepository teamRepository, HomeRepository homeRepository)
        {
            this.teamRepository = teamRepository;
            this.homeRepository = homeRepository;
        }

        public HomeViewModel GetTeamView(string name)
        {
            return new HomeViewModel()
            {
                AllTeams = teamRepository.GetAllTeams(),
                CurrentStudent = homeRepository.GetCurrentStudent(name)
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
