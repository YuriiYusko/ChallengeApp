using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Statistics
    {
        //Variables
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Suma { get; private set; }
        public float Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Suma / this.Count;
            }
        }
        public char AverageLeter
        {
            get
            {
                switch (this.Average )
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                       return 'E';
                }
            }
        }
        //Constructors
        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Suma = 0;
            this.Count = 0;
        }
        //Methods
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Suma += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}
