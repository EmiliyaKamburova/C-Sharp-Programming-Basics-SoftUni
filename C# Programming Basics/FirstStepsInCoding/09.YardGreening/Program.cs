double squareMetres = double.Parse(Console.ReadLine());
double pricePerSquareMeter = 7.61;
double discount = 0.18;

double totalPrice = squareMetres * pricePerSquareMeter;
double finalPrice = squareMetres * pricePerSquareMeter * 0.82;
double discountFinalPrice = totalPrice * 0.18;
Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discountFinalPrice} lv.");

