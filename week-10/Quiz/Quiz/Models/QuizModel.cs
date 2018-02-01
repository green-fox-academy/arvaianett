namespace Quiz.Models
{
    public class QuizModel
    {
        public long Id { get; set; }
        public string Question { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public string FourthAnswer { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
