// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("How many sandwhichs would you like?");
int numberOfSandwhichs = int.Parse(Console.ReadLine());
Console.WriteLine("how many topping would you like?");
int numberOfToppings = int.Parse(Console.ReadLine());
Console.WriteLine("How much would you like to tip");
double tip = int.Parse(Console.ReadLine());

double costOfSandwhich = numberOfSandwhichs*4.75;
double costOfToppings = numberOfToppings*0.55;
double costOfOrder = costOfSandwhich+costOfToppings;
double discountAmount = costOfOrder*0.1;
double totalSandwhichCost = costOfOrder-discountAmount;
Console.WriteLine("you sandwhich(s) will be "+totalSandwhichCost);

