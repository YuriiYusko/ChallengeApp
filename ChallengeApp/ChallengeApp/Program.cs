﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        var employee0 = new Employee("Yurii", "Yusko");

        byte iByte = 25;
        employee0.AddGrade(iByte);

        short iShort = 72;
        employee0.AddGrade(iShort);

        int iInt = 11;
        employee0.AddGrade(iInt);

        double iDouble = 33.5;
        employee0.AddGrade(iDouble);

        decimal iDecimal = 25.5M;
        employee0.AddGrade(iDecimal);

        employee0.AddGrade("89");

        employee0.AddGrade('9');

        Console.WriteLine("For");
        var statistics = employee0.GetStatisticsFor();
        Console.WriteLine($"Max is {statistics.Max}");
        Console.WriteLine($"Min is {statistics.Min}");
        Console.WriteLine($"Average is {statistics.Average:N2}");
        Console.WriteLine();
        Console.WriteLine("ForEach");
        statistics = employee0.GetStatisticsForEach();
        Console.WriteLine($"Max is {statistics.Max}");
        Console.WriteLine($"Min is {statistics.Min}");
        Console.WriteLine($"Average is {statistics.Average:N2}");
        Console.WriteLine();
        Console.WriteLine("While");
        statistics = employee0.GetStatisticsWhile();
        Console.WriteLine($"Max is {statistics.Max}");
        Console.WriteLine($"Min is {statistics.Min}");
        Console.WriteLine($"Average is {statistics.Average:N2}");
        Console.WriteLine();
        Console.WriteLine("DoWhile");
        statistics = employee0.GetStatisticsDoWhile();
        Console.WriteLine($"Max is {statistics.Max}");
        Console.WriteLine($"Min is {statistics.Min}");
        Console.WriteLine($"Average is {statistics.Average:N2}");
        Console.WriteLine();
    }
}