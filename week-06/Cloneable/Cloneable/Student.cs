using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Student : Person, ICloneable
    {
        public string IntroStudent { get; set; }
        public string GoalStudent { get; set; }


        public string previousOrganization;
        public int skippedDays;

        public Student(string name, int age, string gender, string previous) : base(name, age, gender)
        {
            this.previousOrganization = previous;
            skippedDays = 0;
        }

        public override string GetGoal()
        {
            return GoalStudent = "Be a junior software developer.";
        }

        public override string Introduce()
        {
            return IntroStudent = $"Hi, I'm {name}, a {age} year old {gender} from {previousOrganization} who skipped {skippedDays} days from the course already.";
        }

        public int SkipDays(int numberOfDays)
        {
            return skippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(name, age, gender, previousOrganization);
        }
    }
}
