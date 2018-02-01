using Microsoft.AspNetCore.Mvc;
using Quiz.Services;
using Quiz.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Quiz.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private QuizService quizService;

        public HomeController(QuizService quizService)
        {
            this.quizService = quizService;
        }

        // GET: /<controller>/
        [HttpGet("home")]
        public IActionResult Home()
        {
            return View(quizService.GetView());
        }

        [HttpGet("home/{score}")]
        public IActionResult Home([FromRoute]int score)
        {
            return View(quizService.GetScoreView(score));
        }

        [HttpGet("question")]
        public IActionResult Question()
        {
            return View();
        }

        [HttpPost("question")]
        public IActionResult AddQuestion([FromForm]QuizModel quizModel)
        {
            quizService.AddQuestion(quizModel);
            return Redirect("home");
        }

        [HttpGet("quiz")]
        public IActionResult Quiz()
        {
            if (quizService.IsThereAnyQuestion())
            {
                return RedirectToAction("home");
            }
            else
            {
                return View(quizService.GetQuizView());
            }
        }

        [HttpGet("quiz/{id}/{answer}/{score}")]
        public IActionResult QuizWithParameters([FromRoute]long id, [FromRoute]string answer, [FromRoute]int score)
        {
            if (quizService.CheckAnswer(id, answer))
            {
                return View("Quiz", quizService.GetQuizView(++score));
            }
            else
            {
                return RedirectToAction("home", score);
            }
        }
    }
}
