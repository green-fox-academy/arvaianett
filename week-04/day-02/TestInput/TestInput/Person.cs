using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInput
{
    class Person
    {        
        public string Intro { get; set; }
        public string Goal { get; set; }

        public string name;
        public int age;
        public string gender;

       public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual string Introduce()
        {
            return Intro = $"Hi, I'm {name} , a {age} year old {gender} .";
        }

        public virtual string GetGoal()
        {
            return Goal = "My goal is: Live for the moment!";
        }
    }
}
