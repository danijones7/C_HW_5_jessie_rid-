// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] ArrayStringsSums(int[,] matrix)
{
    int sum = 0;
    int[] array = new int[matrix.GetLength(0)];
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[k] = sum;
        k++;
        sum = 0;
    }
    return array;
}


int Minimum(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}


int[,] matrix = FillMatrix(3, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] array = ArrayStringsSums(matrix);
System.Console.Write($"Сумма элементов каждой строки поочередно: ");
PrintArray(array);
int min = Minimum(array);
System.Console.Write($"Наименьшая сумма элементов: ");
System.Console.WriteLine(min);
int StringNumber = Array.IndexOf(array, min) + 1;
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {StringNumber} строка");
