using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.ViewModels
{
    public class TeamViewModel
    {
        public List<Team> AllTeams { get; set; }
        public Student CurrentStudent { get; set; }
    }
}
