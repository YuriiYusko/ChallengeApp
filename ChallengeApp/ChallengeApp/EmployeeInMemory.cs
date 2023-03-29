using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new();

        public EmployeeInMemory(string name, string surname, string gender) :
            base(name, surname, gender)
        { }

        public override void AddGrade(int grade)
        {
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public override void AddGrade(float grade)
        {
            if (ValidationFrom0to100(grade)) { grades.Add(grade); }
        }

        public override void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;
            if (ValidationFrom0to100(gradeFloat)) { grades.Add(gradeFloat); }
        }

        public override void AddGrade(char grade)
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

        public override void AddGrade(string grade)
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

        public override Statistics GetStatistics()
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
