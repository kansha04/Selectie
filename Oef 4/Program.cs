// Maak een simpel login systeem: //

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
        inputgebruiker = Console.ReadLine();
        Console.WriteLine("Wachtwoord: ");
        inputww = Console.ReadLine();

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
}