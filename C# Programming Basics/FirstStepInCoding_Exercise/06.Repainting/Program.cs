// Input
//1.	Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
//2.	Необходимо количество боя (в литри) - цяло число в интервала [1…100]
//3.	Количество разредител (в литри) - цяло число в интервала [1…30]
//4.	Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]
int nylon = int.Parse (Console.ReadLine ());
int paint = int.Parse (Console.ReadLine ());
int thinner = int.Parse (Console.ReadLine ());
int workHours = int.Parse (Console.ReadLine ());

//Constants
double priceNylon = 1.50;
double pricePaint = 14.50;
double priceThinner = 5.00;

//Calculations
//към необходимите материали, Румен иска да добави още 10% от количеството боя и 2 кв.м. найлон, разбира се и 0.40 лв. за торбички. 
//Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30% от сбора на всички разходи за материали.
double priceBags = 0.40;
double addPaint = paint * 0.10;
int addNylon = 2;
double priceMaterials = (nylon + addNylon) * priceNylon + (paint + addPaint) * pricePaint + thinner * priceThinner + priceBags;
double priceWorkersPerHour = priceMaterials * 0.30;
double priceWorkers = priceWorkersPerHour * workHours;
double allExpenses = priceMaterials + priceWorkers; 

// Output
//	"{сумата на всички разходи}"
Console.WriteLine (allExpenses);


