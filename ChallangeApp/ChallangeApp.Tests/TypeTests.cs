namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntTest()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Zyniec", 33);
            var employee2 = GetEmployee("Tomasz","Kwarciak",33);

            //act

            //assert
            Assert.AreEqual(employee1.Age, employee2.Age);
        }

        [Test]
        public void ObjectTest()
        {
            //arrange
            var employee1 = GetEmployee("Marcin", "Gora", 25);
            var employee2 = GetEmployee("Marcin", "Gora", 25);

            //act

            //assert
            Assert.AreNotEqual(employee1 , employee2);
        }

        [Test]

        public void StringTest()
        {
            //arrange
            var employee1 = GetEmployee("Anna", "Kowalska", 30);
            var employee2 = GetEmployee("Anna", "Nowak", 28);

            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name,surname,age);
        }
    }
}
