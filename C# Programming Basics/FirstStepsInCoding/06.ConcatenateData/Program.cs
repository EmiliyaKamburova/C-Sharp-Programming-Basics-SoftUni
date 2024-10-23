//Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата следното съобщение: "You are <firstName> <lastName>, a <age>-years old person from <town>."

string firstName = Console.ReadLine();
string familyName = Console.ReadLine();
int age = int.Parse (Console.ReadLine());
string city = Console.ReadLine();

Console.WriteLine($"You are {firstName} {familyName}, a {age}-years old person from {city}.");