// Schrijf een programma dat de gebruiker vraagt om een getal en controleert of het even of oneven is.

// Variabelen
int getal;

// Input //
Console.WriteLine("Geef een getal");
getal = Convert.ToInt32(Console.ReadLine());

// Conditional //
if (getal % 2 == 0)
{
    System.Console.WriteLine("Uw getal is even!");
} else
{
    System.Console.WriteLine("Uw getal is oneven!");
}