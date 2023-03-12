// My first App

//Dzień 6: Klasy i metody w klasie


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        var employee0 = new Employee("Yurii", "Yusko");
        employee0.AddGrade(2);
        employee0.AddGrade(10);
        employee0.AddGrade(5);
        var statistics = employee0.GetStatistics();
        Console.WriteLine($"Max is {statistics.Max}");
        Console.WriteLine($"Min is {statistics.Min}");
        Console.WriteLine($"Average is {statistics.Average:N2}");
    }
}