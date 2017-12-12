using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInput
{
    class Sponsor : Person
    {
        public string IntroSponsor { get; set; }
        public string GoalSponsor { get; set; }

        public string company;
        public int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public override string GetGoal()
        {
            return GoalSponsor = "Hire brilliant junior software developers.";
        }

        public override string Introduce()
        {
            return IntroSponsor = $"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.";
        }

        public int Hire()
        {
            return hiredStudents += 1;
        }
    }
}
