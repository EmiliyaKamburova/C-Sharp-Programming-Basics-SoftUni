int hour = int. Parse (Console.ReadLine ());
int minutes = int. Parse (Console.ReadLine ());

int minutesAfter15Min = minutes + 15;
if (minutesAfter15Min > 59)
{
    hour += 1;
    minutesAfter15Min -= 60;    
}
if (hour > 23) 
{ 
    hour -= 24;
}
if (minutesAfter15Min < 10)
{
    Console.WriteLine($"{hour}:0{minutesAfter15Min}");
}
else
{
    Console.WriteLine($"{hour}:{minutesAfter15Min}");
}
