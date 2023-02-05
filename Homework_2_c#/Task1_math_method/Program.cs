// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Математическое решение

System.Console.WriteLine("Введите 3-значное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >99 && number < 1000)
{
    int result = (number / 10) - (number / 100 * 10);
    System.Console.WriteLine($"Вторая цифра числа {number}: {result}");
}
else
{
    System.Console.WriteLine("Введено не 3-значное число");
}

