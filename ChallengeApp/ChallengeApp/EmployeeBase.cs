using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChallengeApp
{
    public abstract class EmployeeBase : iEmployee
    {
        public delegate void GradeAddeDelegate(object sender, EventArgs args);
        public event GradeAddeDelegate GradeAdde;

        //Constructors
        public EmployeeBase()
        {
            this.Name = "Noname";
            this.Surname = "Nosurname";
            this.Gender = "N";
        }
        public EmployeeBase(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        //Property
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }

        //Methods
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
        public virtual void OnGradeAdde(EventArgs args)
        {
            if (GradeAdde != null)
            {
                GradeAdde(this, args);
            }
        }
        public virtual void Hello()
        {
            Console.WriteLine($"Czesć,mam na imię {Name} {Surname}");
        }
        protected static bool ValidationFrom0to100(float grade)
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
    }
}
