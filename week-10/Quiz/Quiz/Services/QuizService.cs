using Quiz.Models;
using Quiz.Repositories;
using Quiz.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Services
{
    public class QuizService
    {
        private static List<QuizModel> answeredList = new List<QuizModel>();
        private QuizRepository quizRepository;

        public QuizService(QuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }

        public void AddQuestion(QuizModel quizModel)
        {
            quizRepository.AddQuestion(quizModel);
        }

        public QuizViewModel GetQuizView(int? score = 0)
        {
            return new QuizViewModel()
            {
                Score = score,
                Question = GetQuestion()
            };
        }

        public bool IsThereAnyQuestion()
        {
            return quizRepository.IsThereAnyQuestions();
        }

        public bool CheckAnswer(long id, string answer)
        {
            return quizRepository.CheckAnswer(id, answer);
        }

        public int CheckScore(long id, string answer, int score)
        {
            if(CheckAnswer(id, answer))
            {
                return score += 1;
            }
            else
            {
                return score;
            }
        }

        public QuizViewModel GetScoreView(int score)
        {
            return new QuizViewModel()
            {
                Score = score
            };
        }

        public QuizViewModel GetView()
        {
            return new QuizViewModel()
            {
                Score = 0
            };
        }

        public QuizModel GetQuestion()
        {
            Random random = new Random();

            int randomNumber = random.Next(quizRepository.GetAllQuestion().Count());

            return quizRepository.GetQuestion(randomNumber);
        }
    }
}
