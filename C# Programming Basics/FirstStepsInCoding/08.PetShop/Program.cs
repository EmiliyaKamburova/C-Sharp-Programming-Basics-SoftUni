int numDogFood = int.Parse(Console.ReadLine());
int numCatFood = int.Parse(Console.ReadLine());
double priceDogFood = 2.50;
double priceCatFood = 4.00;

double finalSum = numDogFood * priceDogFood + numCatFood * priceCatFood;
Console.WriteLine($"{finalSum} lv.");

