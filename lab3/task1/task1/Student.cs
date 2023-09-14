using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Student : IComponent
    {
        private string name;
        List<int> grades;
        public string Name { get; set; }
        public List<int> Grades { get; }
        private double averageGrade;
        public Student(string name, List<int> grades)
        {
            this.name = name;
            this.grades = grades;
            averageGrade = GetAverageGrade();
        }
        public bool IsComposite() => false;
        public void AddGrade(int grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new Exception("Grade could not be less than 0 or greater than 100");
            }
            grades.Add(grade);
        }

        public void Display(int margin = 0)
        {
            Console.Write(new string('-', margin) + name + ": ");
            Console.Write("current grades: ");
            foreach (var grade in grades)
            {
                Console.Write( $"{grade} ");
            }
            Console.WriteLine();
        }

        public double GetAverageGrade()
        {
            double sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Count;
        }
    }
}
