using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase, iEmployee
    {
        //Variables
        private List<float> grades;

        //Constructors
        public EmployeeInMemory(string name,string surname,string gender) :
            base(name, surname, gender) 
        {
            grades = new();
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
                this.grades.Add(grade);
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
                if (ValidationFrom0to100(result)) { AddGrade(result); }
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
            if (float.TryParse(grade, out float result))
            {
                if (ValidationFrom0to100(result)) { AddGrade(result); }
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

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }

    }
}
