using FoxManager.Entities;
using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class TeamRepository
    {
        private FoxContext foxContext;

        public TeamRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }

        public List<Team> GetAllTeams()
        {
            return foxContext.Teams.ToList();
        }

        public void AddTeam(string name, Team team)
        {
            foxContext.Teams.Add(team);
            foxContext.SaveChanges();
        }

        public void DeleteTeam(string name, long id)
        {
            foxContext.Teams.Remove(GetTeam(id));
            foxContext.SaveChanges();
        }

        public Team GetTeam(long id)
        {
            return foxContext.Teams.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateTeam(string name, Team team)
        {
            foxContext.Teams.Update(team);
            foxContext.SaveChanges();
        }
    }
}
