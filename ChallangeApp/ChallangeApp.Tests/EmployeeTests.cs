namespace ChallangeApp.Tests
{
    public class TestEmployee
    {
        private Statistics statistics;

        [Test]
        public void StatisticsCharLetterA()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade(80);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]
        public void StatisticsCharLetterB()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade(60);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void StatisticsCharLetterC()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade(40);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void StatisticsAverageChar()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade("a");
            employee.AddGrade("b");
            employee.AddGrade("C");

            var statistics = employee.GetStatistics();
            
            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]

        public void StatisticsAverageValue()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade(20);
            employee.AddGrade(90);
            employee.AddGrade(40);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(50, statistics.Average);
        }

        [Test]
        public void StatisticsCorrectResultMaxValue()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade(20);
            employee.AddGrade(70);
            employee.AddGrade(50);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(70, statistics.Max);
        }

        [Test]
        public void StatisticsCorrectResultMinValue()
        {
            var employee = new EmployeeInMemory("Adam", "Zyniec");
            employee.AddGrade(50);
            employee.AddGrade(70);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }
    }
}