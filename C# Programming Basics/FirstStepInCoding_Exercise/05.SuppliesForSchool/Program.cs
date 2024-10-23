int numbeOfPacketsPens = int.Parse(Console.ReadLine());
int numbeOfPacketsMarkers = int.Parse(Console.ReadLine());
int litresOfDetergent = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pricePens = 5.80;
double priceMarkers = 7.20;
double priceDetergent = 1.20;

//print:Да се отпечата на конзолата колко пари ще са нужни на Ани, за да си плати сметката.
double priceAllGoods = numbeOfPacketsPens * pricePens + numbeOfPacketsMarkers * priceMarkers + litresOfDetergent * priceDetergent;
double finalPrice = priceAllGoods - priceAllGoods * discount * 0.01;

Console.WriteLine(finalPrice);