using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Supervisor : Person, iEmployee
    {
        private List<float> grades = new();

        public Supervisor()
            : this("Noname", "Nosurname", "N") { }

        public Supervisor(string name, string surname, string gender)
            : base(name, surname, gender) { }

        public void Hello()
        {
            Console.WriteLine($"Czesć,mam na imię {Name} i jestem kierownikiem.");
        }

        public void AddGrade(int grade)
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
            switch (grade)
            {
                //--6--
                case "6":
                    grades.Add(100);
                    break;
                case var gr when (gr == "-6" || gr == "6-"):
                    grades.Add(95);
                    break;
                //--5--
                case var gr when (gr == "+5" || gr == "5+"):
                    grades.Add(85);
                    break;
                case "5":
                    grades.Add(80);
                    break;
                case var gr when (gr == "-5" || gr == "5-"):
                    grades.Add(75);
                    break;
                //--4--
                case var gr when (gr == "+4" || gr == "4+"):
                    grades.Add(65);
                    break;
                case "4":
                    grades.Add(60);
                    break;
                case var gr when (gr == "-4" || gr == "4-"):
                    grades.Add(55);
                    break;
                //--3--
                case var gr when (gr == "+3" || gr == "3+"):
                    grades.Add(45);
                    break;
                case "3":
                    grades.Add(40);
                    break;
                case var gr when (gr == "-3" || gr == "3-"):
                    grades.Add(35);
                    break;
                //--2--
                case var gr when (gr == "+2" || gr == "2+"):
                    grades.Add(25);
                    break;
                case "2":
                    grades.Add(20);
                    break;
                case var gr when (gr == "-2" || gr == "2-"):
                    grades.Add(15);
                    break;
                //--1--
                case var gr when (gr == "+1" || gr == "1+"):
                    grades.Add(5);
                    break;
                case "1":
                    grades.Add(0);
                    break;
                //--Default--
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        if (ValidationFrom0to100(result)) { grades.Add(result); }
                        break;
                    }
                    else
                    {
                        throw new Exception($"Attention: '{grade}' cannot be converted to float.");
                    }
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

