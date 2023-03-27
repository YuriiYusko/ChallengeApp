using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, string gender) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }

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
