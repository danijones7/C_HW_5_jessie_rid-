// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


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

int Akerman(int m, int n)  // Функция Аккермана
{
if (m == 0)
{
return n+1;
}
if (m > 0 && n ==0)
{
return Akerman(m-1,1);
}
if (m > 0 && n > 0)
{
return Akerman(m-1, Akerman(m, n -1));
}
return 0;
}


int M = InputNumber("Введите неотрицательное число M: ");
int N = InputNumber("Введите неотрицательное число N: ");
int Ak = Akerman(M, N);
System.Console.WriteLine($"Функция Аккермана A({M},{N}) возвращает число: {Ak}");