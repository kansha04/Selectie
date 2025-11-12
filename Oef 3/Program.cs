// Maak een BMI calculator die:
/*  
    1. Gewicht (kg) en lengte (m) vraagt
    2. BMI berekent: BMI = gewicht / (lengte * lengte)
    3. Advies geeft op basis van BMI:
    < 18.5: "Ondergewicht"
    18.5 - 24.9: "Normaal gewicht"
    25 - 29.9: "Overgewicht"
    = 30: "Obesitas"
*/

// Variabelen // 
double gewicht, lengte, bmi;
string advies;
// Input //
Console.WriteLine("Hoeveel weeg je in kg? (bv. 60.2): ");
gewicht = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hoe lang ben je in m? (bv. 1.8)");
lengte = Convert.ToDouble(Console.ReadLine());

// BMI Berekenen //
bmi = Math.Round(gewicht / (lengte * lengte) * 100, 1);
Console.WriteLine(bmi);

// Advies Conditional // 
if (bmi < 18.5)
{
    advies = "Ondergewicht";
}
else if (bmi >= 18.5 && bmi < 25)
{
    advies = "Normaal gewicht";
}
else if (bmi >= 25 && bmi < 30)
{
    advies = "Overgewicht";
}
else
{
    advies = "Obesitas";
}

// Output //
Console.Clear();
Console.WriteLine($"Je weegt {gewicht}kg en bent {lengte}m lang en je bmi-score is {bmi}, je bent {advies}");