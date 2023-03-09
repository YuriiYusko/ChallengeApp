using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private string name;
        private string surname;
        private int age;
        private int scoreRating;

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.scoreRating = 0;
        }

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public int Age { get { return age; } }
        public int ScoreRating { get { return scoreRating; } }

        public void SetPoint(int point)
        {
            if (point > -5 && point <= 10)
            {
                this.scoreRating += point;
            }
        }

        public static void WhoIsTheBest(List<Employee> employeeList)
        {
            int bestIsNumber = 0;
            int largestPoints = 0;
            //Szukamy kto ma najwięcej punktów
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].scoreRating > largestPoints)
                {
                    bestIsNumber = i;
                    largestPoints = employeeList[i].scoreRating;
                }
            }
            //Sprawdzamy remis
            int countBestEmployers = 0;
            foreach (Employee e in employeeList)
            {
                if (e.ScoreRating == largestPoints)
                {
                    countBestEmployers++;
                }
            }
            //Wyniki
            if (countBestEmployers < 2)
            {
                Console.WriteLine("Najwięcej punktów ("
                    + largestPoints
                    + ") posiada pracownik "
                    + employeeList[bestIsNumber].Name
                    + " "
                    + employeeList[bestIsNumber].Surname
                    + " (Wiek - "
                    + (employeeList[bestIsNumber].Age
                    + ")"));
            }
            else
            {
                Console.WriteLine("Dwie lub więcej osoby posiadają jednakową liczbę punktów.");
            }
        }
    }
}
