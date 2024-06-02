using ChallangeApp;

string name = "", surname = "";

Console.WriteLine("===========================================================");
Console.WriteLine("|| Witaj w Programie do oceny Kierowników i Pracowników  ||");
Console.WriteLine("===========================================================");
Console.WriteLine("||Dodaj pracownika (P), kierownika (K), (Q) aby zakończyć||");

var position = Console.ReadLine();

switch (position)
{
    case "Q":
    case "q":
        {
            return;
        }
    case "P":
    case "p":
        {
            AddPerson("Pracownika", 1);
            var employee = new EmployeeInMemory(name, surname);
            employee.GradeAdded += EmployeeGradeAdded;

            void EmployeeGradeAdded(object sender, EventArgs args)
            {
                Console.WriteLine("Dodano ocenę");
            }

            while (true)
            {
                Console.WriteLine($"Podaj ocenę od 0 do 100 lub A do E dla Pracownika: {name} {surname} ");
                var input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    break;
                }
                try
                {
                    employee.AddGrade(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            var statistics = employee.GetStatistics();
            Console.WriteLine();
            Console.WriteLine($"Średnia ocen: {statistics.Average:N2}");
            Console.WriteLine($"Średnia ocena literowa: {statistics.AverageLetter}");
            Console.WriteLine($"Najniższa ocena: {statistics.Min}");
            Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
        }
        break;
    case "K":
    case "k":
        {
            AddPerson("Kierownika", 2);
            var supervisor = new Supervisor(name, surname);
            supervisor.GradeAdded += EmployeeGradeAdded;

            void EmployeeGradeAdded(object sender, EventArgs args)
            {
                Console.WriteLine("Dodano ocenę");
            }

            while (true)
            {
                Console.WriteLine($"Podaj ocenę od 1 do 6 lub A do E dla Kierownika:  {name} {surname}  ");
                var input = Console.ReadLine();
                            
                if (input == "q" || input == "Q")
                {
                    break;
                }
                try
                {
                    supervisor.AddGrade(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            var statistics = supervisor.GetStatistics();
            Console.WriteLine();
            Console.WriteLine($"Średnia ocen: {statistics.Average:N2}");
            Console.WriteLine($"Średnia ocena literowa: {statistics.AverageLetter}");
            Console.WriteLine($"Najniższa ocena: {statistics.Min}");
            Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
        }
        break;
}

void Employee_GradeAdded(object sender, EventArgs args)
{
    throw new NotImplementedException();
}

void AddPerson(string personType, int idPerson)
{
    switch (idPerson)
    {
        case 1:
            {
                Console.WriteLine($"Podaj imię {personType} :");
                name = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko {personType} :");
                surname = Console.ReadLine();
            }
            break;
        case 2:
            {
                Console.WriteLine($"Podaj imię {personType} :");
                name = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko {personType} :");
                surname = Console.ReadLine();
            }
            break;
    }
}


