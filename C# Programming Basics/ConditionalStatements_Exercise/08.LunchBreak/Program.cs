string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int lunchBreakDuration = int.Parse(Console.ReadLine());

double lunchTime = 0.125 * lunchBreakDuration;
double relaxTime = 0.25 * lunchBreakDuration;

double leftTime = lunchBreakDuration - lunchTime - relaxTime;

if (leftTime > episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling (leftTime - episodeDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling (episodeDuration - leftTime)} more minutes.");
}
