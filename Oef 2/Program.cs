// Vraag de gebruiker om drie getallen in te voeren en toon het grootste getal. //

// Variabelen //
double no1, no2, no3;

// Input //
Console.WriteLine("Getal 1: ");
no1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Getal 2: ");
no2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Getal 3: ");
no3 = Convert.ToDouble(Console.ReadLine());

// Conditionals //

if (no1 > no2 && no1 > no3)
{
    System.Console.WriteLine(no1);
}
else if (no2 > no1 && no2 > no3)
{
    System.Console.WriteLine(no2);
}
else
{
    System.Console.WriteLine(no3);
}
