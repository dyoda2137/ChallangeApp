namespace ChallangeApp.Tests
{
    public class TestEmployee
    {
        private Statistics statistics;
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnAvverageGrade()
        {
            // arrange
            Employee employee = new Employee("Adam", "Zyniec");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();
           
            // assert
            Assert.AreEqual(5.00, statistics.Average);
        }

        [Test]
        public void WhenEmployee2CollectScore_ThenCorrectResult()
        {
            // arrange
            Employee employee = new Employee("Adam", "Zyniec");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();
         
            // assert
            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void WhenEmployee3CollectScore_ThenCorrectResult()
        {
            // arrange
            Employee employee = new Employee("Adam", "Zyniec");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();
        
            // assert
            Assert.AreEqual(2, statistics.Min);
        }
    }
}