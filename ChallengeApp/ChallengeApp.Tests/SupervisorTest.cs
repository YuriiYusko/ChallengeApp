using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    internal class SupervisorTest
    {
        [Test]
        public void SupervisorTestAverag()
        {
            Supervisor emp = new Supervisor("Test", "Test", "T");

            emp.AddGrade("6");
            Console.WriteLine($"1 - {"6"}");
            emp.AddGrade("-3");
            Console.WriteLine($"2 - {"-3"}");
            emp.AddGrade("2-");
            Console.WriteLine($"3 - {"2-"}");

            float res = 50;

            Console.WriteLine($"Result - {emp.GetStatistics().Average}, expectation - {res}");
            Assert.That(res, Is.EqualTo(emp.GetStatistics().Average));
        }

        [Test]
        public void SupervisorTestMin()
        {
            Supervisor emp = new Supervisor("Test", "Test", "T");

            emp.AddGrade("6");
            Console.WriteLine($"1 - {"6"}");
            emp.AddGrade("-3");
            Console.WriteLine($"2 - {"-3"}");
            emp.AddGrade("2-");
            Console.WriteLine($"3 - {"2-"}");

            float res = 15;

            Console.WriteLine($"Result - {emp.GetStatistics().Min}, expectation - {res}");
            Assert.That(res, Is.EqualTo(emp.GetStatistics().Min));
        }

        [Test]
        public void SupervisorTestMax()
        {
            Supervisor emp = new Supervisor("Test", "Test", "T");

            emp.AddGrade("6-");
            Console.WriteLine($"1 - {"6-"}");
            emp.AddGrade("-3");
            Console.WriteLine($"2 - {"-3"}");
            emp.AddGrade("2-");
            Console.WriteLine($"3 - {"2-"}");

            float res = 95;

            Console.WriteLine($"Result - {emp.GetStatistics().Max}, expectation - {res}");
            Assert.That(res, Is.EqualTo(emp.GetStatistics().Max));
        }
    }
}
