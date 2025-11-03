using System.ComponentModel.Design;

using System.Runtime.InteropServices.JavaScript;

int age;

char geslacht;

bool ismedewerker;

Console.WriteLine("wat is u leeftijd");

age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wat is u geslacht? (M,V,X): ");

geslacht = Convert.ToChar(Console.ReadLine().ToUpper());

Console.WriteLine("bent u een mederwerker (true, false)");

ismedewerker = Convert.ToBoolean(Console.ReadLine());

if ((age >= 18 && geslacht == 'V') || ismedewerker)

{

    Console.WriteLine("u mag binnen");

}

else

{

    Console.WriteLine("u mag niet binnen ");

}

// voorbeeld alcohol controle


// leeftijd kleiner dan aanj 16 GEEN ALCohol

if (age < 16)

{

    Console.WriteLine("je mag geen alcohol drinken");

}

else if (age < 18)

{

    Console.WriteLine("u mag bier en wijn drinken");

}

else

{

    Console.WriteLine("u mag alle drank drinken");

    if (age >= 21)

    {

        Console.WriteLine("je mag ook gokken");

    }

}
