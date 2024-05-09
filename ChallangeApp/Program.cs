var name = "Tomek";
var age = 30;
var sex = "men";

if (sex == "woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex == "men" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}