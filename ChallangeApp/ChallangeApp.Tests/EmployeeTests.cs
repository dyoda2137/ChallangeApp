namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployee1CollectScore_ThenCorrectResult()
        {
            // arrange
            Employee employee1 = new Employee("Adam","Zyniec",33);
            employee1.AddScore(5);
            employee1.AddScore(7);
            employee1.AddScore(-2);
            
            //act
            var result = employee1.Result;

            // assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void WhenEmployee2CollectScore_ThenCorrectResult()
        {
            // arrange
            Employee employee2 = new Employee("Monika", "Tomaszewska", 25);
            employee2.AddScore(9);
            employee2.AddScore(-5);
            employee2.AddScore(7);

            //act
            var result = employee2.Result;

            // assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenEmployee3CollectScore_ThenCorrectResult()
        {
            // arrange
            Employee employee3 = new Employee("Mateusz", "Bugala", 28);
            employee3.AddScore(7);
            employee3.AddScore(-1);
            employee3.AddScore(6);

            //act

            var result = employee3.Result;

            // assert
            Assert.AreEqual(12, result);
        }
    }
}