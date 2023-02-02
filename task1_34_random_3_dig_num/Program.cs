// Задача 1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) // Заполняет массив нужным  количесвтом элементов size, от левой границы до правой) 
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)  // Выводит на печать заданный или полученный массив 
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int CountEvenElements (int [] arr)  // Подсчитывает количество четных чисел в массиве 
{
int CountEvenElements = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    {
        CountEvenElements = CountEvenElements + 1;
    }
}
return CountEvenElements;
}

int[] array = FillArrayWithRandomNumbers(10, 100, 999);
PrintArray(array);
int count = CountEvenElements(array);
System.Console.WriteLine($"количество чётных чисел в массиве: {count}");
