using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class EmployeeStatisticsTest
    {
        Random random = new Random();

        

        [Test]
        public void EmployeeStatTest()
        {
            Employee emp = new Employee("Test", "Test");

            float Average = 0;
            float Max = float.MinValue;
            float Min = float.MaxValue;

            for (int i = 0; i < 10; i++){
                var value = random.Next(101);
                Console.WriteLine($"{i+1} - {value}");
                emp.AddGrade(value);
                Max = Math.Max(value, Max);
                Min = Math.Min(value, Min);
                Average += value;
            }
            Average /= 10;
            Statistics stat = emp.GetStatistics();

            Console.WriteLine($"Max result - {emp.GetStatistics().Max}, expectation - {Max}");
            Console.WriteLine($"Min result - {emp.GetStatistics().Min}, expectation - {Min}");
            Console.WriteLine($"Average result - {emp.GetStatistics().Average}, expectation - {Average}");

            Assert.That(stat.Max, Is.EqualTo(Max));
            Assert.That(stat.Min, Is.EqualTo(Min));
            Assert.That(stat.Average, Is.EqualTo(Average));
        }

        [Test]
        public void EmploeyyStatTestLeter()
        {
            Employee emp = new Employee("Test", "Test");

            float average = 0;

            for (int i = 0; i < 10; i++)
            {
                var value = random.Next(101);
                Console.WriteLine($"{i + 1} - {value}");
                emp.AddGrade(value);
                average += value;
            }
            average /= 10;
            Console.WriteLine($"Average is - {average}");

            char Leter;
            switch (average)
            {
                case var aver when aver >= 80:
                    Leter = 'A';
                    break;
                case var aver when aver >= 60:
                    Leter = 'B';
                    break;
                case var aver when aver >= 40:
                    Leter = 'C';
                    break;
                case var aver when aver >= 20:
                    Leter = 'D';
                    break;
                default:
                    Leter = 'E';
                    break;
            }
            Console.WriteLine($"Result - {emp.GetStatistics().AverageLeter}, expectation - {Leter}");
            Assert.AreEqual(emp.GetStatistics().AverageLeter, Leter);
        }
    }
}
