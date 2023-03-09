// My first App

//Dzień 6: Klasy i metody w klasie


using System;
using System.Collections.Generic;

namespace ChallengeApp;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Yurii", "Yusko", 30),
            new Employee("Adam", "Stupka", 23),
            new Employee("Zuzia", "Marchewka", 25),
            new Employee("Adrian", "Piotrowski", 28),
            new Employee("Jolanta", "Stępień", 43)
        };
        Random rnd = new Random();

        foreach (Employee e in employees)
        {
            for (int i = 0; i < 5; i++)
            {
                e.SetPoint(rnd.Next(-5, 10));
            }
            Console.WriteLine(e.Name + " - " + e.ScoreRating);
        }

        Console.WriteLine();
        Employee.WhoIsTheBest(employees);

    }

}