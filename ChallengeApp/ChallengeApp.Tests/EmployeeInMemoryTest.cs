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
    public class EmployeeInMemoryTest
    {
        Random random = new Random();

        [Test]
        public void EmployeeTestMin()
        {
            EmployeeInMemory emp = new EmployeeInMemory("Test", "Test", "T");

            float Min = float.MaxValue;

            for (int i = 0; i < 10; i++) {
                var value = random.Next(101);
                Console.WriteLine($"{i + 1} - {value}");
                emp.AddGrade(value);
                Min = Math.Min(value, Min);
            }

            Statistics stat = emp.GetStatistics();

            Console.WriteLine($"Min result - {emp.GetStatistics().Min}, expectation - {Min}");
            Assert.That(stat.Min, Is.EqualTo(Min));
        }
        [Test]
        public void EmployeeTestMax()
        {
            EmployeeInMemory emp = new EmployeeInMemory("Test", "Test", "T");

            float Max = float.MinValue;

            for (int i = 0; i < 10; i++)
            {
                var value = random.Next(101);
                Console.WriteLine($"{i + 1} - {value}");
                emp.AddGrade(value);
                Max = Math.Max(value, Max);
            }
            Statistics stat = emp.GetStatistics();

            Console.WriteLine($"Max result - {emp.GetStatistics().Max}, expectation - {Max}");

            Assert.That(stat.Max, Is.EqualTo(Max));
        }
        [Test]
        public void EmployeeTestAverag()
        {
            EmployeeInMemory emp = new EmployeeInMemory("Test", "Test", "T");

            float Average = 0;

            for (int i = 0; i < 10; i++)
            {
                var value = random.Next(101);
                Console.WriteLine($"{i + 1} - {value}");
                emp.AddGrade(value);
                Average += value;
            }
            Average /= 10;
            Statistics stat = emp.GetStatistics();

            Console.WriteLine($"Average result - {emp.GetStatistics().Average}, expectation - {Average}");

            Assert.That(stat.Average, Is.EqualTo(Average));
        }
        [Test]
        public void EmploeyyTestLeterPoint()
        {
            EmployeeInMemory emp = new EmployeeInMemory("Test", "Test", "T");

            emp.AddGrade("A");
            Console.WriteLine("A = 100");
            emp.AddGrade("B");
            Console.WriteLine("B = 80");
            emp.AddGrade("C");
            Console.WriteLine("C = 60");
            emp.AddGrade("D");
            Console.WriteLine("D = 40");
            emp.AddGrade("E");
            Console.WriteLine("E = 20");

            Console.WriteLine($"Result - {emp.GetStatistics().Average}, expectation - 60");
            Assert.That(emp.GetStatistics().Average, Is.EqualTo(60));
        }
        [Test]
        public void EmploeyyStatTestLeter()
        {
            EmployeeInMemory emp = new EmployeeInMemory("Test", "Test", "T");

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
            Assert.That(Leter, Is.EqualTo(emp.GetStatistics().AverageLeter));
        }

    }
}
