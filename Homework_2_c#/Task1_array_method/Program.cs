// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Решение  с использованием массива

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length == 3)
{
    System.Console.WriteLine($"Вторая цифра этого числа: {numberText[1]}");
}
else
{
    System.Console.WriteLine("Введено НЕ 3-значное число");
}

