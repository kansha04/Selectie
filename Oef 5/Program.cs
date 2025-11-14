/* Maak een ticket prijs calculator voor een bioscoop:
Basis prijs: €12
Kinderen (< 12): €7
Studenten (met studentenkaart): €9
Senioren (65+): €8
VIP leden: 20% korting op hun prijs */

using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        // Variabelen //
        double basisPrijs = 12.0;
        double kindPrijs = 7.0;
        double studentPrijs = 9.0;
        double senioren = 8.0;
        double vipPrijs = 0.2;
        int leeftijd;
        bool studentenkaart, vip;
        double totaalPrijs = 0.0;

        // Input //
        Console.WriteLine("Hoe oud ben je?: ");
        leeftijd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ben je een student met een studentenkaart? (true or false): ");
        studentenkaart = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Heb je een VIP lidmaatschaap? (true or false): ");
        vip = Convert.ToBoolean(Console.ReadLine());

        // Conditional needs to be fixed // 
        if (leeftijd < 12)
        {
            totaalPrijs = kindPrijs;
        }
        else if (leeftijd >= 65)
        {
            totaalPrijs = senioren;
        }
        else if (studentenkaart)
        {
            totaalPrijs = studentPrijs;
        }
        else
        {
            totaalPrijs = basisPrijs;
        }

        // VIP korting (20%) op de reeds toegewezen prijs
        if (vip)
        {
            totaalPrijs -= totaalPrijs * vipPrijs;
        }

        // Output //
        Console.WriteLine($"Uw totaal is: €{totaalPrijs:F2}");
    }
}