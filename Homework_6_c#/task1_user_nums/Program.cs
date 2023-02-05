// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] UserFillsArray(string str)   
{

    System.Console.WriteLine(str);
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int[] array = UserFillsArray("Введите числа через пробел");
int result = CountPositiveNumbers(array);
System.Console.WriteLine($"Количество чисел больше 0: {result}");
