//Input
//•	Годишната такса за тренировки по баскетбол – цяло число в интервала [0… 9999]•	Годишната такса за тренировки по баскетбол – цяло число в интервала [0… 9999]
int annualPrice = int.Parse (Console.ReadLine ());

// Calculations
//за тренировки по баскетбол за период от 1 година. Нужна екипировка: 
//•	Баскетболни кецове – цената им е 40% по-малка от таксата за една година
//•	Баскетболен екип – цената му е 20% по-евтина от тази на кецовете
//•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
//•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

double shoes = annualPrice * 0.60; 
double sportSuit = shoes * 0.80; 
double basketball = sportSuit * 0.25; 
double accessories = basketball * 0.20; 
double allExpenses = annualPrice + shoes + sportSuit + basketball + accessories;

//Output
//Да се отпечата на конзолата колко ще са разходите на Джеси, ако започне да спортува баскетбол.
Console.WriteLine (allExpenses);
