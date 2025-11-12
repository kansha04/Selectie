// Maak een simpel login systeem: //

using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        // Variabelen //
        string gebruikersnaam = "admin";
        string wachtwoord = "geheim123";
        string inputgebruiker, inputww;

        // Login Input // 
        Console.WriteLine("Gebruikersnaam: ");
        inputgebruiker = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Wachtwoord: ");
        inputww = Console.ReadLine() ?? string.Empty;

        // Conditional // 
        if (gebruikersnaam == inputgebruiker && wachtwoord == inputww)
        {
            Console.WriteLine("Welkom, admin!");
        }
        else if (gebruikersnaam != inputgebruiker && wachtwoord == inputww)
        {
            Console.WriteLine("Onbekende gebruiker");
        }
        else if (gebruikersnaam == inputgebruiker && wachtwoord != inputww)
        {
            Console.WriteLine("Incorrect wachtwoord");
        }
        else
        {
            System.Console.WriteLine("Error! Try again later.");
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}