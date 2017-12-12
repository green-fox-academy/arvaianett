using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInput
{
    class Pallida
    {
        public string InfoPallida { get; set; }

        public string className;
        public List<Person> students = new List<Person>();
        public List<Person> mentors = new List<Person>();

        public int studentslength;
        public int mentorslength;

        public Pallida(string className)
        {
            students.Clear();
            mentors.Clear();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            int studentslength = students.Count();
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
            int mentorslength = mentors.Count();
        }

        public string Info()
        {
            return InfoPallida = $"Pallida {className} class has {studentslength} students and {mentorslength} mentors.";
        }
    }
}
