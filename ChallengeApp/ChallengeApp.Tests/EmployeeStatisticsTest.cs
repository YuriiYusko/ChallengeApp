using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class EmployeeStatisticsTest
    {
        Random random = new Random();

        Employee emp = new Employee("Test", "Test");

        [Test]
        public void EmployeeStatTest()
        {

            float Average = 0;
            var Max = float.MinValue;
            var Min = float.MaxValue;

            for (int i = 0; i < 10; i++){
                var value = random.Next(101);
                Console.WriteLine(value);
                emp.AddGrade(value);
                Max = Math.Max(value, Max);
                Min = Math.Min(value, Min);
                Average += value;
            }

            Statistics stat = emp.GetStatistics();

            Assert.That(stat.Max, Is.EqualTo(Max));
            Assert.That(stat.Min, Is.EqualTo(Min));
            Assert.That(stat.Average, Is.EqualTo(Average / 10));
        }
    }
}
