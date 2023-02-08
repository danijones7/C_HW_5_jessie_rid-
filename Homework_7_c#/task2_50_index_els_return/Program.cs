// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool IndeksCheck(int rowN, int colN, int[,] matr)  // BOOL функиця возвращает значение true - если она сработала, в другом случае возвращает false 
{

    if (rowN <= matr.GetLength(0) && colN <= matr.GetLength(1))
    { return true; }

    return false;
}



int rows = InputNumber("Введите количество строк в массиве: ");
int columns = InputNumber("Введите количество  столбца в массиве: ");
System.Console.WriteLine();
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();
int rowNum = InputNumber("Введите на какой строке находится элемент в массиве: ");
int colNum = InputNumber("Введите на каком столбце находится элемент в массиве: ");
if (IndeksCheck(rowNum, colNum, matrix))
{                                                                                                               // -1 чтобы считал 1ю строку первой, а не нулевой
    System.Console.WriteLine($"Знаечение элемента, находящегося на {rowNum} строке, в {colNum} столбце: {matrix[rowNum - 1, colNum - 1]}");
}
else
{
    System.Console.WriteLine("Такого элемента не существует ");
}