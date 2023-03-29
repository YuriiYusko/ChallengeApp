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
        Console.WriteLine("1). Znaczenie cyfrowe od 0 do 100");
        Console.WriteLine("2). Literą: A=100, B=80, C=60, D=40, E=20");
        //Console.WriteLine("2). Cyfra: 6=100, 5=80, 4=60, 3=40, 2=20 1=0 - dla kierownika");
        Console.WriteLine("3). Literą: 'q' - wyswietlić wyniki");
        Console.WriteLine("===========================================");

        EmployeeInFile employee = new EmployeeInFile("Yurii", "Yusko", "M");
        employee.Hello();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "q") { break; }
            try
            {
                employee.AddGrade(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mesage: {ex.Message}");
            }
        }

        var statistics = employee.GetStatistics();
        Console.WriteLine($"Max - {statistics.Max}");
        Console.WriteLine($"Min - {statistics.Min}");
        Console.WriteLine($"Average - {statistics.Average:N2}");
        Console.WriteLine($"Average(leter) - {statistics.AverageLeter}");
    }
}