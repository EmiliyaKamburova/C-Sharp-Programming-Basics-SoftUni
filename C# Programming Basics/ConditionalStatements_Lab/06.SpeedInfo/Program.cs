﻿double speed = double.Parse(Console.ReadLine());

string output = "";

if (speed <= 10)
{
    output = "slow";
}
else if ( speed <= 50)
{
    output = "average";
}
else if (speed <= 150)
{
    output = "fast";
}
else if (speed <= 1000)
{
    output = "ultra fast";
}
else
{
    output = "extremely fast";
}
Console.WriteLine(output);
