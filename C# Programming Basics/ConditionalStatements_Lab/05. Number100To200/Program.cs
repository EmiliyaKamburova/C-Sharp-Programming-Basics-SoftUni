﻿int number = int.Parse(Console.ReadLine());

string output = "";

if (number < 100)
{
    output = "Less than 100";
}
else if (number <= 200)
{
    output = "Between 100 and 200";
}
else
{
    output = "Greater than 200";
}
Console.WriteLine(output);