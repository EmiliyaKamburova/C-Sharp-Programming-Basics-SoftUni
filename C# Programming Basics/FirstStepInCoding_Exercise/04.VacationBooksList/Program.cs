//1.	Брой страници в текущата книга – цяло число в интервала [1…1000]
//2.	Страници, които прочита за 1 час – цяло число в интервала [1…1000]
//3.	Броят на дните, за които трябва да прочете книгата – цяло число в интервала [1…1000]

int numberOfPages = int.Parse(Console.ReadLine());
int numberOfPagesPerHour = int.Parse(Console.ReadLine());
int numberOfDaysToReadBook = int.Parse(Console.ReadLine());

int hoursToReadBook = numberOfPages / numberOfPagesPerHour; // how many hours are needed to read a bokk
int hoursPerDayReading = hoursToReadBook / numberOfDaysToReadBook; // how many hours needs to read per day 

Console.WriteLine(hoursPerDayReading);