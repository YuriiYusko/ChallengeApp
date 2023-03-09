using System.Drawing;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeSetPointsTest()
        {
            //arange
            var employer0 = new Employee("Yurii", "Yusko", 30);

            //act
            Random rnd = new Random();
            var result = 0;
            var point = 0;
            for (int i = 0; i < 5; i++)
            {
                point = rnd.Next(-5, 10);
                employer0.SetPoint(point);
                result += point;
            }

            //assert
            Assert.AreEqual(result, employer0.ScoreRating);
        }
    }
}