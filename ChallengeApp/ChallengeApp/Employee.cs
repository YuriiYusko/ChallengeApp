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
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public void AddGrade(short grade)
        {
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public void AddGrade(int grade)
        {
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public void AddGrade(long grade)
        {
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public void AddGrade(float grade)
        {
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;
            if (ValidationFrom0to100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(decimal grade)
        {
            float gradeFloat = (float)grade;
            if (ValidationFrom0to100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                if (ValidationFrom0to100(result)) { grades.Add(result); }
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
                        throw new Exception($"Attention: '{grade}' cannot be converted to float.");
                }
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                if (ValidationFrom0to100(result)) { grades.Add(result); }
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
                        throw new Exception($"Attention: '{grade}' cannot be converted to float.");
                }
            }

        }

        private static bool ValidationFrom0to100(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                return true;
            }
            else
            {
                throw new Exception($"Attention: {grade} is incorrect value, correct is between 0 and 100.");
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

            statistics.AverageLeter = statistics.Average switch
            {
                var average when average >= 80 => 'A',
                var average when average >= 60 => 'B',
                var average when average >= 40 => 'C',
                var average when average >= 20 => 'D',
                _ => 'E',
            };
            return statistics;
        }
    }
}
