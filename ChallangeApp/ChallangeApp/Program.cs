﻿using ChallangeApp;

Console.WriteLine("Witaj w Programie do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();

var employee = new Employee("Adam", "Zyniec");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break; 
    }
    employee.AddGrade(input);
}

var statistics =employee.GetStatistics();
Console.WriteLine();
Console.WriteLine("Statystyki pracownika:");
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Średnia ocena literowa: {statistics.AverageLetter}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
