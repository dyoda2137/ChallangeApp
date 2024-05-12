using ChallangeApp;

Employee employee1 = new Employee("Tomasz", "Dziedzic", 24);
Employee employee2 = new Employee("Anna", "Sowa", 29);
Employee employee3 = new Employee("Piotr", "Kwarciak", 36);

employee1.AddScore(7);
employee1.AddScore(4);
employee1.AddScore(9);
employee1.AddScore(3);
employee1.AddScore(5);

employee2.AddScore(6);
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(1);
employee2.AddScore(2);

employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(7);
employee3.AddScore(4);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    { 
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najwięciej punktów zdobył pracownik");
Console.WriteLine("Imię: " + employeeWithMaxResult.Name);
Console.WriteLine("Nazwisko: " + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek: " + employeeWithMaxResult.Age);
Console.WriteLine("Wynik: " + employeeWithMaxResult.Result);