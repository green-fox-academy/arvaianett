using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInput
{
    class Mentor : Person
    {
        public string IntroMentor { get; set; }
        public string GoalMentor { get; set; }

        public string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public override string GetGoal()
        {
            return GoalMentor = "Educate brilliant junior software developers.";
        }

        public override string Introduce()
        {
            return IntroMentor = $"Hi, I'm {name}, a {age} year old {gender} {level} mentor.";
        }
    }
}
