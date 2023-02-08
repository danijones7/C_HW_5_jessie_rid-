// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
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

int InputNumber(string str)  // считывает введенный текст от пользователя, возвращает число, если текст - просит ввести еще раз 
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

// double FindAverageInColumn(int[,] matrix, int columnNumber) //- находит  среднее арифметическое для конкретного столбца 
// {
//     double sum = 0;
//     double average = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, columnNumber - 1];
//     }

//     average = sum / matrix.GetLength(0);
//     return average;
// }

double [] FindAverageInEachColumn(int[,] matrix)
{
    double [] array = new double[matrix.GetLength(1)];
    int arrayindex = 0;
    double sum = 0;
    double average = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        average = sum / matrix.GetLength(0);
        sum = 0;

        array[arrayindex] = Math.Round(average, 2);
        arrayindex ++;
    }
    return array;
}

void PrintArray(double [] arr)  // Выводит на печать заданный или полученный массив 
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}


int rows = InputNumber("Введите количество строк в массиве: ");
int columns = InputNumber("Введите количество  столбцов в массиве: ");
System.Console.WriteLine();
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();
// double average = FindAverageInColumn(matrix, InputNumber("Введите номер столбца, для которого требуется посчитать среднее арифметическое"));
// System.Console.WriteLine($"Среднее арифметическое столбца: {Math.Round(average, 2)}");
double [] ListOfAvg = FindAverageInEachColumn(matrix);
System.Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(ListOfAvg);


// Код без функции, который находит среднее арифметическое для каждого столбца поочередно 

// System.Console.WriteLine("Среднее арифметическое каждого столбца:");
// double sum = 0;
// double average = 0;
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, j];
//     }

//     average = sum / matrix.GetLength(0);
//     sum = 0;

//     System.Console.WriteLine(Math.Round(average, 2));
// }




