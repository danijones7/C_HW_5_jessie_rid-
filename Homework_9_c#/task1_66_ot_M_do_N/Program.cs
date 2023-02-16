//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string str)  // Функция, которая предлагает ввести пользователю число, и возвращает это число, или пишет, что введено некорректное значение 
{
    int number;
    string? text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}

int SumElements(int m, int n)  // Функция, которая с помощью рекурсии подсчитывает количество элементов в заданном промежутке 
{

    if (m <= n)
    {
        return m + SumElements(m + 1, n);
    }
    return 0;
}


//Основной код:

int M = InputNumber("Введите значение M: ");
int N = InputNumber("Введите значение N: ");
int sum = SumElements(M, N);
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна: {sum}");
