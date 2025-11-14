/* Een jaar is een schrikkeljaar als:
Het deelbaar is door 4, EN
Het NIET deelbaar is door 100, OF het IS deelbaar door 400 */

internal class Program
{
    private static void Main(string[] args)
    {
        // Variabelen //
        int jaar;

        // Input //
        Console.WriteLine("Geef een jaar: (vb. 2004)");
        jaar = int.Parse(Console.ReadLine());

        // Conditional //
        if (jaar % 4 == 0 && jaar % 100 != 0 || jaar % 400 == 0)
        {
            Console.WriteLine($"Het jaar {jaar} is een schrikkeljaar.");
        }
        else
        {
            Console.WriteLine($"Het jaar {jaar} is geen schrikkeljaar.");
        }
    }
}