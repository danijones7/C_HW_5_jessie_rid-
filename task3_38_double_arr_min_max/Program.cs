// //Задача 3 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double [] FillArrayWithRandomDoubleNumbers(int size, int leftRange, int rightRange) // Заполняет массив нужным  количесвтом элементов size, от левой границы до правой рандомными  вещественными числами
{
    double [] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)  // Выводит на печать заданный или полученный массив из вещественных чисел 
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double FindMax(double [] array) // Находит максимальное зн
{
double Max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > Max)
    {
        Max = array[i];
    }
}
return Max;
}

double FindMin(double [] array)
{
double Min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < Min)
    {
        Min = array[i];
    }
}
return Min;
}


double [] array = FillArrayWithRandomDoubleNumbers (5, 10, 50);
PrintArrayDouble(array);
double maximum = FindMax(array);
System.Console.WriteLine($"Максимальное значение элементов массива: {maximum}");
double minimum = FindMin(array);
System.Console.WriteLine($"Минимальное значение элементов массива: {minimum}");
double result = maximum - minimum;
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");
