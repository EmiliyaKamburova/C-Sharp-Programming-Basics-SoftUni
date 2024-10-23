int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int sumTime = firstTime + secondTime + thirdTime;

int minute = sumTime / 60;
int second = sumTime % 60;

if (second < 10)
{
    Console.WriteLine($"{minute}:0{second}");
}
else
{
    Console.WriteLine($"{minute}:{second}");
}