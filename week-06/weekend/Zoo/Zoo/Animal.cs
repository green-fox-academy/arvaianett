using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        public string name;
        public int age;

        public Animal(string name)
        {
        }

        public abstract string Greet();
        public abstract string WantChild();
        public abstract string GetName();
    }
}
