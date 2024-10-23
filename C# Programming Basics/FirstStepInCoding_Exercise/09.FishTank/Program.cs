//input
//1.	Дължина в см – цяло число в интервала [10 … 500]
//2.	Широчина в см – цяло число в интервала [10 … 300]
//3.	Височина в см – цяло число в интервала [10… 200]
//4.	Процент, зает от растения, пясък..  – реално число в интервала [0.000 … 100.000]
int lenght = int.Parse (Console.ReadLine ());
int width = int.Parse (Console.ReadLine ());
int height = int.Parse (Console.ReadLine ());
double percentageSand = double.Parse (Console.ReadLine ());


//calculations
// Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/. 
// литрите вода, които ще  събира аквариума.
double volumeCubicCm = lenght * width * height;
double volumeLitres = volumeCubicCm * 0.001;
double litresWater = volumeLitres - volumeLitres * percentageSand * 0.01;


//output
//•	литрите вода, които ще  събира аквариума.
Console.WriteLine (litresWater);