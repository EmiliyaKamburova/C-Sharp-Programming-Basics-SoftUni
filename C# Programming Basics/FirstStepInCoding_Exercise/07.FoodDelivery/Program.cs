//Input
//•	Брой пилешки менюта – цяло число в интервала [0 … 99]
//•	Брой менюта с риба – цяло число в интервала [0 … 99]
//•	Брой вегетариански менюта – цяло число в интервала [0 … 99]

int chickenMenus = int.Parse(Console.ReadLine()); 
int fishMenus = int.Parse(Console.ReadLine()); 
int veggieMenus = int.Parse(Console.ReadLine());


//Constants
//•	Пилешко меню –  10.35 лв. 
//•	Меню с риба – 12.40 лв. 
//•	Вегетарианско меню  – 8.15 лв. 
double priceChickenMenu = 10.35;
double priceFishMenu = 12.40;
double priceVeggieMenu = 8.15;


//Calculations
//Групата ще си поръча и десерт, чиято цена е равна на 20% от общата сметка (без доставката). 
//Цената на доставка е 2.50 лв и се начислява най-накрая.  
double priceAllMenus= chickenMenus * priceChickenMenu + fishMenus * priceFishMenu + veggieMenus * priceVeggieMenu;
double priceDessert = priceAllMenus * 0.20;
double priceDelivery = 2.50;
double priceOrder = priceAllMenus + priceDessert + priceDelivery;
//Output
//"{цена на поръчката}"
Console.WriteLine(priceOrder);


