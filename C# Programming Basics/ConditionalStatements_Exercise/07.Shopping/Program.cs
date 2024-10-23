double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());

double priceVideoCard = 250;
double priceProcessor = 0.35 * (priceVideoCard * videoCards);
double priceRamMemory = 0.1 * (priceVideoCard * videoCards);

double finalSum = videoCards * priceVideoCard + processors * priceProcessor + ramMemory * priceRamMemory; 

if (videoCards > processors)
{
    finalSum -= 0.15 * finalSum;
}

if (budget >= finalSum)
{
    Console.WriteLine($"You have {budget - finalSum:f02} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(budget - finalSum):f02} leva more!");
}

