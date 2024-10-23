double budget = double.Parse(Console.ReadLine());
int numberExtras = int.Parse(Console.ReadLine());
double priceCostume = double.Parse(Console.ReadLine());

double priceDecor = budget * 0.1;
if (numberExtras > 150)
{
    priceCostume -= priceCostume * 0.1;
}
double sumCostumeExtras = priceCostume * numberExtras;

if(priceDecor + sumCostumeExtras > budget)
{
    Console.WriteLine($"Not enough money!");
    Console.WriteLine($"Wingard needs {Math.Abs(priceDecor + sumCostumeExtras - budget):f02} leva more.");
}
else
{

    Console.WriteLine($"Action!");
    Console.WriteLine($"Wingard starts filming with {Math.Abs(priceDecor + sumCostumeExtras - budget):f02} leva left.");
}




