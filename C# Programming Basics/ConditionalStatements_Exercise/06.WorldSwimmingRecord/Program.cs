double worldRecord = double.Parse(Console.ReadLine());
double distanceMetres = double.Parse(Console.ReadLine());
double timeMetreInSeconds = double.Parse(Console.ReadLine());


double delay = Math.Floor (distanceMetres / 15) * 12.5;
double finalTime = distanceMetres * timeMetreInSeconds + delay;

if (finalTime < worldRecord)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f02} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {finalTime - worldRecord:f02} seconds slower.");
}



