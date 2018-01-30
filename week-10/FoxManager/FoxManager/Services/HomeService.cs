using FoxManager.Models;
using FoxManager.Repositories;
using FoxManager.ViewModels;

namespace FoxManager.Services
{
    public class HomeService
    {
        private TaskRepository taskRepository;
        private StudentRepository studentRepository;

        public HomeService(TaskRepository taskRepository, StudentRepository studentRepository)
        {
            this.taskRepository = taskRepository;
            this.studentRepository = studentRepository;
        }

        public BaseViewModel GetHomeView(string name)
        {
            var homeViewModel = new HomeViewModel()
            {
                CurrentStudentTasks = taskRepository.GetCurrentStudentsTasks(name),
                CurrentStudentsTeamsTasks = taskRepository.CurrentStudentsTeamsTasks(name),
                CurrentStudent = studentRepository.GetCurrentStudent(name),
            };

            return new BaseViewModel()
            {
                HomeViewModel = homeViewModel,
                CurrentStudent = studentRepository.GetCurrentStudent(name)
            };
        }

        public void AddTask(string name, TaskClass task)
        {
            taskRepository.AddTask(name, task);
        }

        public void DeleteStudentsTask(string name, long id)
        {
            taskRepository.DeleteStudentsTask(name, id);
        }

        public void UpdateTask(string name, TaskClass task)
        {
            taskRepository.UpdateTask(name, task);
        }
    }
}
