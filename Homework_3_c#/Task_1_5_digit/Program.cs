// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите 5-значное число");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length == 5)
{
    if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
        System.Console.WriteLine($"Число {number} является палиндромом");
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введено НЕ 5-значное число");
}

