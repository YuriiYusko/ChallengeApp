using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestValueType()
        {
            //arrange
            int number0 = 2;
            int number1 = 2;

            //act

            //assert
            Assert.AreEqual(number0, number1);
        }




        [Test]
        public void TestReferenceTypeFalse()
        {
            //arrange
            var emp1 = GetEmployee();
            var emp2 = GetEmployee();

            //act

            //assert
            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void TestReferenceTypeTrue()
        {
            //arrange
            Employee emp1 = GetEmployee();
            Employee emp2 = GetEmployee();
            emp1.SetPoint(5);
            emp2.SetPoint(5);
            //act

            //assert
            Assert.AreEqual(emp1.ScoreRating, emp2.ScoreRating);
        }

        private Employee GetEmployee ()
        {
            return new Employee();
        }
    }
}
