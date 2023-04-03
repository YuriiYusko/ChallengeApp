using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase, iEmployee 
    {
        //Variables
        private readonly string fileName = "data/grades.txt";

        //Constructors
        public EmployeeInFile(string name, string surname, string gender) :
            base(name, surname, gender) 
        {
            File.WriteAllText(fileName, string.Empty);
        }

        //Methods
        public override void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }
        public override void AddGrade(float grade)
        {
            if (ValidationFrom0to100(grade))
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                OnGradeAdde(new EventArgs());
            }
        }
        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public override void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                if (ValidationFrom0to100(result))
                {
                    AddGrade(result);
                }
            }
            else
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        AddGrade(20);
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
                    AddGrade(result);
                }
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        AddGrade(100);
                        break;
                    case "B":
                    case "b":
                        AddGrade(80);
                        break;
                    case "C":
                    case "c":
                        AddGrade(60);
                        break;
                    case "D":
                    case "d":
                        AddGrade(40);
                        break;
                    case "E":
                    case "e":
                        AddGrade(20);
                        break;
                    default:
                        throw new Exception($"Attention: '{grade}' cannot be converted to float.");
                }
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        statistics.AddGrade(float.Parse(line));
                    }
                }
            }
            return statistics;
        }
    }
}
