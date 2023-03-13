using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(byte grade)
        {
            float gradeFloat = grade;
            if (Validation(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(short grade)
        {
            float gradeFloat = grade;
            if (Validation(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(int grade)
        {
            float gradeFloat = grade;
            if (Validation(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(long grade)
        {
            float gradeFloat = grade;
            if (Validation(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(float grade)
        {
            if (Validation(grade)) { grades.Add(grade); }
        }

        public void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;
            if (Validation(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(decimal grade)
        {
            float gradeFloat = (float)grade;
            if (Validation(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                if (Validation(result)) { grades.Add(result); }
            }
            else
            {
                Console.WriteLine($"Attention: Char '{grade}' cannot be converted to float.");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                if (Validation(result)) { grades.Add(result); }
            }
            else
            {
                Console.WriteLine($"Attention: String '{grade}' cannot be converted to float.");
            }
        }

        private bool Validation(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Attention: {grade} is incorrect value, correct is between 0 and 100.");
                return false;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
