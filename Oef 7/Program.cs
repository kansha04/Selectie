/* Oefening 5.7: Temperatuur Advies
Vraag de gebruiker om de temperatuur in graden Celsius en geef advies:
< 0°: "Vriest! Trek een dikke jas aan. ❄"
0°
10°
20°
- 10°: "Koud. Een jas is nodig. 🧥"
- 20°: "Mild weer. Een trui is voldoende. 🧶"
- 30°: "Lekker weer! T-shirt tijd. ☀"
Vandegaer B. Cursussen
✦ 24 / 39 ✦
30°: "Heel heet! Blijf gehydrateerd. 🥵" */

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Voer de temperatuur in graden Celsius in (bv. 15.5): ");
        string input = Console.ReadLine();

        if (!double.TryParse(input, out double temp))
        {
            Console.WriteLine("Ongeldige invoer. Gebruik een getal, bijv. 12.5");
            return;
        }

        string advies;

        if (temp < 0)
        {
            advies = "Vriest! Trek een dikke jas aan. ❄";
        }
        else if (temp < 10) // 0 - 9.9
        {
            advies = "Koud. Een jas is nodig. 🧥";
        }
        else if (temp < 20) // 10 - 19.9
        {
            advies = "Mild weer. Een trui is voldoende. 🧶";
        }
        else if (temp < 30) // 20 - 29.9
        {
            advies = "Lekker weer! T-shirt tijd. ☀";
        }
        else // 30+
        {
            advies = "Heel heet! Blijf gehydrateerd. 🥵";
        }

        Console.WriteLine($"{temp}°C — {advies}");
    }
}

