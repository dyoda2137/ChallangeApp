namespace ChallangeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, string genger, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = genger;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; private set;}
    }
    
}
