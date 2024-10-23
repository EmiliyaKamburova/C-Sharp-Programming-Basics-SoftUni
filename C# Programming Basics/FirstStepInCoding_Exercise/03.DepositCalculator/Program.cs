double depositSum = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double finalSum = depositSum + depositPeriod * ((depositSum * annualInterestRate * 0.01) / 12);

Console.WriteLine(finalSum);
