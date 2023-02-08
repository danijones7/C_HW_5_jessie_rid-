// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] FillMatrixWithRandoms(int rows, int columns, int leftrange, int rightrange)
{
    Random rand = new Random();

    double[,] matr = new double[rows, columns];
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = Math.Round(rand.Next(leftrange, rightrange + 1) + rand.NextDouble(), 2);
            }
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
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


int rows = InputNumber("Введите количество строк в массиве: ");
int columns = InputNumber("Введите количество столбцов в массиве: ");
double[,] array2d = FillMatrixWithRandoms(rows, columns, 0, 10);
System.Console.WriteLine();
PrintMatrix(array2d);