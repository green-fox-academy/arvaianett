using Quiz.Entities;
using Quiz.Models;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Repositories
{
    public class QuizRepository
    {
        private QuizContext quizContext;

        public QuizRepository(QuizContext quizContext)
        {
            this.quizContext = quizContext;
        }

        public void AddQuestion(QuizModel quizModel)
        {
            quizContext.QuizModels.Add(quizModel);
            quizContext.SaveChanges();
        }

        public bool IsThereAnyQuestions()
        {
            return quizContext.QuizModels.Count() == 0;
        }

        public List<QuizModel> GetAllQuestion()
        {
            return quizContext.QuizModels.ToList();
        }

        public bool CheckAnswer(long id, string answer)
        {
            return quizContext.QuizModels.FirstOrDefault(q => q.Id == id).CorrectAnswer == answer;
        }

        public QuizModel GetQuestion(int randomNumber)
        {
            return GetAllQuestion().ElementAt(randomNumber)
        }
    }
}
