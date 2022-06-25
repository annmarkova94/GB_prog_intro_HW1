//Find which number is larger and which is smaller out of two numbers
Console.Write("Write the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Write the second number: ");
int number2 = int.Parse(Console.ReadLine());

int result1 = number1;
int result2 = number2;

if (number2 > number1)
{
    result1 = number2;
    result2 = number1;
}

Console.Write(result1 +" is larger than " + result2);

