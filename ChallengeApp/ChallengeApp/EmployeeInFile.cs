using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private string fileName = "grades.txt";

        private List<float> grades = new();

        public EmployeeInFile(string name, string surname, string gender) :
            base(name, surname, gender)
        { }

        public override void AddGrade(int grade)
        {
            if (ValidationFrom0to100(grade))
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
        }

        public override void AddGrade(float grade)
        {
            if (ValidationFrom0to100(grade))
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;
            if (ValidationFrom0to100(gradeFloat))
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(gradeFloat);
                }
            }

        }

        public override void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                if (ValidationFrom0to100(result))
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                    }
                }
            }
            else
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(100);
                        }
                        break;
                    case 'B':
                    case 'b':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(80);
                        }
                        break;
                    case 'C':
                    case 'c':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(60);
                        }
                        break;
                    case 'D':
                    case 'd':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(40);
                        }
                        break;
                    case 'E':
                    case 'e':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(20);
                        }
                        break;
                    default:
                        throw new Exception($"Attention: '{grade}' cannot be converted to float.");
                }
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                if (ValidationFrom0to100(result))
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                    }
                }
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(100);
                        }
                        break;
                    case "B":
                    case "b":
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(80);
                        }
                        break;
                    case "C":
                    case "c":
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(60);
                        }
                        break;
                    case "D":
                    case "d":
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(40);
                        }
                        break;
                    case "E":
                    case "e":
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(20);
                        }
                        break;
                    default:
                        throw new Exception($"Attention: '{grade}' cannot be converted to float.");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        grades.Add(float.Parse(line));
                    }
                }
            }

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
