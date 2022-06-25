Console.Write("Write the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Write the second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Write the third number: ");
int number3 = int.Parse(Console.ReadLine());

int maxim = number1;

if (number2 > maxim) maxim = number2;
if (number3 > maxim) maxim = number3;

Console.WriteLine("The largest number is " + maxim);

