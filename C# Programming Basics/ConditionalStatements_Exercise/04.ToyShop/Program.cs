double tripPrice = double.Parse(Console.ReadLine());
int puzzels = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int lorries = int.Parse(Console.ReadLine());
double puzzelPrice = 2.60;
double dollPrice = 3;
double bearPrice = 4.10;
double minionPrice = 8.20; 
double lorryPrice = 2;  


double orderPrice = puzzels * puzzelPrice + dolls * dollPrice + bears * bearPrice + minions * minionPrice + lorries * lorryPrice;
int numberToys = puzzels + dolls + minions + bears + lorries;   

if (numberToys >= 50)
{
    orderPrice -= orderPrice * 0.25; 
}
double finalIncome = orderPrice - orderPrice * 0.1;

if (finalIncome - tripPrice >= 0)
{
    Console.WriteLine($"Yes! {finalIncome - tripPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {Math.Abs (finalIncome - tripPrice):f2} lv needed.");
}