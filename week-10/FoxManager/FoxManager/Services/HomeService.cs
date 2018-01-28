using FoxManager.Models;
using FoxManager.Repositories;
using FoxManager.ViewModels;

namespace FoxManager.Services
{
    public class HomeService
    {
        private HomeRepository homeRepository;

        public HomeService(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        public HomeViewModel GetHomeView(string name)
        {
            return new HomeViewModel()
            {
                CurrentStudentTasks = homeRepository.GetCurrentStudentsTasks(name),
                CurrentStudentsTeamsTasks = homeRepository.CurrentStudentsTeamsTasks(name),
                CurrentStudent = homeRepository.GetCurrentStudent(name)
                //StudentsTeam = homeRepository.GetCurrentStudentsTeam(name)
            };
        }

        public void AddTask(string name, TaskClass task)
        {
            homeRepository.AddTask(name, task);
        }

        public void DeleteStudentsTask(string name, long id)
        {
            homeRepository.DeleteStudentsTask(name, id);
        }

        public void UpdateTask(string name, TaskClass task)
        {
            homeRepository.UpdateTask(name, task);
        }
    }
}
