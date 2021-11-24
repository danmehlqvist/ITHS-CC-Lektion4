using ITHS_Lektion4;

Class1 class1 = new Class1();

int type = 1;
int amount = 100;
int years = 5;

var result = class1.Calculate(amount, type, years);

Console.WriteLine("The total price is: ");
Console.WriteLine(result);
