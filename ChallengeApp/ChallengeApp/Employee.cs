using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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
            if (ValidationBetween0and100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(short grade)
        {
            float gradeFloat = grade;
            if (ValidationBetween0and100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(int grade)
        {
            float gradeFloat = grade;
            if (ValidationBetween0and100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(long grade)
        {
            float gradeFloat = grade;
            if (ValidationBetween0and100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(float grade)
        {
            if (ValidationBetween0and100(grade)) { grades.Add(grade); }
        }

        public void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;
            if (ValidationBetween0and100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(decimal grade)
        {
            float gradeFloat = (float)grade;
            if (ValidationBetween0and100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                if (ValidationBetween0and100(result)) { grades.Add(result); }
            }
            else
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        grades.Add(100);
                        break;
                    case 'B':
                    case 'b':
                        grades.Add(80);
                        break;
                    case 'C':
                    case 'c':
                        grades.Add(60);
                        break;
                    case 'D':
                    case 'd':
                        grades.Add(40);
                        break;
                    case 'E':
                    case 'e':
                        grades.Add(20);
                        break;
                    default:
                        Console.WriteLine($"Attention: '{grade}' cannot be converted to float.");
                        break;
                }
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                if (ValidationBetween0and100(result)) { grades.Add(result); }
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        grades.Add(100);
                        break;
                    case "B":
                    case "b":
                        grades.Add(80);
                        break;
                    case "C":
                    case "c":
                        grades.Add(60);
                        break;
                    case "D":
                    case "d":
                        grades.Add(40);
                        break;
                    case "E":
                    case "e":
                        grades.Add(20);
                        break;
                    default:
                        Console.WriteLine($"Attention: '{grade}' cannot be converted to float.");
                        break;
                }
            }

        }

        private bool ValidationBetween0and100(float grade)
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

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLeter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLeter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLeter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLeter = 'D';
                    break;
                default:
                    statistics.AverageLeter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
