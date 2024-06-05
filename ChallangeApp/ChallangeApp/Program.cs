using ChallangeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "", surname = "";

        Console.WriteLine("===========================================================");
        Console.WriteLine("||         Witaj w Programie do oceny  Pracowników       ||");
        Console.WriteLine("===========================================================");
        Console.WriteLine("||      Dodaj pracownika (P),   aby zankonćzyć (Q)       ||");

        var type = Console.ReadLine();

        switch (type)
        {
            case "Q":
            case "q":
                {
                    return;
                }
            case "P":
            case "p":
                {
                    var employee = new EmployeeInFile(name, surname);
                    Console.WriteLine("Podaj imię pracownika :");
                    name = Console.ReadLine();
                    Console.WriteLine("Podaj nazwisko pracownika :");
                    surname = Console.ReadLine();
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
                    Console.WriteLine($"Ilość ocen: {statistics.Count}");
                    Console.WriteLine($"Średnia ocen: {statistics.Average:N2}");
                    Console.WriteLine($"Średnia ocena literowa: {statistics.AverageLetter}");
                    Console.WriteLine($"Najniższa ocena: {statistics.Min}");
                    Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
                }
                break;
        }
    }
}
