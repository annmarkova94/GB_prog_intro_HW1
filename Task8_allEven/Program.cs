//Show all even numbers fromm 1 to N
Console.Write("Write your number: ");
int yourNumber = int.Parse(Console.ReadLine());
int currentNumber = 2;

string answer = "";

while (currentNumber <= yourNumber)
{
    answer = answer + ", " + Convert.ToString(currentNumber);
    currentNumber = currentNumber + 2;
}

Console.WriteLine(answer.Substring(2));