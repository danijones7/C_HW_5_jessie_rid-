// Задача 2 Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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


int SumOfOddNumbers(int [] array)   // Находит сумму элементов, стоящих на нечётных позициях
{
int SumOddNumners = 0;
for (int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        SumOddNumners = SumOddNumners + array [i];
    }
}
return SumOddNumners;
}

int [] array = FillArrayWithRandomNumbers(5, -10, 10);
PrintArray(array);
int sum = SumOfOddNumbers(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sum}");