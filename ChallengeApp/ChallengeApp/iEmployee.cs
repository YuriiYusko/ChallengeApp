using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public interface iEmployee
    {
        string Name { get; }
        string Surname { get; }
        void Hello();
        void AddGrade(int grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}
