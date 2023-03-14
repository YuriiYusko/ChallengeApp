using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
        Console.WriteLine("===========================================");
        Console.WriteLine("Podaj oceny pracownika:");

        var employee = new Employee("Yurii", "Yusko");

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "e") { break; }
            employee.AddGrade(input);
        }

        var statistics = employee.GetStatistics();
        Console.WriteLine($"Max - {statistics.Max}");
        Console.WriteLine($"Min - {statistics.Min}");
        Console.WriteLine($"Average - {statistics.Average}");
        Console.WriteLine($"Average(leter) - {statistics.AverageLeter}");
    }
}